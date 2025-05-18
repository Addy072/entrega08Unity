using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Login : MonoBehaviour
{
    public Button a;
    public Button b;
    public Button c;
    public Button d;
    public GameObject login;
    public Button inicio;
    public GameObject iniciofondo;
    public GameObject consejoinicio;
    public GameObject musicamenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Sacarbotones()
    {
        login.gameObject.SetActive(false);
        iniciofondo.gameObject.SetActive(false);
        inicio.gameObject.SetActive(false);
        a.gameObject.SetActive(true);
        b.gameObject.SetActive(true);
        c.gameObject.SetActive(true);
        d.gameObject.SetActive(true);
        musicamenu.gameObject.SetActive(true);

    }

    public void SacarLogin()
    {
        login.gameObject.SetActive(true);
    }

    public void Sacartip()
    {
        consejoinicio.gameObject.SetActive(false);
    }

}
