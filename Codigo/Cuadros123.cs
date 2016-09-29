using UnityEngine;
using System.Collections;

public class Cuadros123 : MonoBehaviour {
    //   private bool Cuadrosde123=false;


    // public Animator animadorCuadros123;
    // public AudioSource locucionProyeccion;
    public GameObject cuadro1;
    public GameObject cuadro2;
    public GameObject cuadro3;
    public float duracion = 10.0f;

    public AudioSource musicaFondo;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {
        StartCoroutine(fadeInCuadro());

    }
    void OnTriggerExit(Collider col)
    {
        StartCoroutine(fadeOutCuadro());

    }

    IEnumerator fadeInCuadro()
    {

        for (float T = 0; T < duracion * 2; T++)
        {
            cuadro1.GetComponent<Renderer>().material.SetFloat("_OcclusionStrength", T / 20);
            yield return new WaitForSeconds(0.2f);
        }
        yield return new WaitForSeconds(2.5f);
        for (float T = 0; T < duracion * 2; T++)
        {
            cuadro2.GetComponent<Renderer>().material.SetFloat("_OcclusionStrength", T / 20);
            yield return new WaitForSeconds(0.2f);
        }
        yield return new WaitForSeconds(2.5f);
        for (float T = 0; T < duracion * 2; T++)
        {
            cuadro3.GetComponent<Renderer>().material.SetFloat("_OcclusionStrength", T / 20);
            yield return new WaitForSeconds(0.2f);
        }
    }


    IEnumerator fadeOutCuadro()
    {

        for (float T = duracion; T >= 0; T--)
        {
            cuadro1.GetComponent<Renderer>().material.SetFloat("_OcclusionStrength", T / 10);
            cuadro2.GetComponent<Renderer>().material.SetFloat("_OcclusionStrength", T / 10);
            cuadro3.GetComponent<Renderer>().material.SetFloat("_OcclusionStrength", T / 10);
            yield return new WaitForSeconds(0.2f);
        }
    }
}
