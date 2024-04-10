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

    // Start is called before the first frame update
    void Start()
    {
        estado = new Estado[] {
            new Estado(Aguascalientes),
            new Estado(BajaCalifornia),
            new Estado(BajaCaliforniaSur),
            new Estado(Campeche),
            new Estado(Chiapas),
            new Estado(Chihuahua),
            new Estado(CiudadDeMexico),
            new Estado(Coahuila),
            new Estado(Colima),
            new Estado(Durango),
            new Estado(EstadoDeMexico),
            new Estado(Guanajuato),
            new Estado(Guerrero),
            new Estado(Hidalgo),
            new Estado(Jalisco),
            new Estado(Michoacan),
            new Estado(Morelos),
            new Estado(Nayarit),
            new Estado(NuevoLeon),
            new Estado(Oaxaca),
            new Estado(Puebla),
            new Estado(Queretaro),
            new Estado(QuintanaRoo),
            new Estado(SanLuisPotosi),
            new Estado(Sinaloa),
            new Estado(Sonora),
            new Estado(Tabasco),
            new Estado(Tamaulipas),
            new Estado(Tlaxcala),
            new Estado(Veracruz),
            new Estado(Yucatan),
            new Estado(Zacatecas),
        };

        Vector3 pos = estado[1].GetPosition();
        Debug.Log(pos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
