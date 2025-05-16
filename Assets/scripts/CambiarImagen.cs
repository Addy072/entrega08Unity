using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

public class cambios : MonoBehaviour
{
    public Image imagenUI;
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Button anterior;
    public Button siguiente;
    
    public int Orden = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Eleccion()
    {
        switch (Orden)
        {
            case 1:
                imagenUI.sprite = image1;
                anterior.gameObject.SetActive(false);
                break;
            case 2:
                imagenUI.sprite = image2;
                anterior.gameObject.SetActive(true);
                break;
            case 3:
                imagenUI.sprite = image3;
                siguiente.gameObject.SetActive(true);
                break;
            case 4:
                imagenUI.sprite = image4;
                siguiente.gameObject.SetActive(false);
                break;
        }
    }

    public void ImagenSiguiente()
    {
        Orden++;
        Eleccion();
    }

    public void ImagenAnterior()
    {
        Orden--;
        Eleccion();
    }
}
