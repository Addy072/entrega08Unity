using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuardarInput : MonoBehaviour
{
    public TMP_InputField inputNombre;
    public TMP_InputField inputContra;
    public TMP_InputField Codigo;
    public TMP_InputField Email;

    void Start()
    {
        // Agregar Listeners para guardar los datos cuando el usuario termine de escribir
        inputNombre.onEndEdit.AddListener(GuardarNombre);
        inputContra.onEndEdit.AddListener(GuardarContra);
        Codigo.onEndEdit.AddListener(GuardarCodigo);
        Email.onEndEdit.AddListener(GuardarEmail);
    }

    void GuardarNombre(string texto)
    {
        PlayerPrefs.SetString("NombreUsuario", texto);
        PlayerPrefs.Save();
        Debug.Log("Nombre guardado: " + texto);
    }

    void GuardarContra(string texto)
    {
        PlayerPrefs.SetString("ContraseñaUsuario", texto);
        PlayerPrefs.Save();
        Debug.Log("Contraseña guardada: " + texto);
    }
    void GuardarCodigo(string texto)
    {
        PlayerPrefs.SetString("CodigoUsuario", texto);
        PlayerPrefs.Save();
        Debug.Log("Codigo guardado: " + texto);
    }
    void GuardarEmail(string texto)
    {
        PlayerPrefs.SetString("EmailUsuario", texto);
        PlayerPrefs.Save();
        Debug.Log("Email guardado: " + texto);
    }
}
