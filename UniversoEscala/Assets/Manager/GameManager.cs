using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Escenas")] 
    [SerializeField] private GameObject EarthVsMoon;
    [SerializeField] private GameObject EarthVsSun;
    [SerializeField] private GameObject SunVsProxima;
    // Start is called before the first frame update

   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowScene(GameObject scene)
    {   

        scene.SetActive(false);
    }

}
