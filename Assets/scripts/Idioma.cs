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

    // Diccionarios para cada idioma
    private Dictionary<int, string[]> idiomas = new Dictionary<int, string[]>
    {
        { 0, new string[] { "Idioma", "Perfil", "Audio", "Video", "Resolución", "Brillo", "Datos Usuario", "Datos Juego", "Dificultad", "Música", "Idioma" } }, // Español
        { 1, new string[] { "Idioma", "Perfil", "Audio", "Vídeo", "Resolución", "Brillo", "Datos de Usuario", "Datos do Xogo", "Dificultade", "Música", "Idioma" } }, // Gallego
        { 2, new string[] { "Language", "Profile", "Audio", "Video", "Resolution", "Brightness", "User Data", "Game Data", "Difficulty", "Music", "Language" } } // Ingles
    };

    void Start()
    {
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

    // Métodos para cambiar de idioma
    public void Espanol() { i = 0; ActualizarIdioma(); }
    public void Galego() { i = 1; ActualizarIdioma(); }
    public void Ingles() { i = 2; ActualizarIdioma(); }

    // Método para seleccionar idioma desde un menú desplegable
    public void MenuDropDown(int index)
    {
        if (idiomas.ContainsKey(index))
        {
            i = index;
            ActualizarIdioma();
        }
    }
}
