using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GuardarInput : MonoBehaviour
{
    public TMP_InputField inputNombre;
    public TMP_InputField inputContra;
    public TMP_InputField Codigo;
    public TMP_InputField Email;
    public TMP_InputField Nickname;
    public TMP_Dropdown dropdownResolucion;
    public TMP_Dropdown dropdownDificultad;




    void Start()
    {
        // Agregar Listeners para guardar los datos cuando el usuario termine de escribir
        inputNombre.onEndEdit.AddListener(GuardarNombre);
        inputContra.onEndEdit.AddListener(GuardarContra);
        Codigo.onEndEdit.AddListener(GuardarCodigo);
        Email.onEndEdit.AddListener(GuardarEmail);
        Nickname.onEndEdit.AddListener(GuardarNickname);
        dropdownResolucion.onValueChanged.AddListener(GuardarResolucion);
        dropdownDificultad.onValueChanged.AddListener(GuardarDificultad);
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

    void GuardarNickname(string texto)
    {
        PlayerPrefs.SetString("NicknameUsuario", texto);
        PlayerPrefs.Save();
        Debug.Log("Nickname guardado: " + texto);
    }
    void GuardarResolucion(int index)
    {
        string resolucionSeleccionada = dropdownResolucion.options[index].text;
        PlayerPrefs.SetString("ResolucionUsuario", resolucionSeleccionada);
        PlayerPrefs.Save();
        Debug.Log("Resolución guardada: " + resolucionSeleccionada);
    }
    void GuardarDificultad(int index)
    {
        string DificultadSeleccionada = dropdownDificultad.options[index].text;
        PlayerPrefs.SetString("DificultadUsuario", DificultadSeleccionada);
        PlayerPrefs.Save();
        Debug.Log("Dificultad guardada: " + DificultadSeleccionada);
    }
}
