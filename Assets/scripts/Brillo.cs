using UnityEngine;
using UnityEngine.UI;

public class BrilloEscena : MonoBehaviour
{
    public Image panelNegro; // Referencia al Panel
    public Slider sliderBrillo; // Referencia al Slider

    void Start()
    {
        // Cargar el valor guardado y aplicarlo
        float brilloGuardado = PlayerPrefs.GetFloat("BrilloPanel", 0f); // Valor por defecto: sin oscurecer
        sliderBrillo.value = brilloGuardado;
        AplicarBrillo(brilloGuardado);

        // Agregar Listener para actualizar y guardar el brillo cuando cambie
        sliderBrillo.onValueChanged.AddListener(GuardarYAplicarBrillo);
    }

    void GuardarYAplicarBrillo(float valor)
    {
        PlayerPrefs.SetFloat("BrilloPanel", valor);
        PlayerPrefs.Save();
        AplicarBrillo(valor);
    }

    void AplicarBrillo(float valor)
    {
        Color colorPanel = panelNegro.color;
        colorPanel.a = valor; // Modifica solo la transparencia (alpha)
        panelNegro.color = colorPanel;
    }
}

