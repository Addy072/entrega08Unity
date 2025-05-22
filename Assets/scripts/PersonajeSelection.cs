
using UnityEngine;
using UnityEngine.UI;

public class Seleccionropa : MonoBehaviour
{
    public Image cara1, cara2, cara3, cara4;
    public Image pecho1, pecho2, pecho3, pecho4;
    public Image pierna1, pierna2;

    public Button caraizq, carader, pechoizq, pechoder, piernaizq, piernader;
    

    public int Seleccioncara = 0;
    public int Seleccionpecho = 0;
    public int Seleccionpierna = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ropaponercara()
    {
        switch (Seleccioncara)
        {
            case 0:
                cara1.gameObject.SetActive(false);
                caraizq.gameObject.SetActive(false);
                break;
            case 1:
                cara1.gameObject.SetActive(true);
                cara2.gameObject.SetActive(false);
                caraizq.gameObject.SetActive(true);
                break;
            case 2:
                cara2.gameObject.SetActive(true);
                cara3.gameObject.SetActive(false);
                cara1.gameObject.SetActive(false);
                
                break;
            case 3:
                cara3.gameObject.SetActive(true);
                cara2.gameObject.SetActive(false);
                cara4.gameObject.SetActive(false);
                carader.gameObject.SetActive(true);
                break;
            case 4:
                cara4.gameObject.SetActive(true);
                cara3.gameObject.SetActive(false);
                carader.gameObject.SetActive(false);
                break;
        }
    }

    public void RopaSiguientecara()
    {
        Seleccioncara++;
        ropaponercara();
    }

    public void RopaAnteriorcara()
    {
        Seleccioncara--;
        ropaponercara();
    }

    public void ropaponerpecho()
    {
        switch (Seleccionpecho)
        {
            case 0:
                pecho1.gameObject.SetActive(false);
                pechoizq.gameObject.SetActive(false);
                break;
            case 1:
                pecho1.gameObject.SetActive(true);
                pecho2.gameObject.SetActive(false);
                pechoizq.gameObject.SetActive(true);
                break;
            case 2:
                pecho2.gameObject.SetActive(true);
                pecho1.gameObject.SetActive(false);
                pecho3.gameObject.SetActive(false);
                break;
            case 3:
                pecho3.gameObject.SetActive(true);
                pecho2.gameObject.SetActive(false);
                pecho4.gameObject.SetActive(false);
                pechoder.gameObject.SetActive(true);
                break;
            case 4:
                pecho4.gameObject.SetActive(true);
                pecho3.gameObject.SetActive(false);
                pechoder.gameObject.SetActive(false);
                break;
        }
    }
    public void RopaSiguientepecho()
    {
        Seleccionpecho++;
        ropaponerpecho();
    }

    public void RopaAnteriorpecho()
    {
        Seleccionpecho--;
        ropaponerpecho();
    }
    public void ropaponerpierna()
    {
        switch (Seleccionpierna)
        {
            case 0:
                pierna1.gameObject.SetActive(false);
                piernaizq.gameObject.SetActive(false);
                break;
            case 1:
                pierna1.gameObject.SetActive(true);
                pierna2.gameObject.SetActive(false);
                piernaizq.gameObject.SetActive(true);
                piernader.gameObject.SetActive(true);
                break;
            case 2:
                pierna2.gameObject.SetActive(true);
                pierna1.gameObject.SetActive(false);
                piernader.gameObject.SetActive(false);
                break;
        }
    }
    public void RopaSiguientepierna()
    {
        Seleccionpierna++;
        ropaponerpierna();
    }

    public void RopaAnteriorpierna()
    {
        Seleccionpierna--;
        ropaponerpierna();
    }

    public void guardarropa()
    {
        PlayerPrefs.SetInt("cara", Seleccioncara);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("pecho", Seleccionpecho);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("pierna", Seleccionpierna);
        PlayerPrefs.Save();
    }
}