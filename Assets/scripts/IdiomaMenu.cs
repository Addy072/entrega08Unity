using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class IdiomasAplicacion : MonoBehaviour
{
    // Referencias a los textos de la UI
    public TextMeshProUGUI iniciarSesionText;
    public TextMeshProUGUI nombreText;
    public TextMeshProUGUI codigoPersonalText;
    public TextMeshProUGUI emailText;
    public TextMeshProUGUI contrase�aText;
    public TextMeshProUGUI iniciarSesionRepetidoText;
    public TextMeshProUGUI presionaIniciarSesionText;
    public TextMeshProUGUI jugarText;
    public TextMeshProUGUI recordsText;
    public TextMeshProUGUI recordsRepetidoText;
    public TextMeshProUGUI creditosText;
    public TextMeshProUGUI creditosRepetidoText;
    public TextMeshProUGUI galeriaText;
    public TextMeshProUGUI galeriaRepetidoText;
    public TextMeshProUGUI ajustesText;
    public TextMeshProUGUI seguroSalirText;
    public TextMeshProUGUI cambiosNoGuardadosText;
    public TextMeshProUGUI siText;
    public TextMeshProUGUI noText;
    public TextMeshProUGUI salirText;

    private int idiomaSeleccionado = 0; // �ndice del idioma

    // Diccionario con los textos en diferentes idiomas
    private Dictionary<int, string[]> textosIdioma = new Dictionary<int, string[]>
    {
        { 0, new string[] { "Iniciar sesi�n", "Nombre", "C�digo personal", "Email", "Contrase�a", "Iniciar sesi�n", "Presiona iniciar sesi�n para empezar.", "Jugar", "R�cords", "R�cords", "Cr�ditos", "Cr�ditos", "Galer�a", "Galer�a", "Ajustes", "�Seguro que quieres salir?", "Los cambios no guardados desaparecer�n", "S�", "No", "Salir" } }, // Espa�ol
        { 1, new string[] { "Iniciar sesi�n", "Nome", "C�digo persoal", "Correo electr�nico", "Contrasinal", "Iniciar sesi�n", "Preme iniciar sesi�n para comezar.", "Xogar", "R�cords", "R�cords", "Cr�ditos", "Cr�ditos", "Galer�a", "Galer�a", "Axustes", "Seguro que queres sa�r?", "Os cambios non gardados desaparecer�n", "Si", "Non", "Sa�r" } }, // Galego
        { 2, new string[] { "Log in", "Name", "Personal code", "Email", "Password", "Log in", "Press log in to start.", "Play", "Records", "Records", "Credits", "Credits", "Gallery", "Gallery", "Settings", "Are you sure you want to exit?", "Unsaved changes will disappear", "Yes", "No", "Exit" } } // Ingl�s
    };

    void Start()
    {
        // Cargar el idioma guardado (por defecto espa�ol)
        idiomaSeleccionado = PlayerPrefs.GetInt("IdiomaSeleccionado", 0);
        ActualizarIdioma();
    }

    void ActualizarIdioma()
    {
        if (textosIdioma.ContainsKey(idiomaSeleccionado))
        {
            string[] textos = textosIdioma[idiomaSeleccionado];

            iniciarSesionText.text = textos[0];
            nombreText.text = textos[1];
            codigoPersonalText.text = textos[2];
            emailText.text = textos[3];
            contrase�aText.text = textos[4];
            iniciarSesionRepetidoText.text = textos[5];
            presionaIniciarSesionText.text = textos[6];
            jugarText.text = textos[7];
            recordsText.text = textos[8];
            recordsRepetidoText.text = textos[9];
            creditosText.text = textos[10];
            creditosRepetidoText.text = textos[11];
            galeriaText.text = textos[12];
            galeriaRepetidoText.text = textos[13];
            ajustesText.text = textos[14];
            seguroSalirText.text = textos[15];
            cambiosNoGuardadosText.text = textos[16];
            siText.text = textos[17];
            noText.text = textos[18];
            salirText.text = textos[19];
        }
    }
}