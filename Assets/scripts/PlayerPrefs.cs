using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GuardarDatos : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void GuardaDatos()
    {
        PlayerPrefs.SetString("Jugador", "Aitana");

        PlayerPrefs.Save();

        Debug.Log("Datos guardaos");

    }

    void CargarDatos()
    {
        string jugador = PlayerPrefs.GetString("Jugador", "Desconocido");
        Debug.Log("Datos recuperaos: Nombre = " +  jugador);

    }

    void BorrarDatos()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("td eliminao");
    }
    // Update is called once per frame
    
}
