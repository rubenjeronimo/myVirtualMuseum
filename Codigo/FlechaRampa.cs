using UnityEngine;
using System.Collections;

public class FlechaRampa : MonoBehaviour {
    public GameObject indicacion;
	// Use this for initialization
	void Start () {
        indicacion.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
      void  OnTriggerEnter()
    {
        indicacion.SetActive(true);
    }
    void OnTriggerExit()
    {
        indicacion.SetActive(false);
    }
}
