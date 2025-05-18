using System;
using UnityEngine;
using UnityEngine.UI;

public class Estamina : MonoBehaviour
{
    public Image targetImage;
    public Sprite sprite1, sprite2, sprite3, sprite4, sprite5, sprite6, sprite7, sprite8, sprite9, sprite10, sprite11;
    public Slider slider;
    public float barra = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.onValueChanged.AddListener(UpdateSprite);
        barra = PlayerPrefs.GetFloat("valorbarraestamina", 0f);

        slider.value = barra;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("valorbarraestamina", barra);
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
    }
 }
