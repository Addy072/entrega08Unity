using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Gestormenuprincipal : MonoBehaviour
{
    public TMP_InputField Nombre;
    public TMP_InputField Codigo;
    public TMP_InputField Email;
    public TMP_InputField Contra;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Nombre != null && Nombre.isFocused)
            return;
        if (Codigo != null && Codigo.isFocused)
            return;
        if (Email != null && Email.isFocused)
            return;
        if (Contra != null && Contra.isFocused)
            return;

        if (Input.GetKeyDown(KeyCode.C))
        {
            Ajustes();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            menu();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
    }

    public void menu()
    {
        SceneManager.LoadScene("menuprincipal"); //Asegurate de crear esta escena antes
    }

    public void Juego()
    {
        SceneManager.LoadScene("Juego"); //Asegurate de crear esta escena antes
    }
    public void Ajustes()
    {
        Debug.Log("Abriendo menú de datos...");
        SceneManager.LoadScene("Config");
    }
    public void Exit()
    {
        Debug.Log("Saliendo del juego... :<");
        Application.Quit();
    }
}