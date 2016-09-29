using UnityEngine;
using System.Collections;

public class locucionTlingit : MonoBehaviour {
    public AudioSource locucionProyeccion;
    public AudioSource musicaFondo;
    // Use this for initialization
    void Start () {
        musicaFondo.GetComponent<AudioSource>();
        locucionProyeccion.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        locucionProyeccion.Play();
        StartCoroutine(fadeOutMusic());
    }

    void OnTriggerExit(Collider col)
    {
        locucionProyeccion.Stop();
        StartCoroutine(fadeInMusic());

    }

    IEnumerator fadeOutMusic()
    {
        for (float T = 20; T > 0; T--)
        {
            musicaFondo.GetComponent<AudioSource>().volume = T / 10;
            yield return new WaitForSeconds(0.2f);
            // Debug.Log(musicaFondo.GetComponent<AudioSource>().volume);

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

    }
}
