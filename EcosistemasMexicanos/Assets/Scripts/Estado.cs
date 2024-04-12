using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado : MonoBehaviour
{
    private Vector3 initialPosition;


    // Awake is called when the script instance is being loaded.
    void Awake()
    {
        initialPosition = transform.position; // Store the initial position at the time of creation
    }

    public Vector4 GetPosition() {
        return gameObject.transform.position;
    }

    // Método para elevar este estado
    public void Elevar()
    {
        Vector3 newPosition = initialPosition + new Vector3(0, 0, 0.055f); // Try elevating by 1 unit on the Y axis
        gameObject.transform.position = newPosition;
        Debug.Log(gameObject.name + " elevated to " + newPosition);
    }


    // Método para Bajar este estado (después de que fue elevado
    public void Bajar()
    {
        gameObject.transform.position = initialPosition; // Reset to the initial position
    }

}
