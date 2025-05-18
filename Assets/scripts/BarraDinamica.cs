using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class SpriteChanger : MonoBehaviour
{
    public Image targetImage;
    public Sprite sprite1, sprite2, sprite3, sprite4, sprite5, sprite6, sprite7, sprite8, sprite9, sprite10, sprite11;
    public Slider slider;
    public int vidas = 5;
    public GameObject vida5, vida4, vida3, vida2, vida1, muerte;
    private const string logroMuerteKey = "logromuerte1";
    public Animator Logromuerte;
    public GameObject Gameoverpanel;

    void Start()
    {
        slider.onValueChanged.AddListener(UpdateSprite);
        PlayerPrefs.SetInt("numerovidas", 5);
    }

    void Update()
    {
        PlayerPrefs.SetInt("numerovidas", vidas);
        PlayerPrefs.Save();
    }

    void UpdateSprite(float value)
    {
        if (value < 0.1f) targetImage.sprite = sprite1;
        else if (value < 0.2f) targetImage.sprite = sprite2;
        else if (value < 0.3f) targetImage.sprite = sprite3;
        else if (value < 0.4f) targetImage.sprite = sprite4;
        else if (value < 0.5f) targetImage.sprite = sprite5;
        else if (value < 0.6f) targetImage.sprite = sprite6;
        else if (value < 0.7f) targetImage.sprite = sprite7;
        else if (value < 0.8f) targetImage.sprite = sprite8;
        else if (value < 0.9f) targetImage.sprite = sprite9;
        else if (value < 1f) targetImage.sprite = sprite10;
        else targetImage.sprite = sprite11;

        if (value == 1f)
        {
            vidas--;
            vidastotales();
        }

        

    }
    void vidastotales()
    {
        switch (vidas) {
            case 4:
                vida5.gameObject.SetActive(false);
                break;
            case 3:
                vida4.gameObject.SetActive(false);
                break;
            case 2:
                vida3.gameObject.SetActive(false);
                break;
            case 1:
                vida2.gameObject.SetActive(false); 
                break;
            case 0:
                vida1.gameObject.SetActive(false);
                muerte.gameObject.SetActive(true);

                if (PlayerPrefs.GetInt(logroMuerteKey, 0) == 1) return; 

                PlayerPrefs.SetInt(logroMuerteKey, 1); // Guardar que el logro ha sucedido
                PlayerPrefs.Save();

                Logromuerte.Play("Logro");

                StartCoroutine(EsperadeLogro1());
                // Aquí puedes ejecutar la animación del logro
                Debug.Log("¡Logro desbloqueado: Has perdido todas las vidas por primera vez!");
                break;
        }

    }
    IEnumerator EsperadeLogro1()
    {
        yield return new WaitForSeconds(8); // Espera 8 segundos antes de continuar

        Debug.Log("¡Logro desbloqueado: Has perdido todas las vidas por primera vez!");
        Logromuerte.Play("LogroOut");
    }
    public void ReponerBateria()
    {
        Gameoverpanel.gameObject.SetActive(false);
        vidas = 5;
        PlayerPrefs.GetInt("numerovidas", vidas);
        ResetLives();
        ResetLiveBar();

    }
    void ResetLives()
    {
        vida5.gameObject.SetActive(true);
        vida4.gameObject.SetActive(true);
        vida3.gameObject .SetActive(true);
        vida2.gameObject .SetActive(true);
        vida1.gameObject .SetActive(true);
    }

    void ResetLiveBar()
    {
        slider.value = 0;
    }
}

