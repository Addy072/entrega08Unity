using System.Collections;
using TMPro;

using UnityEngine;

public class Consejos : MonoBehaviour
{
    public TMP_Text mensajes;
    public int cuenta = 0;
    public Animator consejo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        borrar();
        StartCoroutine(Esperaentreconsejos());
        cuenta = PlayerPrefs.GetInt("cuentaconsejos");
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void consejoinicial()
    {
        consejo.Play("consejos");
        mensajes.text = "Recuerda acceder a la tablet para ver tu inventario, misiones y más.";
        cuenta++;
        StartCoroutine(Espera());
        guardarcuenta();
    }

    void consejobotonesinventario()
    {
        consejo.Play("consejos");
        mensajes.text = "En la tableta:\n" +
            "El botón izquierdo son las misiones y encargos que tienes\n" +
            "En el centro tienes los avisos y fragmentos de misión\n" +
            "En el botón derecho tienes tu inventario";
        cuenta++;
        StartCoroutine(Espera());
        guardarcuenta();
    }

    void consejoajustes()
    {
        consejo.Play("consejos");
        mensajes.text = "Usa el engranaje sobre el reloj para ir a ajustes, al menú o salir del juego";
        cuenta++;
        StartCoroutine(Espera());
        guardarcuenta();
    }

    void atajos()
    {
        consejo.Play("consejos");
        mensajes.text = "Pulsa la M para ir al menú rápidamente\n" +
            "También puedes pulsar ESC para ir a ajustes";
        cuenta++;
        StartCoroutine(Espera());
        guardarcuenta();
    }

    IEnumerator Esperaentreconsejos()
    {
        yield return new WaitForSeconds(8); // Espera 8 segundos antes de continuar
        switch (cuenta)
        {
            case 0: consejoinicial();
                break;
            case 1: consejobotonesinventario();
                break;
            case 2:
                consejoajustes();
                break;
            case 3:
                atajos();
                
                break;
        }
            
    }

    IEnumerator Espera()
    {
        yield return new WaitForSeconds(30); // Espera 8 segundos antes de continuar
        consejo.Play("consejosOut");
        StartCoroutine(Esperaentreconsejos());
    }

    void guardarcuenta()
    {
        PlayerPrefs.SetInt("cuentaconsejos", cuenta);
        PlayerPrefs.Save();
    }

    void borrar()
    {
        PlayerPrefs.DeleteKey("cuentaconsejos");
    }
}
