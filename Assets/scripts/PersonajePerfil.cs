using UnityEngine;
using UnityEngine.UI;

public class PersonajePerfil : MonoBehaviour
{
    public int cara, pecho, pierna;

    public Image cara1, cara2, cara3, cara4;
    public Image pecho1, pecho2, pecho3, pecho4;
    public Image pierna1, pierna2;

    
    void Start()
    {
        pecho = PlayerPrefs.GetInt("pecho", 0);
        pierna = PlayerPrefs.GetInt("pierna", 0);
        cara = PlayerPrefs.GetInt("cara", 0);
        RopaPerfil();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RopaPerfil()
    {
        switch (pecho)
        {
            case 0:
                break;
            case 1:
                pecho1.gameObject.SetActive(true);
                break;
            case 2:
                pecho2.gameObject.SetActive(true);
                break;
            case 3:
                pecho3.gameObject.SetActive(true);
                break;
            case 4:
                pecho4.gameObject.SetActive(true);
                break;
        }

        switch (cara)
        {
            case 0:
                break;
            case 1:
                cara1.gameObject.SetActive(true);
                break;
            case 2:
                cara2.gameObject.SetActive(true);
                break;
            case 3:
                cara3.gameObject.SetActive(true);
                break;
            case 4:
                cara4.gameObject.SetActive(true);
                break;
        }

        switch (pierna)
        {
            case 0:
                break;
            case 1:
                pierna1.gameObject.SetActive(true);
                break;
            case 2:
                pierna2.gameObject.SetActive(true);
                break;
        }
    }
}
