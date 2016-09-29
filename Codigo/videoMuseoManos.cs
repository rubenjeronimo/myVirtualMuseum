using UnityEngine;
using System.Collections;

public class videoMuseoManos : MonoBehaviour {

  //  public MovieTexture proyeccion;
    public GameObject proyector;
    public GameObject luzArriba;

	// Use this for initialization
	void Start () {

            proyector.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {

        Debug.Log("video");
        luzArriba.SetActive(false);

        proyector.SetActive(true);
        Handheld.PlayFullScreenMovie("Museo america_05052015.mp4", Color.white, FullScreenMovieControlMode.CancelOnInput);
        //   proyeccion.Play();
        StartCoroutine(activarDespues(330f));
    }
    private IEnumerator activarDespues(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        proyector.SetActive(false);
        luzArriba.SetActive(true);

    }
}
