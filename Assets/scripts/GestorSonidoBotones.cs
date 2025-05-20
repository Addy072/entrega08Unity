using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSound;
    public Button button1, button2, button3, button4, button5, button6;

    void Start()
    {
        button1.onClick.AddListener(PlaySound);
        button2.onClick.AddListener(PlaySound);
        button3.onClick.AddListener(PlaySound);
        button4.onClick.AddListener(PlaySound);
        button5.onClick.AddListener(PlaySound);
        button6.onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        audioSource.PlayOneShot(clickSound);
    }
}

