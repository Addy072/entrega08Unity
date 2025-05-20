using UnityEngine;
using TMPro;

public class AplicarResolucionyDificultad : MonoBehaviour
{
    public TMP_Text textoDificultad;
    void Start()
    {
        // Recuperar la resolución guardada
        string resolucionGuardada = PlayerPrefs.GetString("ResolucionUsuario", "1920x1080"); // Valor por defecto

        string dificultadGuardada = PlayerPrefs.GetString("DificultadUsuario", "Normal"); // Valor por defecto

        // Asignar el valor al texto
        textoDificultad.text = "Dificultad: " + dificultadGuardada;
        // Aplicar la resolución
        CambiarResolucion(resolucionGuardada);
        
    }

    void CambiarResolucion(string resolucion)
    {
        string[] valores = resolucion.Split('x');
        if (valores.Length == 2)
        {
            int ancho = int.Parse(valores[0]);
            int alto = int.Parse(valores[1]);
            Screen.SetResolution(ancho, alto, FullScreenMode.Windowed);
            Debug.Log($"Resolución aplicada: {ancho}x{alto}");
        }
        else
        {
            Debug.LogError("Formato de resolución incorrecto.");
        }
    }

    
}
