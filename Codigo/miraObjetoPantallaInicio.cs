using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class miraObjetoPantallaInicio : MonoBehaviour
{
   // private int idAyuda = 0;
  public Canvas ayuda;
   // public Text ayudaTexto;
       public Text textoAyuda;
    public Text textoAyuda2;

    public float i = 0.0f;
    // Use this for initialization
    public bool textoActivado = false;
    void Start()
    {
        ayuda.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void miraObjeto()
    {
      //  Debug.Log("kdkdkdkdk");
        GetComponent<ParticleSystem>().Emit(10);
    }
    public void avanzaPantalla()
    {
        SceneManager.LoadScene("museo");
    }
    public void ayudando()
    {
        Debug.Log("ayuda");
        ayuda.enabled = true;

        textoActivado = true;

        textoAyuda.text = "";
       // i = 0f;
       // textoAyuda.transform.localPosition = new Vector3(-9.53674f, -200.0f, 0f);
        textoAyuda.lineSpacing = 2;
        textoAyuda.text = "Esto es un museo virtual, o sea que debes recorrerlo igual que uno real solo que, cuando un objeto emita particulas, podras obtener informacion directamente apretando el boton lateral. \n \n Pulsa el boton magnetico de la izquierda de tu cardboard para andar y nuevamente para parar. \n \n  Si ves unos pies en el suelo, quizá sea interesante que mires alrededor";
        // textoAyuda2.text = "Pulsa el boton magnetico de la izquierda de tu cardboard para andar y nuevamente para parar.                               Si ves unos pies en el suelo, quizá sea interesante que mires alrededor";
        if (i==0)
        {

          //  i = 0f;

            StartCoroutine("creditosScroll");
        }
        else if (i>=0)
        {
            StopCoroutine("creditosScroll");
            i = 0f;
          //  textoActivado = false;
            StartCoroutine("creditosScroll");
        }
        
       
    }
    public void ocultarDetalles()
    {
        ayuda.enabled = false;
        textoActivado = false;
        i = 0.0f;
    }

    public void Creditos()
    {
        Debug.Log("CREDITOS");
        ayuda.enabled = true;

        textoActivado = true;

        textoAyuda.text = "";
      //  textoAyuda.transform.localPosition = new Vector3(-9.53674f, -200.0f, 0f);
        textoAyuda.lineSpacing = 2;
        textoAyuda.text = "Programación, modelado 3D, fotogrametría: Rubén Jerónimo Fernandez (LandGraphix) \n \n voz en off: Maria Navarro \n \n Grabación y edición sonido: Albert Ginés \n \n Gracias a Andres Gutierrez, Agathe Torres y al museo de América por su contribución y cesión de las piezas, a Yago Alfaro (sensei) \n \n y sobre todo, a Beatriz García Gonzalez ya que todo tiene sentido junto a ella.";
       // textoAyuda2.text = "";
        if (i == 0)
        {
            
          //  i = 0f;
            
            StartCoroutine("creditosScroll");
        }
        else if (i >= 0)
        {
            StopCoroutine("creditosScroll");
          //  i = 0f;
            textoActivado = false;
            StartCoroutine("creditosScroll");
        }

        
    }

    IEnumerator creditosScroll()
    {
        //  textoActivado = true;
        i = 0f;
        Vector3 posicionInicial = new Vector3(-9.53674f, -200.0f, 0f);
        Vector3 posicionActual = textoAyuda.transform.localPosition;
        for (i = 0f; i <= 800; i++)
        {
         //   float t = i / 1;
            textoAyuda.transform.localPosition = posicionInicial + new Vector3(0f, i, 0f);
            //  textoAyuda.transform.localPosition = posicionActual + new Vector3(0f,t,0f);
            //  Debug.Log(ayuda.transform.localPosition);
            yield return new WaitForSeconds(0.01f);
        }
        
    }
}
