using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField] private GameObject firstPanel; // Panel that should be visible at the start.
    [SerializeField] private GameObject secondPanel; // Additional panel to be toggled.
    [SerializeField] private GameObject thirdPanel; // You can add as many as you need.

    private void Start()
    {
        // Ensure that only the first panel is active when the game starts.
        firstPanel.SetActive(true);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
    }

    // Call this method using a button's OnClick event to toggle the second panel.
    public void ShowSecondPanel()
    {
        secondPanel.SetActive(true);
    }

    public void ShowThirdPanel()
    {
        thirdPanel.SetActive(true);
    }


    // If you want to toggle it off again with the same or a different button:
    public void HidePanels()
    {
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
    }


}
