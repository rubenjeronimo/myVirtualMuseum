using UnityEngine;
using System.Collections;

public class Flechas : MonoBehaviour {
    public GameObject cuadrosFlechas;
    private Animator FlechasAnim;
    private Animation flechasAnimacion; 
	// Use this for initialization
	void Start () {
       // cuadrosFlechas.SetActive(true);
        FlechasAnim = GetComponent<Animator>();
        flechasAnimacion = GetComponent<Animation>();
        flechasAnimacion.Play("Flechas");
        StartCoroutine(esperar());
        cuadrosFlechas.gameObject.SetActive(false);
        //cuadrosFlechas.SetActive(false);


    }
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator esperar()
    {
        yield return new WaitForSeconds(2F);
    }
}
