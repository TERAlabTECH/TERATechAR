using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [Header("Escenas")]
    [SerializeField] private GameObject Escena1;
    [SerializeField] private GameObject Escena2;
    [SerializeField] private GameObject Escena3;

    [SerializeField] private GameObject Escena4;

    // Start is called before the first frame update
    void Start()
    {
        Escena1.SetActive(true);
        Escena2.SetActive(false);
        Escena3.SetActive(false);
       
    }

    // Update is called once per frame
    public void ShowFirstPanel()
    {
        Escena1.SetActive(true);
    }
    public void ShowSecondPanel()
    {
        Escena2.SetActive(true);
    }
    //noton

    public void ShowThirdPanel()
    {
        Escena3.SetActive(true);
    }
    


    // If you want to toggle it off again with the same or a different button:
    public void HidePanels()
    {
        Escena1.SetActive(false);
        Escena2.SetActive(false);
        Escena3.SetActive(false);
        
    }

}
