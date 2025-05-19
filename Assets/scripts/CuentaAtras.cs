using System.Collections;
using UnityEngine;
using UnityEngine.UI; // Necesario para manejar UI

public class CuentaAtrasReloj : MonoBehaviour
{
    public Transform pivoteSegundero;
    public Transform pivoteMinutero;
    public Button botonInicio; // Referencia al botón en la UI
    public float tiempoInicial = 60f; // Tiempo en segundos

    private float tiempoRestante;
    private bool enCuentaRegresiva = false;

    void Start()
    {
        tiempoRestante = tiempoInicial;
        botonInicio.onClick.AddListener(IniciarCuentaAtras); // Asigna el método al botón
    }

    void Update()
    {
        if (enCuentaRegresiva && tiempoRestante > 0)
        {
            float segundosPasados = tiempoInicial - tiempoRestante;
            pivoteSegundero.rotation = Quaternion.Euler(0, 0, -segundosPasados * 6);
            pivoteMinutero.rotation = Quaternion.Euler(0, 0, -segundosPasados / 60 * 6);
        }
    }

    public void IniciarCuentaAtras()
    {
        if (!enCuentaRegresiva)
        {
            enCuentaRegresiva = true;
            StartCoroutine(ContadorRegresivo());
        }
    }

    IEnumerator ContadorRegresivo()
    {
        while (tiempoRestante > 0)
        {
            yield return new WaitForSeconds(1f);
            tiempoRestante--;
        }

        Debug.Log("¡Tiempo agotado!");
        enCuentaRegresiva = false;
    }
}
