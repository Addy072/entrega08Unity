using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventario : MonoBehaviour
{
    public class SlotInventario
    {
        public int idObjeto;
        public int cantidad;
        public Sprite imagenObjeto;
        public string nombreObjeto;
        public string descripcionObjeto;

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

    public Button[] botones;
    public Image[] imagenes;
    public TMP_Text nombreObjetoTexto;
    public TMP_Text descripcionObjetoTexto;
    public TMP_Text[] contadorTextos;
    public GameObject panelObjeto;
    public Animator panelAnimator;

    // Diccionario con nombres personalizados para los objetos
    private Dictionary<int, string> nombresObjetos = new Dictionary<int, string>()
    {
        { 0, "Flor" },
        { 1, "Reloj" },
        { 2, "Corazón" },
        { 3, "Gota de agua" },
        { 4, "Bombilla" },
        { 5, "Detector" }
    };

    private Dictionary<int, string> descripcionesObjetos = new Dictionary<int, string>()
    {
        { 0, "Una hermosa flor fragante." },
        { 1, "Un reloj que marca el tiempo con precisión." },
        { 2, "Símbolo de vida y amor." },
        { 3, "Esencial para la hidratación." },
        { 4, "Fuente de luz y conocimiento." },
        { 5, "Dispositivo para detectar señales ocultas." }
    };

    void Start()
    {
        for (int i = 0; i < maxSlots; i++)
        {
            slots.Add(null);
            int index = i;
            botones[i].onClick.AddListener(() => SeleccionarObjeto(index));
        }
    }

    public void AgregarObjeto(int idObjeto, Sprite imagenObjeto)
    {
        string nombreObjeto = nombresObjetos.ContainsKey(idObjeto) ? nombresObjetos[idObjeto] : "Objeto desconocido";
        string descripcionObjeto = descripcionesObjetos.ContainsKey(idObjeto) ? descripcionesObjetos[idObjeto] : "Sin descripción";

        for (int i = 0; i < maxSlots; i++)
        {
            if (slots[i] != null && slots[i].idObjeto == idObjeto)
            {
                slots[i].cantidad++;
                contadorTextos[i].text = slots[i].cantidad.ToString();
                return;
            }
        }

        for (int i = 0; i < maxSlots; i++)
        {
            if (slots[i] == null)
            {
                slots[i] = new SlotInventario(idObjeto, imagenObjeto, nombreObjeto, descripcionObjeto);
                imagenes[i].sprite = imagenObjeto;
                contadorTextos[i].text = "1";
                return;
            }
        }

        Debug.Log("Inventario lleno, no se puede agregar más objetos.");
    }

    void SeleccionarObjeto(int slotIndex)
    {
        if (slots[slotIndex] != null)
        {
            nombreObjetoTexto.text = slots[slotIndex].nombreObjeto;
            descripcionObjetoTexto.text = slots[slotIndex].descripcionObjeto;
            panelObjeto.SetActive(true);
            panelAnimator.Play("descobj");
        }
    }
}
