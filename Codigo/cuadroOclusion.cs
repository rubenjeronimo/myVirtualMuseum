using UnityEngine;
using System.Collections;

public class cuadroOclusion : MonoBehaviour {


    //   private bool Cuadrosde123=false;


    // public Animator animadorCuadros123;
    // public AudioSource locucionProyeccion;
    public GameObject cuadro1;

    public float duracion = 10.0f;

    public AudioSource musicaFondo;

    // Use this for initialization
    void Start()
    {
        musicaFondo.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        
        StartCoroutine(fadeInCuadro());
        StartCoroutine(fadeOutMusica(musicaFondo));

    }
    void OnTriggerExit(Collider col)
    {
        StartCoroutine(fadeOutCuadro());
        StartCoroutine(fadeInMusica(musicaFondo));
    }

    IEnumerator fadeInCuadro()
    {

        for (float T = 0; T < duracion * 2; T++)
        {
            cuadro1.GetComponent<Renderer>().material.SetFloat("_OcclusionStrength", T / 20);
            
            yield return new WaitForSeconds(0.2f);
        }
        
    }
    


    IEnumerator fadeOutCuadro()
    {
        yield return new WaitForSeconds(2.0f);
        cuadro1.GetComponent<Renderer>().material.SetFloat("_OcclusionStrength", 0);

        yield return new WaitForSeconds(0.2f);
        /*
        for (float T = duracion; T >= 0; T--)
        {
            cuadro1.GetComponent<Renderer>().material.SetFloat("_OcclusionStrength", T / 10);

            yield return new WaitForSeconds(0.2f);
        }
        */
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
