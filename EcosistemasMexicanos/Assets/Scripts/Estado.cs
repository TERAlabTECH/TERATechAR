using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 initialOffset;
    private Vector3 initialGroundPlanePosition;

    // Awake is called when the script instance is being loaded.
    void Awake()
    {
        initialPosition = transform.localPosition; // Store the initial position at the time of creation.
        initialGroundPlanePosition = transform.parent.position; // Store the initial ground plane position.
        initialOffset = initialPosition - transform.parent.position; // Calculate the initial offset from the ground plane.
    }

    public Vector4 GetPosition()
    {
        return gameObject.transform.position;
    }

    // Método para elevar este estado.
    public void Elevar()
    {
        // Calculate the new Z position based on the parent's current position plus a fixed elevation amount.
        float newY = transform.localPosition.y + 0.04f;

        Debug.Log(gameObject.name + " pos: " + GetPosition());
        // Set the new position, maintaining the current X and Y positions relative to the parent.
        gameObject.transform.position = new Vector3(transform.localPosition.x, newY, transform.localPosition.z);

       
        Debug.Log(gameObject.name + " elevated to " + gameObject.transform.position);
    }

    // Método para Bajar este estado (después de que fue elevado).
    public void Bajar()
    {
        // Reset to the initial position.
        gameObject.transform.position = initialPosition;
    }
}
