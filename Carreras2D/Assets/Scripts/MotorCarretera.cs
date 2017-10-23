using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorCarretera : MonoBehaviour
{
    public GameObject contenedorCallesGO;
    public GameObject[] arregloContenedorCalles;

    public float velocidad;
    public bool inicioJuego;
    public bool finJuego;

    int contadorCalles = 0;
    int numeroSelectorCalles;

    public GameObject calleAnterior;
    public GameObject calleNueva;

    public float tamañoCalle;

    public Vector3 medidaLimitePantalla;
    public bool salidaPantalla;
    public GameObject camaraGO;
    public Camera camaraComponente;

    public GameObject cocheGO;
    public GameObject efectosSonidoGO;
    public EfectosSonido efectosSonidoScript;
    public GameObject bgFinalGO;

    // Use this for initialization
    void Start()
    {
        InicioJuego();
    }

    // Update is called once per frame
    void Update()
    {
        if (inicioJuego == true && finJuego == false)
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);

            if (calleAnterior.transform.position.y + tamañoCalle < medidaLimitePantalla.y && salidaPantalla == false)
            {
                salidaPantalla = true;
                DestruirCalles();
            }
        }

    }

    void InicioJuego()
    {
        contenedorCallesGO = GameObject.Find("ContenedorCalles");

        camaraGO = GameObject.Find("MainCamera");
        camaraComponente = camaraGO.GetComponent<Camera>();

        bgFinalGO = GameObject.Find("PanelGameOver");
        bgFinalGO.SetActive(false);

        efectosSonidoGO = GameObject.Find("EfectosSonido");
        efectosSonidoScript = efectosSonidoGO.GetComponent<EfectosSonido>();

        cocheGO = GameObject.FindObjectOfType<Coche>().gameObject;

        VelocidadMotorCarretera();
        MedirPantalla();
        BuscarCalles();
    }

    void VelocidadMotorCarretera()
    {
        velocidad = 20;
    }

    void BuscarCalles()
    {
        arregloContenedorCalles = GameObject.FindGameObjectsWithTag("Calle");
        for (int i = 0; i < arregloContenedorCalles.Length; i++)
        {
            arregloContenedorCalles[i].gameObject.transform.parent = contenedorCallesGO.transform;
            arregloContenedorCalles[i].gameObject.SetActive(false);
            arregloContenedorCalles[i].gameObject.name = "CalleApagada" + i;
        }
        CrearCalles();
    }

    void CrearCalles()
    {
        contadorCalles++;
        numeroSelectorCalles = Random.Range(0, arregloContenedorCalles.Length);
        GameObject Calle = Instantiate(arregloContenedorCalles[numeroSelectorCalles]);
        Calle.SetActive(true);
        Calle.name = "Calle" + contadorCalles;
        Calle.transform.parent = gameObject.transform;
        PosicionarCalles();
    }

    void PosicionarCalles()
    {
        calleAnterior = GameObject.Find("Calle" + (contadorCalles - 1));
        calleNueva = GameObject.Find("Calle" + contadorCalles);
        MedirCalle();
        calleNueva.transform.position = new Vector3(calleAnterior.transform.position.x, calleAnterior.transform.position.y + tamañoCalle, 0);
        salidaPantalla = false;
    }

    void MedirCalle()
    {
        for (int i = 0; i < calleAnterior.transform.childCount; i++)
        {
            if (calleAnterior.transform.GetChild(i).gameObject.GetComponent<Calle>() != null)
            {
                float tamañoCalles = calleAnterior.transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
                tamañoCalle = tamañoCalle + tamañoCalles;
            }
        }
    }

    void MedirPantalla()
    {
        medidaLimitePantalla = new Vector3(0, camaraComponente.ScreenToWorldPoint(new Vector3(0, 0, 0)).y - 0.5f, 0);
    }

    void DestruirCalles()
    {
        Destroy(calleAnterior);
        tamañoCalle = 0;
        calleAnterior = null;
        CrearCalles();
    }

    public void JuegoTerminado()
    {
        cocheGO.GetComponent<AudioSource>().Stop();
        efectosSonidoScript.SonidoMusica();
        bgFinalGO.SetActive(true);
    }

}
