using TMPro;
using UnityEngine;

public class MostrarTexto : MonoBehaviour
{
    public TMP_Text textoNombre;
    public TMP_Text textoContra;
    public TMP_Text textoCodigo;
    public TMP_Text textoEmail;
    public TMP_Text textoNickname;

    void Start()
    {
        // Recuperar los datos guardados y asignarlos correctamente
        textoNombre.text = "Nombre: " + PlayerPrefs.GetString("NombreUsuario", "Nombre no guardado");
        textoContra.text = "Contrase�a: " + PlayerPrefs.GetString("Contrase�aUsuario", "Contrase�a no guardada");
        textoEmail.text = "Email: " + PlayerPrefs.GetString("EmailUsuario", "Email no guardado");
        textoCodigo.text = "C�digo: " + PlayerPrefs.GetString("CodigoUsuario", "C�digo no guardado");
        textoNickname.text = "Nickname: " + PlayerPrefs.GetString("NicknameUsuario", "Nickname no guardado");

    }
}
