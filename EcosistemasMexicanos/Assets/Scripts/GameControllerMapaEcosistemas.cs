using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;

public class GameControllerMapaEcosistemas : MonoBehaviour
{
    [Header("Suelo")]//Agregamos un suelo a la experiencia para que no se pierdan los modelos con el suelo real
    [SerializeField] private GameObject suelo; 

    [Header("Estados")]
    [SerializeField] private Estado Aguascalientes;
    [SerializeField] private Estado BajaCalifornia;
    [SerializeField] private Estado BajaCaliforniaSur;
    [SerializeField] private Estado Campeche;
    [SerializeField] private Estado Chiapas;
    [SerializeField] private Estado Chihuahua;
    [SerializeField] private Estado CiudadDeMexico;
    [SerializeField] private Estado Coahuila;
    [SerializeField] private Estado Colima;
    [SerializeField] private Estado Durango;
    [SerializeField] private Estado EstadoDeMexico;
    [SerializeField] private Estado Guanajuato;
    [SerializeField] private Estado Guerrero;
    [SerializeField] private Estado Hidalgo;
    [SerializeField] private Estado Jalisco;
    [SerializeField] private Estado Michoacan;
    [SerializeField] private Estado Morelos;
    [SerializeField] private Estado Nayarit;
    [SerializeField] private Estado NuevoLeon;
    [SerializeField] private Estado Oaxaca;
    [SerializeField] private Estado Puebla;
    [SerializeField] private Estado Queretaro;
    [SerializeField] private Estado QuintanaRoo;
    [SerializeField] private Estado SanLuisPotosi;
    [SerializeField] private Estado Sinaloa;
    [SerializeField] private Estado Sonora;
    [SerializeField] private Estado Tabasco;
    [SerializeField] private Estado Tamaulipas;
    [SerializeField] private Estado Tlaxcala;
    [SerializeField] private Estado Veracruz;
    [SerializeField] private Estado Yucatan;
    [SerializeField] private Estado Zacatecas;

    private Estado[] estado;

    private Dictionary<string, List<Estado>> ecosistemasEstados = new Dictionary<string, List<Estado>>();
    private Dictionary<string, Color> ecosistemaColores;

    // Start is called before the first frame update
    void Awake()
    {
        estado = new Estado[] {
             Aguascalientes,BajaCalifornia, BajaCaliforniaSur, Campeche,Chiapas,Chihuahua,
            CiudadDeMexico,Coahuila,Colima,Durango,EstadoDeMexico,Guanajuato,Guerrero,Hidalgo,
            Jalisco,Michoacan,Morelos,Nayarit,NuevoLeon,Oaxaca,Puebla,Queretaro,QuintanaRoo,SanLuisPotosi,
            Sinaloa,Sonora,Tabasco,Tamaulipas,Tlaxcala,Veracruz,Yucatan,Zacatecas
        };

        // Poner colores más adoc
        ecosistemaColores = new Dictionary<string, Color>
        {
            { "Semiarido", Color.yellow },
            { "Desierto", Color.red },
            { "Arrecife", Color.cyan },
            { "SelvaTropical", Color.green },
            { "Bosque", Color.black },
            { "BosqueTropical", Color.magenta },
            { "Matorral", Color.gray },
            { "Selva", Color.blue },
            { "SelvaLLuviosa", Color.gray }
        };

    }

    private void Start()
    {
        ecosistemasEstados["Semiarido"] = new List<Estado> { Aguascalientes };
        ecosistemasEstados["Desierto"] = new List<Estado> { BajaCalifornia, BajaCaliforniaSur, Coahuila, Chihuahua, Durango, NuevoLeon, SanLuisPotosi, Sinaloa, Sonora, Tamaulipas, Zacatecas };
        ecosistemasEstados["Arrecife"] = new List<Estado> { BajaCaliforniaSur };
        ecosistemasEstados["SelvaTropical"] = new List<Estado> { Campeche, Oaxaca, QuintanaRoo, Tabasco, Veracruz, Yucatan };
        ecosistemasEstados["Bosque"] = new List<Estado> { CiudadDeMexico, Coahuila, Durango, EstadoDeMexico, Guerrero, Jalisco, Michoacan, Morelos, NuevoLeon, Puebla, Queretaro, Sinaloa, Tamaulipas, Tlaxcala, Zacatecas };
        ecosistemasEstados["BosqueTropical"] = new List<Estado> { Colima };
        ecosistemasEstados["Matorral"] = new List<Estado> { Guanajuato, Hidalgo };
        ecosistemasEstados["Selva"] = new List<Estado> { Campeche, Nayarit };
        ecosistemasEstados["SelvaLLuviosa"] = new List<Estado> { Chiapas };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) // Assuming Q is for Semiarido
        {
            ActivarEcosistema("Semiarido");
        }
        if (Input.GetKeyDown(KeyCode.W)) // Assuming W is for Desierto
        {
            ActivarEcosistema("Desierto");

        }
        if (Input.GetKeyDown(KeyCode.E)) // Assuming E is for Arrecife
        {
            ActivarEcosistema("Arrecife");
        }
        if (Input.GetKeyDown(KeyCode.R)) // Assuming R is for Selva Tropical
        {
            ActivarEcosistema("SelvaTropical");
        }
        if (Input.GetKeyDown(KeyCode.T)) // Assuming T is for Bosque
        {
            ActivarEcosistema("Bosque");
        }
        if (Input.GetKeyDown(KeyCode.Y)) // Assuming Y is for Bosque Tropical
        {
            ActivarEcosistema("BosqueTropical");
        }
        if (Input.GetKeyDown(KeyCode.U)) // Assuming U is for Matorral
        {
            ActivarEcosistema("Matorral");
        }
        if (Input.GetKeyDown(KeyCode.P)) // Assuming U is for Matorral
        {
            ResetAllEstados();
        }
    }



    private void ActivarEcosistema(string nombreEcosistema)
    {
        ResetAllEstados();
        if (ecosistemasEstados.ContainsKey(nombreEcosistema))
        {
            Color colorEcosistema = ecosistemaColores[nombreEcosistema]; // Get the color for the ecosystem
            foreach (var est in ecosistemasEstados[nombreEcosistema])
            {
                est.Elevar();
                est.ChangeColor(colorEcosistema); // Change to the color associated with the ecosystem
            }
        }
    }

    private void ResetAllEstados()
    {
        foreach (var est in estado)
        {
            est.Bajar();
            est.ChangeColor(Color.white); // Change color back to white when not elevated
        }
    }


}
        

