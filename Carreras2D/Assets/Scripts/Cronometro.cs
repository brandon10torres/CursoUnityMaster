using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public GameObject motorCarreteraGO;
    public MotorCarretera motorCarreteraScript;

    public float tiempo;
    public float distancia;
    public Text txtTiempo;
    public Text txtDistancia;
    public Text txtDistanciaFinal;

    // Use this for initialization
    void Start ()
    {
        motorCarreteraGO = GameObject.Find("MotorCarretera");
        motorCarreteraScript = motorCarreteraGO.GetComponent<MotorCarretera>();
        txtTiempo.text = "2:00";
        txtDistancia.text = "0";

        tiempo = 120;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(motorCarreteraScript.inicioJuego == true && motorCarreteraScript.finJuego == false)
        {
            CalcularTiempoDistancia();
        }

        if (tiempo <= 0 && motorCarreteraScript.finJuego == false)
        {
            motorCarreteraScript.finJuego = true;
            motorCarreteraScript.JuegoTerminado();
            txtDistanciaFinal.text = ((int)distancia).ToString() + "M";
            txtTiempo.text = "0:00";
        }
	}

    void CalcularTiempoDistancia()
    {
        distancia += Time.deltaTime * motorCarreteraScript.velocidad;
        txtDistancia.text = ((int)distancia).ToString();

        tiempo -= Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        txtTiempo.text = minutos.ToString() + ":" + segundos.ToString().PadLeft(2, '0');
    }
}
