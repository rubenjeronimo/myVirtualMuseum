using UnityEngine;
using System.Collections;

public class pantallaInicio : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(esperaAnimacion());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator esperaAnimacion()
    {
        yield return new WaitForSeconds(8);
        gameObject.SetActive(false);
    }
}
