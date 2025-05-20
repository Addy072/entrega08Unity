using UnityEngine;
using UnityEngine.UI;

public class BrilloEscena : MonoBehaviour
{
    public Image panelNegro; // Referencia al Panel
    public Slider sliderBrillo; // Referencia al Slider (si existe en la escena)

    void Start()
    {
        // Cargar el valor guardado y aplicarlo
        float brilloGuardado = PlayerPrefs.GetFloat("BrilloPanel", 0f); // Valor por defecto: sin oscurecer
        AplicarBrillo(brilloGuardado);

        // Si hay un Slider en la escena, asignar el valor y agregar Listener
        if (sliderBrillo != null)
        {
            sliderBrillo.value = brilloGuardado;
            sliderBrillo.onValueChanged.AddListener(GuardarYAplicarBrillo);
        }
    }

    void GuardarYAplicarBrillo(float valor)
    {
        PlayerPrefs.SetFloat("BrilloPanel", valor);
        PlayerPrefs.Save();
        AplicarBrillo(valor);
    }

    void AplicarBrillo(float valor)
    {
        if (panelNegro != null) // Asegurarse de que el panel exista
        {
            Color colorPanel = panelNegro.color;
            colorPanel.a = valor; // Modifica solo la transparencia (alpha)
            panelNegro.color = colorPanel;
        }
    }
}