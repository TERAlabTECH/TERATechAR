using UnityEngine;

public class Estado : MonoBehaviour
{
    private Vector3 initialLocalPosition;
    private Renderer objectRenderer; // Reference to the Renderer component

    public Material elevatedMaterial; // Material to apply when elevated
    private Material originalMaterial; // Original material to revert to

    void Awake()
    {
        initialLocalPosition = transform.localPosition;
        objectRenderer = GetComponent<Renderer>(); // Get the Renderer component
        originalMaterial = objectRenderer.material; // Store the original material
    }

    public Vector3 GetPosition()
    {
        return transform.localPosition;
    }

    public void Elevar()
    {
        // Change the material to the elevated material
        if (elevatedMaterial != null)
            objectRenderer.material = elevatedMaterial;

        // Example elevation logic (adjust as needed)
        transform.localPosition = new Vector3(initialLocalPosition.x, initialLocalPosition.y, initialLocalPosition.z + 0.055f);
        Debug.Log($"{gameObject.name} elevated to {transform.localPosition}");
    }

    public void Bajar()
    {
        // Revert to the original material
        objectRenderer.material = originalMaterial;

        // Reset to the initial local position
        transform.localPosition = initialLocalPosition;
    }
}
