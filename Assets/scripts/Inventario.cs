using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventario : MonoBehaviour
{
    // Clase para representar cada objeto en el inventario
    public class SlotInventario
    {
        public int idObjeto;
        public int cantidad;
        public Sprite imagenObjeto;
        public string nombreObjeto;
        public string descripcionObjeto; // Nuevo campo para la descripci�n

        public SlotInventario(int id, Sprite imagen, string nombre, string descripcion)
        {
            idObjeto = id;
            cantidad = 1;
            imagenObjeto = imagen;
            nombreObjeto = nombre;
            descripcionObjeto = descripcion;
        }
    }

    public List<SlotInventario> slots = new List<SlotInventario>();
    public int maxSlots = 24;

    public Button[] botones; // Botones de cada slot
    public Image[] imagenes; // Im�genes de cada slot
    public TMP_Text nombreObjetoTexto; // Nombre del objeto en el panel
    public TMP_Text descripcionObjetoTexto; // Descripci�n del objeto en el panel
    public TMP_Text[] contadorTextos; // Contadores de objetos en cada slot
    public GameObject panelObjeto; // Panel de detalles del objeto
    public Animator panelAnimator; // Animaci�n del panel

    void Start()
    {
        for (int i = 0; i < maxSlots; i++)
        {
            slots.Add(null); // Inicializa los slots como vac�os
            int index = i; // Necesario para capturar correctamente el �ndice en el listener
            botones[i].onClick.AddListener(() => SeleccionarObjeto(index));
        }
    }

    public void AgregarObjeto(int idObjeto, Sprite imagenObjeto, string nombreObjeto, string descripcionObjeto)
    {
        for (int i = 0; i < maxSlots; i++)
        {
            if (slots[i] != null && slots[i].idObjeto == idObjeto) // Si el objeto ya est� en un slot, aumenta la cantidad
            {
                slots[i].cantidad++;
                contadorTextos[i].text = slots[i].cantidad.ToString();
                return;
            }
        }

        for (int i = 0; i < maxSlots; i++)
        {
            if (slots[i] == null) // Si hay espacio vac�o, a�ade el objeto
            {
                slots[i] = new SlotInventario(idObjeto, imagenObjeto, nombreObjeto, descripcionObjeto);
                imagenes[i].sprite = imagenObjeto;
                contadorTextos[i].text = "1";
                return;
            }
        }

        Debug.Log("Inventario lleno, no se puede agregar m�s objetos.");
    }

    void SeleccionarObjeto(int slotIndex)
    {
        if (slots[slotIndex] != null) // Si hay un objeto en el slot
        {
            nombreObjetoTexto.text = slots[slotIndex].nombreObjeto;
            descripcionObjetoTexto.text = slots[slotIndex].descripcionObjeto; // Mostrar descripci�n en el panel
            panelObjeto.SetActive(true);
            panelAnimator.Play("PanelShow"); // Animaci�n de apertura del panel
        }
    }
}
