using UnityEngine;

public class GestorObjetos : MonoBehaviour
{
    public Inventario inventario;
    public DineroEngranajes dineroEngranajes;
    public Sprite imagenFlor;

    public void EjecutarAccion() // Este método se llamará desde otro script
    {
        if (inventario != null && imagenFlor != null)
        {
            for (int i = 0; i < 3; i++) // Agregar 3 flores
            {
                inventario.AgregarObjeto(0, imagenFlor);
            }
        }
        else
        {
            Debug.LogError("Inventario o imagenFlor no están asignados.");
        }

        if (dineroEngranajes != null)
        {
            dineroEngranajes.dinero += 300;
            dineroEngranajes.ActualizarTexto();
            dineroEngranajes.GuardarProgreso();
        }
        else
        {
            Debug.LogError("Referencia a DineroEngranajes no asignada.");
        }
    }
}
