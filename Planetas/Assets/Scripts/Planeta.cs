// Planeta.cs
using UnityEngine;

public class Planeta : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(gameObject.name + " is being hidden on Awake");
        Hide(); // Hide the planets as soon as they're ready
    }

    public void Show()
    {
        Debug.Log(gameObject.name + " is being shown");
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        Debug.Log(gameObject.name + " is being hidden");
        gameObject.SetActive(false);
    }
}
