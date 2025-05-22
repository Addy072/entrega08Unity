using TMPro;
using UnityEngine;

public class DineroEngranajes : MonoBehaviour
{
    public TMP_Text textoDinero;
    public TMP_Text textoEngranajes;
    public int dinero = 0;
    public int engranajes = 0;

    void Start()
    {
        dinero = PlayerPrefs.GetInt("dinero", 0);
        engranajes = PlayerPrefs.GetInt("engranajes", 0);
        ActualizarTexto();
    }

    public void ActualizarTexto()
    {
        textoDinero.text = dinero.ToString();
        textoEngranajes.text = engranajes.ToString();
    }

    public void masdinero()
    {
        if (dinero < 999999)
        {
            dinero++;
            ActualizarTexto();
            GuardarProgreso();
        }
    }

    public void menosdinero()
    {
        if (dinero > 0)
        {
            dinero--;
            ActualizarTexto();
            GuardarProgreso();
        }
    }

    public void masengranajes()
    {
        if (engranajes < 999999)
        {
            engranajes++;
            ActualizarTexto();
            GuardarProgreso();
        }
    }

    public void menosengranajes()
    {
        if (engranajes > 0)
        {
            engranajes--;
            ActualizarTexto();
            GuardarProgreso();
        }
    }
    
    public void GuardarProgreso()
    {
        PlayerPrefs.SetInt("dinero", dinero);
        PlayerPrefs.SetInt("engranajes", engranajes);
        PlayerPrefs.Save();
    }

}
