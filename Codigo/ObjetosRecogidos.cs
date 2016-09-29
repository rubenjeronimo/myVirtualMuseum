using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ObjetosRecogidos : MonoBehaviour {
    public bool objeto1bool;
    public bool objeto2bool;
    public bool objeto3bool;
    public GameObject objetoFinal;

    // Use this for initialization
    void Start () {
        objeto1bool = false;
        objeto2bool = false;
        objeto3bool = false;
        objetoFinal.SetActive(false);
    }


    public void recogeObjeto1()
    {
        objeto1bool = true;
        CompruebaObjetos();
    }
    public void recogeObjeto2()
    {
        objeto2bool = true;
        CompruebaObjetos();
    }
    public void recogeObjeto3()
    {
        objeto3bool = true;

        CompruebaObjetos();


    }

    void CompruebaObjetos()
    {
        if ((objeto1bool == false) || (objeto2bool == false))
        {
            objetoFinal.SetActive(false);
        }
        else if ((objeto1bool == true) && (objeto2bool == true))
        {
            objetoFinal.SetActive(true);
        }
    }
}
