using UnityEngine;
using System.Collections;

public class playLucesProyectadas : MonoBehaviour
{
    public GameObject lucerio;
    private bool Lights = false;
    public Animator animadorLucesProyectadas;
    public AudioSource locucionProyeccion;
    public AudioSource musicaFondo;



    void Start()
    {
        animadorLucesProyectadas.GetComponent<Animator>();
        musicaFondo.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {

        // Debug.Log("enciendoluz");
        animadorLucesProyectadas.SetBool("luz", true);
        animadorLucesProyectadas.SetTrigger("enciendeLuz");
        StartCoroutine(fadeOutMusic());
        lucerio.SetActive(true);
        locucionProyeccion.Play();
        //  animadorLucesProyectadas.SetBool("Lights", true);
    }

    void OnTriggerExit (Collider col)
    {
        // Debug.Log("apagoLuz");
        animadorLucesProyectadas.SetBool("luz", false);
        
        StartCoroutine(fadeInMusic());
        lucerio.SetActive(false);
        locucionProyeccion.Stop();
       // animadorLucesProyectadas.Stop();
        animadorLucesProyectadas.ResetTrigger("enciendeLuz");
        
    }


    IEnumerator fadeOutMusic()
    {
        for (float T = 20; T > 0; T--)
        {
            musicaFondo.GetComponent<AudioSource>().volume = T / 10;
            yield return new WaitForSeconds(0.2f);
            // Debug.Log(musicaFondo.GetComponent<AudioSource>().volume);

        }
        yield return new WaitForSeconds(lucerio.GetComponent<Animation>()["proyeccion"].length);
        for (float T = 0; T > 20; T++)
        {
            musicaFondo.GetComponent<AudioSource>().volume = T / 10;
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator fadeInMusic()
    {
        for (float T = 0; T < 20; T++)
        {
            musicaFondo.GetComponent<AudioSource>().volume = T / 10;
            yield return new WaitForSeconds(0.2f);
            // Debug.Log(musicaFondo.GetComponent<AudioSource>().volume);

        }
        yield return new WaitForSeconds(lucerio.GetComponent<Animation>()["proyeccion"].length);
        for (float T = 0; T > 20; T++)
        {
            musicaFondo.GetComponent<AudioSource>().volume = T / 10;
            yield return new WaitForSeconds(0.2f);
        }
    }

}