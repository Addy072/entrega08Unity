using TMPro;
using UnityEngine;

public class GestorTableta : MonoBehaviour
{
    public GameObject inventario;
    public GameObject misiones;
    public GameObject records;
    public int dinero;
    public int engranajes;
    public TMP_Text textoDinero;
    public TMP_Text textoEngranajes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mostrarRecord();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void mostrarRecord()
    {
        dinero = PlayerPrefs.GetInt("dinero", 0);
        engranajes = PlayerPrefs.GetInt("engranajes", 0);
        textoDinero.text = dinero.ToString();
        textoEngranajes.text = engranajes.ToString();
    }

    public void inventariosubmenu()
    {
        inventario.gameObject.SetActive(true);
        misiones.gameObject.SetActive(false);
        records.gameObject.SetActive(false);
    }

    public void misionessubmenu()
    {
        misiones.gameObject.SetActive(true);
        inventario.gameObject.SetActive(false);
        records.gameObject.SetActive(false);
    }
    public void recocordssubmenu()
    {
        mostrarRecord();
        records.gameObject.SetActive(true);
        inventario.gameObject.SetActive(false);
        misiones.gameObject.SetActive(false);
    }


}
