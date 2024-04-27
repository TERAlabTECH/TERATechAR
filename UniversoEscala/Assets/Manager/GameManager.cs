using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Escenas")] 
    [SerializeField] private Escena EarthVsMoon;
    [SerializeField] private Escena EarthVsSun;
    [SerializeField] private Escena SunVsProxima;
    // Start is called before the first frame update

    private Escena[] escenas; 
    void Awake()
    {
        escenas= new Escena[] {
            EarthVsMoon, EarthVsSun, SunVsProxima
        };
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowScene(GameObject scene)
    {   

        scene.SetActive(true);
    }

}
