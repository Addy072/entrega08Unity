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

    private int i = 0; // Índice de idioma

    // Diccionario con los textos de cada idioma
    private Dictionary<int, string[]> idiomas = new Dictionary<int, string[]>
    {
        { 0, new string[] { "Idioma", "Perfil", "Audio", "Video", "Resolución", "Brillo", "Datos Usuario", "Datos Juego", "Dificultad", "Música", "Idioma" } }, // Español
        { 1, new string[] { "Idioma", "Perfil", "Audio", "Vídeo", "Resolución", "Brillo", "Datos de Usuario", "Datos do Xogo", "Dificultade", "Música", "Idioma" } }, // Galego
        { 2, new string[] { "Language", "Profile", "Audio", "Video", "Resolution", "Brightness", "User Data", "Game Data", "Difficulty", "Music", "Language" } } // Inglés
    };

    void Start()
    {
        // Cargar el idioma guardado o establecer español por defecto
        i = PlayerPrefs.GetInt("IdiomaSeleccionado", 0);
        ActualizarIdioma();
    }

    // Método para actualizar los textos según el idioma seleccionado
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

    // Métodos para cambiar de idioma y guardarlo en `PlayerPrefs`
    public void Espanol() { GuardarIdioma(0); }
    public void Galego() { GuardarIdioma(1); }
    public void Ingles() { GuardarIdioma(2); }

    // Método para seleccionar idioma desde un menú desplegable y guardarlo
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
