using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GuardarInput : MonoBehaviour
{
    
    public TMP_InputField Nickname;
       public TMP_Dropdown dropdownDificultad;




    void Start()
    {
        // Agregar Listeners para guardar los datos cuando el usuario termine de escribir
        
        Nickname.onEndEdit.AddListener(GuardarNickname);
        dropdownDificultad.onValueChanged.AddListener(GuardarDificultad);
    }

    

    void GuardarNickname(string texto)
    {
        PlayerPrefs.SetString("NicknameUsuario", texto);
        PlayerPrefs.Save();
        Debug.Log("Nickname guardado: " + texto);
    }
    
    void GuardarDificultad(int index)
    {
        string DificultadSeleccionada = dropdownDificultad.options[index].text;
        PlayerPrefs.SetString("DificultadUsuario", DificultadSeleccionada);
        PlayerPrefs.Save();
        Debug.Log("Dificultad guardada: " + DificultadSeleccionada);
    }
}
