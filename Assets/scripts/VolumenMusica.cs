using UnityEngine;
using UnityEngine.UI;

public class Volumenl : MonoBehaviour
{

    public float paco;
    void Start()
    {
        // Cargar el volumen guardado
        paco = PlayerPrefs.GetFloat("GameVolume", 1f);
        AudioListener.volume = paco;

        // Listener para actualizar el volumen
        
    }

    
}