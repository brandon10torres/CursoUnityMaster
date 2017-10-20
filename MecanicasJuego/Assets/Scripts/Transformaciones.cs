using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformaciones : MonoBehaviour
{

    private Transform thisTransform = null;

    public GameObject otroGO;
    Transform transformGO;


	// Use this for initialization
	void Start ()
    {
        thisTransform = GetComponent<Transform>();
        //Mover componente
        thisTransform.position = new Vector3(2, 2, 2);

        otroGO = GameObject.Find("CuboRojo");
        transformGO = otroGO.GetComponent<Transform>();

        transformGO.position = new Vector3(-2, -2, -2);
    }
	
	// Update is called once per frame
	void Update ()
     {
		
	}
}
