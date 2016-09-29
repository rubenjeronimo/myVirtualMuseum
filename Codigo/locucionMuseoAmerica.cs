using UnityEngine;
using System.Collections;

public class locucionMuseoAmerica : MonoBehaviour {
    public AudioSource locucionMuseo;
    public AudioSource musicaFondo;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {

        // StartCoroutine(fadeInCuadro());
        StartCoroutine(fadeOutMusica(musicaFondo));
        locucionMuseo.Play();
    }

    void OnTriggerExit(Collider col)
    {
        //  StartCoroutine(fadeOutCuadro());
        locucionMuseo.Stop();
        StartCoroutine(fadeInMusica(musicaFondo));

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
