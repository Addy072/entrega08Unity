using UnityEngine;

public class TabletManager : MonoBehaviour
{
    public Animator tablet;
    public int estado = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicktablet()
    {
        fueradentrotablet();
    }

    void fueradentrotablet()
    {
        if (estado == 0)
        {
            sacartablet();
        }
        else
        {
            guardartablet();
        }
    }

    void sacartablet()
    {
        estado++;
        tablet.Play("tableta");
    }

    void guardartablet()
    {
        estado--;
        tablet.Play("tabletaOut");
    }
}
