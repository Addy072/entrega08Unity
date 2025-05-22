using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


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
    public float barra = 0;

    private Color originalColor;
    public TMP_Text misionmuertetexto;
    public GameObject misionmuerte;
    public Animator tablet;
    public AudioSource audioSource;
    public AudioClip misioncompletada;

    void Start()
    {
        slider.onValueChanged.AddListener(UpdateSprite);

        vidas = PlayerPrefs.GetInt("numerovidas", 5);
        barra = PlayerPrefs.GetFloat("valorbarravida", 0f);

        slider.value = barra; // recuperamos valor de la barrita de vidas
        vidastotales();
 
    }

    void Update()
    {
        PlayerPrefs.SetInt("numerovidas", vidas);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("valorbarravida", barra);
        PlayerPrefs.Save();

    }

    void UpdateSprite(float value)
    {

        if (value < 0.1f)
        {
            targetImage.sprite = sprite1;
            barra = value;
        }
        else if (value < 0.2f)
        {
            targetImage.sprite = sprite2;
            barra = value;
        }
        else if (value < 0.3f)
        {
            targetImage.sprite = sprite3;
            barra = value;
        }
        else if (value < 0.4f)
        {
            targetImage.sprite = sprite4;
            barra = value;
        }
        else if (value < 0.5f)
        {
            targetImage.sprite = sprite5;
            barra = value;
        }
        else if (value < 0.6f)
        {
            targetImage.sprite = sprite6;
            barra = value;
        }
        else if (value < 0.7f)
        {
            targetImage.sprite = sprite7;
            barra = value;
        }
        else if (value < 0.8f)
        {
            targetImage.sprite = sprite8;
            barra = value;
        }
        else if (value < 0.9f)
        {
            targetImage.sprite = sprite9;
            barra = value;
        }
        else if (value < 1f)
        {
            targetImage.sprite = sprite10;
            barra = value;
        }
        else
        {
            targetImage.sprite = sprite11;
            barra = value;
        }

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
                vida5.gameObject.SetActive(false);
                vida4.gameObject.SetActive(false);
                break;
            case 2:
                vida5.gameObject.SetActive(false);
                vida4.gameObject.SetActive(false);
                vida3.gameObject.SetActive(false);
                break;
            case 1:
                vida5.gameObject.SetActive(false);
                vida4.gameObject.SetActive(false);
                vida3.gameObject.SetActive(false);
                vida2.gameObject.SetActive(false); 
                break;
            case 0:
                vida5.gameObject.SetActive(false);
                vida4.gameObject.SetActive(false);
                vida3.gameObject.SetActive(false);
                vida2.gameObject.SetActive(false);
                vida1.gameObject.SetActive(false);
                muerte.gameObject.SetActive(true);

                if (PlayerPrefs.GetInt(logroMuerteKey, 0) == 1) return; 

                PlayerPrefs.SetInt(logroMuerteKey, 1); // Guardar logro
                PlayerPrefs.Save();

                Logromuerte.Play("Logro");
                misionmuertea();

                StartCoroutine(EsperadeLogro1());
                
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
    IEnumerator Esperademision()
    {
        yield return new WaitForSeconds(5); // Espera 3 segundos antes de continuar
        misionmuerte.gameObject.SetActive(false);
        misionmuertetexto.color = originalColor;
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

    void misionmuertea()
    {
        tablet.Play("tableta"); //Abre la tablet
        audioSource.PlayOneShot(misioncompletada); //sonido del logro
        misionmuertetexto.color = Color.green;
        StartCoroutine(Esperademision());

    }

    public void borrar()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("td borrao");
    }
}