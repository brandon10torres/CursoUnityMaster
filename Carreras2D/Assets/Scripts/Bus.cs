using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    public GameObject cronometroGO;
    public Cronometro cronometroScript;

    public GameObject efectosSonidoGO;
    public EfectosSonido efectosSonidoScript;

    void Start()
    {
        cronometroGO = GameObject.FindObjectOfType<Cronometro>().gameObject;
        cronometroScript = cronometroGO.GetComponent<Cronometro>();

        efectosSonidoGO = GameObject.FindObjectOfType<EfectosSonido>().gameObject;
        efectosSonidoScript = efectosSonidoGO.GetComponent<EfectosSonido>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Coche>() != null)
        {
            efectosSonidoScript.SonidoChoque();
            cronometroScript.tiempo = cronometroScript.tiempo - 20;
            Destroy(this.gameObject);
        }
    }
}
