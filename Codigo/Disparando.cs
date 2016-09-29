using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Disparando : MonoBehaviour {
    public Canvas PanelDetalles;
    public Text textoPieza;
    public Text textoDetalles;

    public Animator animVasijaMoche;
    public Animator animCollar;
    public Animator animVasijaMaya;
    public Animator animCasco2;
    public Animator animVasoKero;
    public Animator animMomia;
    public Animator animCasco;
    public Animator animMascara;

    private GameObject Pieza;
    public bool booleanoPieza=false;

    public AudioSource musicaFondo;
    public AudioSource locucionVasoKero;
    public AudioSource locucionMomia;
    public AudioSource locucionCasco;
    public AudioSource locucionCasco2;
    public AudioSource locucionMascara;
    public AudioSource locucionVasijaMaya;
    public AudioSource locucionCollar;
    public AudioSource locucionVasijaMoche;

    private float pausaLetra = 0.05f;
    private string textoDetallado;


    // Use this for initialization
    void Start () {
        PanelDetalles.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        
        if (Cardboard.SDK.Triggered && booleanoPieza==false) { 
        if (Physics.Raycast(transform.position, (forward), out hit,3))
        {
                PanelDetalles.enabled = true;
                Pieza = hit.collider.gameObject;
                StartCoroutine(fadeOutMusica(musicaFondo));

                if (Pieza.tag == "vaso")
                {
                    animVasoKero.SetBool("booleanoPieza", true);
                    booleanoPieza = true;
                    textoPieza.text = "Vaso ceremonial Kero";
                    //textoDetalles.text = "Realizado en madera que representa la cabeza de un jaguar o puma mostrando sus fauces. El jaguar aparece vinculado en el Perú, desde tiempos muy remotos, con fenómenos atmosféricos que propician la fecundidad de la tierra.Es también el símbolo andino de poder y grandeza, que suele aparecer íntimamente ligado a la nobleza incaica. En fiestas y celebraciones, estos vasos se utilizaban para hacer libaciones de chicha o bebida ritual.";
                    //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
                    //     autoAnda.puedoAndar = false;
                    textoDetallado = "Epoca: Siglo XVI-XVII                  Cultura: Inca";
                    StartCoroutine("maquinaEscribir");
                    locucionVasoKero.Play();
                }
                if (Pieza.tag == "mascara")
                {
                    animMascara.SetBool("booleanoPieza", true);
                    booleanoPieza = true;
                    textoPieza.text = "Frontal Tlingit";
                    //textoDetalles.text = "Frontal que combina rasgos humanos y de animal. Utilizados como parte de la indumentaria, por los chamanes y otros hombres destacados de la comunidad, durante las danzas en las ceremonias rituales Tlingit. En estas celebraciones se trataba de establecer contacto con los espíritus, ya que los chamanes lograban de éstos sus poderes. En este caso, algunos de los materiales empleados como el cobre o la plata indican el elevado estatus social de la persona que lo portaba. La representación de un rostro con características humanas y de animal puede hacer alusión a seres sobrenaturales protectores del clan. ";
                    //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
                    //  autoAnda.puedoAndar = false;
                    textoDetallado = "Epoca: Siglo XIII-XIX                  Cultura: Tligit";
                    StartCoroutine("maquinaEscribir");
                    locucionMascara.Play();
                }
                if (Pieza.tag == "momia")
                {
                    animMomia.SetBool("booleanoPieza", true);
                    booleanoPieza = true;
                    textoPieza.text = "Ajuar funerario";
                   // textoDetalles.text = "momia muy maja que, tendrá sus cosas pero de fiesta, te partes de risa con ella. gana siempre a la oca por ser tramposa como ella sola. le gustan los dias soleados y ver juego de tronos. ";
                    //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
                    //  autoAnda.puedoAndar = false;
                    textoDetallado = "Epoca: Siglo I(ac)-II                  Cultura: Paracas";
                    StartCoroutine("maquinaEscribir");
                    locucionMomia.Play();
                }
                if (Pieza.tag == "casco")
                {
                    animCasco.SetBool("booleanoPieza", true);
                    booleanoPieza = true;
                    textoPieza.text = "Casco Tlingit";
                    // textoDetalles.text = "casco de bomberos de los antiguos Tligit. iban bien preparaos pero luego dejaban el fuego arder mientras tiraban lonchas de panceta hasta que se quedaban crujientitas. ";
                    //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
                    //  autoAnda.puedoAndar = false;
                    textoDetallado = "Epoca: Siglo XVIII-XIX                  Cultura: Tligit";
                    StartCoroutine("maquinaEscribir");
                    locucionCasco.Play();
                }
                if (Pieza.tag == "casco2")
                {
                    animCasco2.SetBool("booleanoPieza", true);
                    booleanoPieza = true;
                    textoPieza.text = "Casco Tlingit";
                    // textoDetalles.text = "esto era para celebrar el jaloguin. no veas como se lo pasaban, reian, lloraban...";
                    //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
                    textoDetallado = "Epoca: Siglo XVIII(anterior)                  Cultura: Tligit";
                    StartCoroutine("maquinaEscribir");
                    locucionCasco2.Play();
                }
                if (Pieza.tag == "collar")
                {
                    animCollar.SetBool("booleanoPieza", true);
                    booleanoPieza = true;
                    textoPieza.text = "Barbote";
                    // textoDetalles.text = "carmen polo era una entusiasta de este tipo de accesorios. ya su marido le decia una y otra vez, con tu tio y con tu tia iras a belair";


                    textoDetallado = "Epoca: Siglo XVIII-XIX                  Cultura: Tligit";
                    StartCoroutine("maquinaEscribir");
                    locucionCollar.Play();

                    //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
                }
                if (Pieza.tag == "vasijaMaya")
                {
                    animVasijaMaya.SetBool("booleanoPieza", true);
                    booleanoPieza = true;
                    textoPieza.text = "Vasija Maya";
                    // textoDetalles.text = "aqui los adolescentes mayas, mezclaban cocacola y vino. no veas que castañas pillaban los jodios";
                    //    ImagenIconoObjeto.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Iconos/ObjetosEncontrar/vasoColor");
                    textoDetallado = "Epoca: Siglo VII-X                  Cultura: Maya";
                    StartCoroutine("maquinaEscribir");
                    locucionVasijaMaya.Play();
                }
                if (Pieza.tag == "vasijaMoche")
                {
                    animVasijaMoche.SetBool("booleanoPieza", true);
                    booleanoPieza = true;
                    textoPieza.text = "Vasija Moche";
                    // textoDetalles.text = "este otro era un recipiente donde los voluntarios moches del domund iban pidiendo pasta. casi nadie les hacia caso";
                    textoDetallado = "Epoca: Siglo II-VIII                  Cultura: Moche";
                    StartCoroutine("maquinaEscribir");
                    locucionVasijaMoche.Play();
                }
                
            }
         //   Debug.Log(Pieza.tag + " cosa");
            
        }

        else if (Cardboard.SDK.Triggered && booleanoPieza == true)
        {
            booleanoPieza = false;
            textoDetalles.text = "";
            animVasijaMoche.SetBool("booleanoPieza", false);
            animCollar.SetBool("booleanoPieza", false);
            animVasijaMaya.SetBool("booleanoPieza", false);
            animCasco2.SetBool("booleanoPieza", false);
            animVasoKero.SetBool("booleanoPieza", false);
            animMomia.SetBool("booleanoPieza", false);
            animCasco.SetBool("booleanoPieza", false);
            animMascara.SetBool("booleanoPieza", false);
            StartCoroutine(fadeInMusica(musicaFondo));
            locucionCasco.Stop();
            locucionCasco2.Stop();
            locucionCollar.Stop();
            locucionMascara.Stop();
            locucionMomia.Stop();
            locucionVasijaMaya.Stop();
            locucionVasijaMoche.Stop();
            locucionVasoKero.Stop();
        }

    }

IEnumerator maquinaEscribir()
    {
        yield return new WaitForSeconds(1);
        textoDetalles.text = "";
        foreach (char letra in textoDetallado)
        {
            textoDetalles.text += letra;
            yield return new WaitForSeconds(pausaLetra);
        }
    }

    IEnumerator fadeOutMusica(AudioSource sonido)
    {
        for (int i = 10; i > 0; i--)
        {
            musicaFondo.volume = i * 0.1F;
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator fadeInMusica(AudioSource sonido)
    {
        for (int i = 0; i < 10; i++)
        {
            musicaFondo.volume = i * 0.1F;
            yield return new WaitForSeconds(0.2f);
        }
    }
}
