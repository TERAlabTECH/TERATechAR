using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;

public class GameControllerMapaEcosistemas : MonoBehaviour
{

    [Header("Estados")]
    [SerializeField] private GameObject Aguascalientes;
    [SerializeField] private GameObject BajaCalifornia;
    [SerializeField] private GameObject BajaCaliforniaSur;
    [SerializeField] private GameObject Campeche;
    [SerializeField] private GameObject Chiapas;
    [SerializeField] private GameObject Chihuahua;
    [SerializeField] private GameObject CiudadDeMexico;
    [SerializeField] private GameObject Coahuila;
    [SerializeField] private GameObject Colima;
    [SerializeField] private GameObject Durango;
    [SerializeField] private GameObject EstadoDeMexico;
    [SerializeField] private GameObject Guanajuato;
    [SerializeField] private GameObject Guerrero;
    [SerializeField] private GameObject Hidalgo;
    [SerializeField] private GameObject Jalisco;
    [SerializeField] private GameObject Michoacan;
    [SerializeField] private GameObject Morelos;
    [SerializeField] private GameObject Nayarit;
    [SerializeField] private GameObject NuevoLeon;
    [SerializeField] private GameObject Oaxaca;
    [SerializeField] private GameObject Puebla;
    [SerializeField] private GameObject Queretaro;
    [SerializeField] private GameObject QuintanaRoo;
    [SerializeField] private GameObject SanLuisPotosi;
    [SerializeField] private GameObject Sinaloa;
    [SerializeField] private GameObject Sonora;
    [SerializeField] private GameObject Tabasco;
    [SerializeField] private GameObject Tamaulipas;
    [SerializeField] private GameObject Tlaxcala;
    [SerializeField] private GameObject Veracruz;
    [SerializeField] private GameObject Yucatan;
    [SerializeField] private GameObject Zacatecas;

    private Estado[] estado;
    //private Estado[] Semiarido;
    //private Estado[] Desierto;
    //private Estado[] Arrecife;
    //private Estado[] SelvaTropical;
    //private Estado[] Bosque;
    //private Estado[] BosqueTropical;
    //private Estado[] Matorral;
    //private Estado[] Selva;
    //private Estado[] SelvaLLuviosa;

    private Dictionary<string, List<Estado>> ecosistemasEstados = new Dictionary<string, List<Estado>>();

    // Start is called before the first frame update
    void Start()
    {
        estado = new Estado[] {
            new Estado(Aguascalientes),         //0
            new Estado(BajaCalifornia),         //1
            new Estado(BajaCaliforniaSur),      //2
            new Estado(Campeche),               //3
            new Estado(Chiapas),                //4
            new Estado(Chihuahua),              //5
            new Estado(CiudadDeMexico),         //6
            new Estado(Coahuila),               //7
            new Estado(Colima),                 //8
            new Estado(Durango),                //9
            new Estado(EstadoDeMexico),         //10
            new Estado(Guanajuato),             //11
            new Estado(Guerrero),               //12
            new Estado(Hidalgo),                //13
            new Estado(Jalisco),                //14
            new Estado(Michoacan),              //15
            new Estado(Morelos),                //16
            new Estado(Nayarit),                //17
            new Estado(NuevoLeon),              //18
            new Estado(Oaxaca),                 //19
            new Estado(Puebla),                 //20
            new Estado(Queretaro),              //21
            new Estado(QuintanaRoo),            //22
            new Estado(SanLuisPotosi),          //23
            new Estado(Sinaloa),                //24
            new Estado(Sonora),                 //25
            new Estado(Tabasco),                //26
            new Estado(Tamaulipas),             //27
            new Estado(Tlaxcala),               //28
            new Estado(Veracruz),               //29
            new Estado(Yucatan),                //30
            new Estado(Zacatecas),              //31
        };

        ecosistemasEstados["Semiarido"] = new List<Estado> { estado[0] }; 
        ecosistemasEstados["Desierto"] = new List<Estado> { estado[1], estado[2], estado[7], estado[5], estado[9], estado[18], estado[23], estado[24], estado[25], estado[27], estado[31] };
        ecosistemasEstados["Arrecife"] = new List<Estado> { estado[2] }; 
        ecosistemasEstados["SelvaTropical"] = new List<Estado> { estado[3], estado[19], estado[22], estado[26], estado[30] };
        ecosistemasEstados["Bosque"] = new List<Estado> { estado[7], estado[9], estado[10], estado[12], estado[14], estado[15], estado[16], estado[18], estado[20], estado[21], estado[24], estado[27], estado[28], estado[31] };
        ecosistemasEstados["BosqueTropical"] = new List<Estado> { estado[8] };
        ecosistemasEstados["Matorral"] = new List<Estado> { estado[11], estado[13] };
        ecosistemasEstados["Selva"] = new List<Estado> { estado[3], estado[17] };
        ecosistemasEstados["SelvaLLuviosa"] = new List<Estado> { estado[4] };


        Vector3 pos = estado[1].GetPosition();
        Debug.Log(pos);
}

        

    
    // Update is called once per frame
    void Update()
    {

    }

}
        

