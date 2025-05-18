using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuardarPersonaje : MonoBehaviour
{
    public TMP_InputField inputNombre;
    public Button verde, amarillo, naranja, rojo, rosa, violeta, azuloscuro, turquesa;
    public int color = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputNombre.onEndEdit.AddListener(GuardarNombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GuardarNombre(string texto)
    {
        PlayerPrefs.SetString("Nickname", texto);
        PlayerPrefs.Save();
        Debug.Log("Nickname: " + texto);
    }
    void colorfav()
    {
        PlayerPrefs.SetInt("colorfav", color);
        PlayerPrefs.Save();
    }
    public void Colorverde()
    {
        color = 1;
        colorfav();
    }
    public void Coloramarillo()
    {
        color = 2;
        colorfav();
    }
    public void Colornaranja()
    {
        color = 3;
        colorfav();
    }
    public void Colorojo()
    {
        color = 4;
        colorfav();
    }
    public void Colorosa()
    {
        color = 5;
        colorfav();
    }
    public void Colorvioleta()
    {
        color = 6;
        colorfav();
    }
    public void Colorazul()
    {
        color = 7;
        colorfav();
    }
    public void Colorturquesa()
    {
        color = 8;
        colorfav();
    }
}
