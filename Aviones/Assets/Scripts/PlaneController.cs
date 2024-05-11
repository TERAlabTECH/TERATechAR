using System;
using UnityEngine;  // Eliminar 'using System.Numerics;' para evitar ambigüedades con Vector3

public class PlaneController : MonoBehaviour
{
    public Transform target;  // Alrededor de qué queremos girar
    public float speed = 2f;  // Velocidad de movimiento en círculo
    public float radius = 1f;  // Radio del círculo
    public float angle = 0f;  // Dónde en el círculo está el objeto
    private float initialY;  // Altura inicial del avión
    public float pitchOffset = 0f;  // Offset de inclinación para corregir la orientación del avión
    public float yawOffset = 0f;    // Offset adicional para la rotación sobre el eje Y

    void Start()
    {
        // Guarda la altura inicial del avión
        initialY = transform.position.y;
    }

    void Update()
    {
        // Calcula la nueva posición del objeto
        float x = target.position.x + Mathf.Cos(angle) * radius;
        float z = target.position.z + Mathf.Sin(angle) * radius;

        // Actualiza la posición
        transform.position = new Vector3(x, initialY, z);

        // Calcula la rotación necesaria para que el frente del avión mire hacia la dirección de su movimiento
        Quaternion targetRotation = Quaternion.Euler(pitchOffset, -angle * Mathf.Rad2Deg + 90 + yawOffset, 0);
        transform.rotation = targetRotation;

        // Incrementa el ángulo
        angle += speed * Time.deltaTime;
    }
}
