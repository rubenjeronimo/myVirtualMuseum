using UnityEngine;
using System.Collections;

public class estadosPersonaje : MonoBehaviour {
    public bool musicaEnchufeBool=false;
    public bool animacionLucesBool=false;
    public AudioSource musicaFondo;
    public Animator animacionLuces;
	// Use this for initialization
	void Start () {
        animacionLuces.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (musicaFondo.isActiveAndEnabled)
        {
            musicaEnchufeBool = true;
        }
        if (animacionLuces.isActiveAndEnabled)
        {
            animacionLucesBool= true;
        }
	}
}
