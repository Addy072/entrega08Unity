using UnityEngine;

public class GestorSubmenu : MonoBehaviour
{
    public int ActualSubmenu =0;
    public int SubmenuAnterior = 0;
    public Animator Creditos; 
    public Animator Partidas;
    public Animator Salir;
    

    public void estado()
    {
        if (SubmenuAnterior > 0)
        {
            Out();
            SubmenuAnterior = ActualSubmenu;
            In();

        }
        else
        {
            In();
            SubmenuAnterior = ActualSubmenu;
        }


    }


    public void In()
    {
        switch(ActualSubmenu)
        {
            case 1:
                Creditos.Play("CreditosIn");
                break;
            case 2:
                Salir.Play("SalirIn");
                break;
            case 3:
                Partidas.Play("PartidaspanelIn");
                break;
        }

    }

    public void Out()
    {
        switch (SubmenuAnterior)
        {
            case 1:
                Creditos.Play("CreditosOut");
                break;
            case 2:
                Salir.Play("SalirOut");
                break;
            case 3:
                Partidas.Play("PartidaspanelOut");
                break;
        }

    }


    public void AniCreditos() 
    {
        ActualSubmenu = 1;
        estado();
    
    }
    public void AniSalir() 
    {
        ActualSubmenu = 2;
        estado();

    }

    public void AniPartidas()
    {
        ActualSubmenu = 3;
        estado();
    }
}
