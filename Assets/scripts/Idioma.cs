using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IdiomasConfig : MonoBehaviour
{
    // Referencias a los textos de la UI
    public TextMeshProUGUI idiomaText;
    public TextMeshProUGUI perfilText;
    public TextMeshProUGUI audioText;
    public TextMeshProUGUI videoText;
    public TextMeshProUGUI resolucionText;
    public TextMeshProUGUI brilloText;
    public TextMeshProUGUI datosUsuarioText;
    public TextMeshProUGUI datosJuegoText;
    public TextMeshProUGUI dificultadText;
    public TextMeshProUGUI musicaText;
    public TextMeshProUGUI Idioma;

    private int i = 0; // �ndice de idioma

    // Diccionario con los textos de cada idioma
    private Dictionary<int, string[]> idiomas = new Dictionary<int, string[]>
    {
        { 0, new string[] { "Idioma", "Perfil", "Audio", "Video", "Resoluci�n", "Brillo", "Datos Usuario", "Datos Juego", "Dificultad", "M�sica", "Idioma" } }, // Espa�ol
        { 1, new string[] { "Idioma", "Perfil", "Audio", "V�deo", "Resoluci�n", "Brillo", "Datos de Usuario", "Datos do Xogo", "Dificultade", "M�sica", "Idioma" } }, // Galego
        { 2, new string[] { "Language", "Profile", "Audio", "Video", "Resolution", "Brightness", "User Data", "Game Data", "Difficulty", "Music", "Language" } } // Ingl�s
    };

    void Start()
    {
        // Cargar el idioma guardado o establecer espa�ol por defecto
        i = PlayerPrefs.GetInt("IdiomaSeleccionado", 0);
        ActualizarIdioma();
    }

    // M�todo para actualizar los textos seg�n el idioma seleccionado
    private void ActualizarIdioma()
    {
        idiomaText.text = idiomas[i][0];
        perfilText.text = idiomas[i][1];
        audioText.text = idiomas[i][2];
        videoText.text = idiomas[i][3];
        resolucionText.text = idiomas[i][4];
        brilloText.text = idiomas[i][5];
        datosUsuarioText.text = idiomas[i][6];
        datosJuegoText.text = idiomas[i][7];
        dificultadText.text = idiomas[i][8];
        musicaText.text = idiomas[i][9];
        Idioma.text = idiomas[i][10];
    }

    // M�todos para cambiar de idioma y guardarlo en `PlayerPrefs`
    public void Espanol() { GuardarIdioma(0); }
    public void Galego() { GuardarIdioma(1); }
    public void Ingles() { GuardarIdioma(2); }

    // M�todo para seleccionar idioma desde un men� desplegable y guardarlo
    public void MenuDropDown(int index)
    {
        if (idiomas.ContainsKey(index))
        {
            GuardarIdioma(index);
        }
    }

    // Guarda el idioma en `PlayerPrefs`
    private void GuardarIdioma(int nuevoIdioma)
    {
        i = nuevoIdioma;
        PlayerPrefs.SetInt("IdiomaSeleccionado", i);
        PlayerPrefs.Save(); // Guarda los cambios permanentemente
        ActualizarIdioma();
    }
}
