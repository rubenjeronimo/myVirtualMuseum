using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mirandoCuadro : MonoBehaviour {
    public Canvas PanelDetalles;
    public Text textoPieza;
    public Text textoDetalles;
    // public AudioSource locucionCuadroEsmeraldas;
    // public AudioSource locucionLima;
    // public AudioSource locucionQuito;
    // public AudioSource locucionMorcillo;
    public AudioSource locucionCuadro;
    public AudioSource musicaFondo;
    public GameObject cuadro;



    void Start () {
        PanelDetalles.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {

       // StartCoroutine(fadeInCuadro());
        StartCoroutine(fadeOutMusica(musicaFondo));
        PanelDetalles.enabled = true;
        textoPieza.enabled = true;
        textoDetalles.text = "  ";
        if (cuadro.tag == "cuadroEsmeraldas")
        {
            Debug.Log("esmeraldas");
            locucionCuadro.Play();
            textoPieza.text = "Los mulatos de Esmeraldas";
        }
        if (cuadro.tag == "cuadroQuito")
        {
            Debug.Log("Quito");
            locucionCuadro.Play();
            textoPieza.text = "Entrada en Quito de tropas españolas";
        }
        if (cuadro.tag == "cuadroLima")
        {
            Debug.Log("Lima");
            locucionCuadro.Play();
            textoPieza.text = "Plaza mayor de Lima";
        }
        if (cuadro.tag == "cuadroMorcillo")
        {
            Debug.Log("Morcillo");
            locucionCuadro.Play();
            textoPieza.text = "Entrada del virrey Morcillo en Potosí";
        }
    }


    void OnTriggerExit(Collider col)
    {
        //  StartCoroutine(fadeOutCuadro());
        locucionCuadro.Stop();
        StartCoroutine(fadeInMusica(musicaFondo));
        textoPieza.text = " ";
        PanelDetalles.enabled = false;
    }



    IEnumerator fadeOutMusica(AudioSource sonido)
    {
        for (int i = 10; i > 0; i--)
        {
            musicaFondo.volume = i * 0.1F;
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator fadeInMusica(AudioSource sonido)
    {
        for (int i = 0; i < 10; i++)
        {
            musicaFondo.volume = i * 0.1F;
            yield return new WaitForSeconds(0.2f);
        }
    }
}
