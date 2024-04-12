using UnityEngine;

public class Estado : MonoBehaviour
{
    private Vector3 initialLocalPosition;

    // Awake is called when the script instance is being loaded.
    void Awake()
    {
        initialLocalPosition = transform.localPosition; // Store the initial local position.
    }

    public Vector3 GetPosition()
    {
        return transform.localPosition; // Use localPosition instead of global position.
    }

    // Método para elevar este estado.
    public void Elevar()
    {
        // Calculate the new local Y position with a fixed elevation amount.
        float newY = transform.localPosition.y + 0.1f;

        // Set the new local position, maintaining the current X and Z positions.
        transform.localPosition = new Vector3(transform.localPosition.x, newY, transform.localPosition.z);

    }

    // Método para Bajar este estado (después de que fue elevado).
    public void Bajar()
    {
        // Reset to the initial local position.
        transform.localPosition = initialLocalPosition;

    }
}
