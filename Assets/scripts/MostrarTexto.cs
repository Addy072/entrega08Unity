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
        textoContra.text = "Contraseña: " + PlayerPrefs.GetString("ContraseñaUsuario", "Contraseña no guardada");
        textoEmail.text = "Email: " + PlayerPrefs.GetString("EmailUsuario", "Email no guardado");
        textoCodigo.text = "Código: " + PlayerPrefs.GetString("CodigoUsuario", "Código no guardado");
        textoNickname.text = "Nickname: " + PlayerPrefs.GetString("NicknameUsuario", "Nickname no guardado");

    }
}
