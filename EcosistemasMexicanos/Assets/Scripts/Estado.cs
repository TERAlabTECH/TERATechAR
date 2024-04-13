using UnityEngine;

public class Estado : MonoBehaviour
{
    [SerializeField] private GameObject[] associatedModels;

    private Vector3 initialLocalPosition;
    private Renderer renderer;


    // Awake is called when the script instance is being loaded.
    void Awake()
    {
        initialLocalPosition = transform.localPosition; // Store the initial local position.
        renderer = GetComponent<Renderer>(); // Get the Renderer component at start.
        foreach (var model in associatedModels)
        {
            model.SetActive(false);
        }
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
        foreach (var model in associatedModels)
        {
            model.SetActive(true);
        }

    }

    // Método para Bajar este estado (después de que fue elevado).
    public void Bajar()
    {
        // Reset to the initial local position.
        transform.localPosition = initialLocalPosition;
        foreach (var model in associatedModels)
        {
            model.SetActive(false);
        }

    }

    public void ChangeColor(Color newColor)
    {
        if (renderer != null)
        {
            renderer.material.color = newColor; // Set the material color to the new color.
        }
    }
}
