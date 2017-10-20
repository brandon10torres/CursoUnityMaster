using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanica1 : MonoBehaviour
{

    public GameObject miCamara;
    public GameObject buscarGO;
    public GameObject[] cubos;


	// Use this for initialization
	void Start ()
    {
        Debug.Log(gameObject.name);
        Debug.Log(miCamara.name);

        buscarGO = GameObject.Find("Esfera");

        cubos = GameObject.FindGameObjectsWithTag("Player");
        Debug.Log(cubos.Length);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
