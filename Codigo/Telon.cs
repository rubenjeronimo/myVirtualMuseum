using UnityEngine;
using System.Collections;

public class Telon : MonoBehaviour
   
{
    public Animator telonAnim;
    private Animation animacionTelon;
    public GameObject telon;
    // Use this for initialization
	void Start () {
	telonAnim = GetComponent<Animator>();
        animacionTelon = GetComponent<Animation>();
        animacionTelon.Play("Telon");
        StartCoroutine(esperar());
        telon.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator esperar()
    {
        yield return new WaitForSeconds(1F);
    }
}
