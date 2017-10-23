using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaRegresiva : MonoBehaviour
{
    public GameObject motorCarreteraGO;
    public MotorCarretera motorCarreteraScript;
    public Sprite[] numeros;

    public GameObject contadorNumerosGO;
    public SpriteRenderer contadorNumerosComponente;

    public GameObject controladorCocheGO;
    public GameObject cocheGO;



	// Use this for initialization
	void Start ()
    {
        InicioComponentes();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void InicioComponentes()
    {
        motorCarreteraGO = GameObject.Find("MotorCarretera");
        motorCarreteraScript = motorCarreteraGO.GetComponent<MotorCarretera>();

        contadorNumerosGO = GameObject.Find("ContadorNumeros");
        contadorNumerosComponente = contadorNumerosGO.GetComponent<SpriteRenderer>();

        cocheGO = GameObject.Find("Coche");
        controladorCocheGO = GameObject.Find("ControladorCoche");

        InicioCuentaRegresiva();
    }

    void InicioCuentaRegresiva()
    {
        StartCoroutine(Contador());
    }

    IEnumerator Contador()
    {
        controladorCocheGO.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2);

        contadorNumerosComponente.sprite = numeros[1];
        this.gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1);

        contadorNumerosComponente.sprite = numeros[2];
        this.gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1);

        contadorNumerosComponente.sprite = numeros[3];
        motorCarreteraScript.inicioJuego = true;
        contadorNumerosGO.GetComponent<AudioSource>().Play();
        cocheGO.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(2);

        contadorNumerosGO.SetActive(false);
    }
}
