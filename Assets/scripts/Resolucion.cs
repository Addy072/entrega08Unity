using TMPro;
using UnityEngine;

public class Resoluciones : MonoBehaviour
{
    public TMP_Dropdown R;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        R.onValueChanged.AddListener(GuardarResolucion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GuardarResolucion(int index)
    {
        string resolucionSeleccionada = R.options[index].text;
        PlayerPrefs.SetString("ResolucionUsuario", resolucionSeleccionada);
        PlayerPrefs.Save();
        Debug.Log("Resolución guardada: " + resolucionSeleccionada);
    }
}
