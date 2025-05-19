using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Importa la librería de TextMeshPro

public class CuentaAtrasReloj : MonoBehaviour
{
    public Transform pivoteSegundero;
    public Transform pivoteMinutero;
    public Button botonInicio;
    public TextMeshProUGUI textoTiempo;
    public float tiempoInicial = 60f;
    public GameObject eventoCuentaRegresiva;

    private float tiempoRestante;
    private bool enCuentaRegresiva = false;
    private Coroutine cuentaRegresivaCoroutine;

    void Start()
    {
        tiempoRestante = tiempoInicial;
        botonInicio.onClick.AddListener(IniciarCuentaAtras);
        ActualizarTexto();
        eventoCuentaRegresiva.SetActive(false);
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
        textoTiempo.gameObject.SetActive(true);
        if (cuentaRegresivaCoroutine != null)
        {
            StopCoroutine(cuentaRegresivaCoroutine); // Detiene la cuenta atrás anterior
        }

        // Reiniciar valores
        tiempoRestante = tiempoInicial;
        enCuentaRegresiva = true;
        ActualizarTexto();
        eventoCuentaRegresiva.SetActive(false);

        cuentaRegresivaCoroutine = StartCoroutine(ContadorRegresivo());
    }

    IEnumerator ContadorRegresivo()
    {
        while (tiempoRestante > 0)
        {
            yield return new WaitForSeconds(1f);
            tiempoRestante--;
            ActualizarTexto();
        }

        Debug.Log("¡Tiempo agotado!");
        enCuentaRegresiva = false;
        textoTiempo.text = "ERROR";
        eventoCuentaRegresiva.SetActive(true);
        textoTiempo.gameObject.SetActive(false);
    }

    void ActualizarTexto()
    {
        textoTiempo.text = tiempoRestante.ToString("00");
    }
}
