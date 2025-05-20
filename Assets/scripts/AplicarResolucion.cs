using UnityEngine;
using TMPro;

public class AplicarResolucionyDificultad : MonoBehaviour
{
    public TMP_Text textoDificultad;
    void Start()
    {
        // Recuperar la resoluci�n guardada
        string resolucionGuardada = PlayerPrefs.GetString("ResolucionUsuario", "1920x1080"); // Valor por defecto

        string dificultadGuardada = PlayerPrefs.GetString("DificultadUsuario", "Normal"); // Valor por defecto

        // Asignar el valor al texto
        textoDificultad.text = "Dificultad: " + dificultadGuardada;
        // Aplicar la resoluci�n
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
            Debug.Log($"Resoluci�n aplicada: {ancho}x{alto}");
        }
        else
        {
            Debug.LogError("Formato de resoluci�n incorrecto.");
        }
    }

    
}
