using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        // Cargar el volumen guardado
        volumeSlider.value = PlayerPrefs.GetFloat("GameVolume", 1f);
        AudioListener.volume = volumeSlider.value;

        // Listener para actualizar el volumen
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    void ChangeVolume(float value)
    {
        AudioListener.volume = value;
        PlayerPrefs.SetFloat("GameVolume", value);
        PlayerPrefs.Save(); // Guarda los cambios
    }
}
