using UnityEngine;

public class ConfigSubmenu : MonoBehaviour
{
    public int ActualConf = 0;
    public int ConfAnterior = 0;
    public Animator Perfil;
    public Animator Audio;
    public Animator Idioma;
    public Animator Video;

    public GameObject Maudio;
    public GameObject Mvideo;
    public GameObject Midioma;



    public void Comoesta()
    {
        if (ConfAnterior > 0)
        {
            Fuera();
            ConfAnterior = ActualConf;
            Dentro();

        }
        else
        {
            Dentro();
            ConfAnterior = ActualConf;
        }


    }


    public void Dentro()
    {
        switch (ActualConf)
        {
            case 1:
                Perfil.Play("Perfil");
                break;
            case 2:
                Audio.Play("Audio");
                Maudio.gameObject.SetActive(true);
                break;
            case 3:
                Video.Play("Video");
                Mvideo.gameObject.SetActive(true);
                break;
            case 4:
                Idioma.Play("Idioma");
                Midioma.gameObject.SetActive(true);
                break;

        }

    }

    public void Fuera()
    {
        switch (ConfAnterior)
        {
            case 1:
                Perfil.Play("PefilOut");
                break;
            case 2:
                Audio.Play("AudioOut");
                Maudio.gameObject.SetActive(false);
                break;
            case 3:
                Video.Play("VideoOut");
                Mvideo.gameObject.SetActive(false);
                break;
            case 4:
                Idioma.Play("IdiomaOut");
                Midioma.gameObject.SetActive(false);
                break;
        }

    }


    public void AniPerfil()
    {
        ActualConf = 1;
        Comoesta();

    }
    public void AniAudio()
    {
        ActualConf = 2;
        Comoesta();

    }

    public void AniVideo()
    {
        ActualConf = 3;
        Comoesta();
    }

    public void AniIdioma()
    {
        ActualConf = 4;
        Comoesta();
    }



}