using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MirandoCuadro : MonoBehaviour {
    public Camera camara;
    public GameObject objeto;
   // public Image ImagenIconoObjeto;
    public AudioClip recogeObjetoSonido;
    private AudioSource source;

    public Canvas PanelDetalles;
    public Text textoPieza;
    public Text textoDetalles;

    //  private Autowalk autoAnda;
    // public GameObject personaje;
    // public Animation animacion;

    // public Color bgOpacity;
    //  public Material transparente;


    // Use this for initialization
    void Start () {

        PanelDetalles.enabled = false;

      //  animacion = objeto.GetComponent<Animation>();
    }
	
	// Update is called once per frame
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

	void Update () {

	}
    public void noMiraObjeto()
    {
        PanelDetalles.enabled = false;
    }
    public void miraObjeto()
    {
        GetComponent<ParticleSystem>().Emit(10);
       
        // Color colorBegin = objeto.GetComponent<Shader>().a;
        // Color colorEnd = new Color(colorBegin.r, colorBegin.g, colorBegin.b, 0f);
        //    float Delay += Time.deltaTime;
        //for (int i = 0; i <= 1000; i++)
        //{
        //objeto.GetComponent<Material>().color = Color.Lerp(colorBegin, colorEnd, 1000 * 1f);
        //}
        //objeto.gameObject.SetActive(false);

    }

/*
   public void pinchaObjeto()
    {
        PanelDetalles.enabled = true;
        if (objeto.tag == "vaso")
        {
            Debug.Log("vaso");
            textoPieza.text = "Vaso ceremonial Kero";
            textoDetalles.text = "Realizado en madera que representa la cabeza de un jaguar o puma mostrando sus fauces. El jaguar aparece vinculado en el Perú, desde tiempos muy remotos, con fenómenos atmosféricos que propician la fecundidad de la tierra.Es también el símbolo andino de poder y grandeza, que suele aparecer íntimamente ligado a la nobleza incaica. En fiestas y celebraciones, estos vasos se utilizaban para hacer libaciones de chicha o bebida ritual.";
            //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
       //     autoAnda.puedoAndar = false;
        
        }
        if (objeto.tag == "mascara")
        {
            Debug.Log("mascara");
            textoPieza.text = "Frontal Tlingit";
            textoDetalles.text = "Frontal que combina rasgos humanos y de animal. Utilizados como parte de la indumentaria, por los chamanes y otros hombres destacados de la comunidad, durante las danzas en las ceremonias rituales Tlingit. En estas celebraciones se trataba de establecer contacto con los espíritus, ya que los chamanes lograban de éstos sus poderes. En este caso, algunos de los materiales empleados como el cobre o la plata indican el elevado estatus social de la persona que lo portaba. La representación de un rostro con características humanas y de animal puede hacer alusión a seres sobrenaturales protectores del clan. ";
            //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
          //  autoAnda.puedoAndar = false;
            
        }
        if (objeto.tag == "momia")
        {
            Debug.Log("momia");
            textoPieza.text = "Ajuar funerario";
            textoDetalles.text = "momia muy maja que, tendrá sus cosas pero de fiesta, te partes de risa con ella. gana siempre a la oca por ser tramposa como ella sola. le gustan los dias soleados y ver juego de tronos. ";
            //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
            //  autoAnda.puedoAndar = false;

        }
        if (objeto.tag == "casco")
        {
            Debug.Log("casco");
            textoPieza.text = "Casco Tlingit";
            textoDetalles.text = "casco de bomberos de los antiguos Tligit. iban bien preparaos pero luego dejaban el fuego arder mientras tiraban lonchas de panceta hasta que se quedaban crujientitas. ";
            //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
            //  autoAnda.puedoAndar = false;

        }
        if (objeto.tag == "casco2")
        {
            Debug.Log("Casco Tlingit");
            textoPieza.text = "Casco Tlingit";
            textoDetalles.text = "esto era para celebrar el jaloguin. no veas como se lo pasaban, reian, lloraban...";
            //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
        }
        if (objeto.tag == "collar")
        {
            Debug.Log("Collar");
            textoPieza.text = "Collar";
            textoDetalles.text = "carmen polo era una entusiasta de este tipo de accesorios. ya su marido le decia una y otra vez, con tu tio y con tu tia iras a belair";
            //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
        }
        if (objeto.tag == "vasijaMaya")
        {
            Debug.Log("Vasija Maya");
            textoPieza.text = "Vasija Maya";
            textoDetalles.text = "aqui los adolescentes mayas, mezclaban cocacola y vino. no veas que castañas pillaban los jodios";
            //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
        }
        if (objeto.tag == "vasijaMoche")
        {
            Debug.Log("Vasija Moche");
            textoPieza.text = "Vasija Moche";
            textoDetalles.text = "este otro era un recipiente donde los voluntarios moches del domund iban pidiendo pasta. casi nadie les hacia caso";
            //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
        }
    }
    
    public void recogerObjeto()
    {
       var  objetol = new ObjetosRecogidos();
        if (objeto.tag == "foto")
        {
            //      animacion.Play("DesapareceCubo2");

            //      ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/fotoColor");
            objetol.recogeObjeto1();
        }
        if (objeto.tag == "TelaParacas")
        {
            //     animacion.Play("desapareceTelaParacas");

            //     ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/telaParacasColor");
        }
        if (objeto.tag == "LibroArqueologia")
        {
            //   animacion.Play("desapareceLibro");

            //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/libroArqueologiaColor");
        }
        if (objeto.tag == "CeramicaParacas")
        {

            //     ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/mascaraColor");
            //     animacion.Play("desapareceMascara");

            if (objeto.tag == "casco")
            {
                //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/cascoColor");
            }
            if (objeto.tag == "mascara")
            {
                //    animacion.Play("desapareceMascara");
                //       ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/mascaraColor");
                //Application.LoadLevel("test");

            }
            if (objeto.tag == "momia")
            {
                //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/momiaColor");
                objeto.GetComponent<Renderer>().material.shader = Shader.Find("Transparent/Diffuse");
            }

            if (objeto.tag == "vaso")
            {
                Debug.Log("vaso");
                textoPieza.text = "Vaso ceremonial Kero";
                //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
            }
            
        }     
        sonata();
        StartCoroutine(esperar());

    }
    */
    IEnumerator esperar()
    {
        yield return new WaitForSeconds(recogeObjetoSonido.length);
        
       // objeto.gameObject.SetActive(false);
    }
    
    void sonata()
    {
        source.PlayOneShot(recogeObjetoSonido,1F);

    }


}
