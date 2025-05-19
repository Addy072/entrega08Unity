using UnityEngine;
using UnityEngine.UI;

public class BrilloEscena : MonoBehaviour
{
    public Image panelNegro; // Referencia al Panel
    public Slider sliderBrillo; // Referencia al Slider

    void Start()
    {
        sliderBrillo.onValueChanged.AddListener(CambiarBrillo);
        sliderBrillo.value = 0; // Empieza con máxima luminosidad (sin oscurecer)
    }

    void CambiarBrillo(float valor)
    {
        Color colorPanel = panelNegro.color;
        colorPanel.a = valor; // Modifica solo la transparencia (alpha)
        panelNegro.color = colorPanel;
    }

}
