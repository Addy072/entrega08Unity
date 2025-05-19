using UnityEngine;
using TMPro;

public class Resolucion : MonoBehaviour
{
    public TMP_Dropdown dropdownResolucion; // Referencia al Dropdown
    private Resolution[] resoluciones;

    void Start()
    {
        CargarResoluciones();
        dropdownResolucion.onValueChanged.AddListener(CambiarResolucion);
    }

    void CargarResoluciones()
    {
        resoluciones = Screen.resolutions;
        dropdownResolucion.ClearOptions();

        for (int i = 0; i < resoluciones.Length; i++)
        {
            dropdownResolucion.options.Add(new TMP_Dropdown.OptionData($"{resoluciones[i].width}x{resoluciones[i].height}"));
        }

        dropdownResolucion.value = resoluciones.Length - 1; // Selecciona la resolución más alta por defecto
        dropdownResolucion.RefreshShownValue();
    }

    void CambiarResolucion(int indice)
    {
        Debug.Log($"Cambiando a: {resoluciones[indice].width}x{resoluciones[indice].height}");
        Screen.SetResolution(resoluciones[indice].width, resoluciones[indice].height, Screen.fullScreen);
    }
}