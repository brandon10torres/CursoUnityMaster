using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    public Pared[] arregloParedes;


	// Use this for initialization
	void Start ()
    {
        arregloParedes = Object.FindObjectsOfType(typeof(Pared)) as Pared[];
        Debug.Log(arregloParedes.Length);
        Debug.Log(arregloParedes.ToString());
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
