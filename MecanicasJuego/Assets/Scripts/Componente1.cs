using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{

    public Transform tranformCamara;

    public BoxCollider miCollider;


    // Use this for initialization
    void Start()
    {
        Debug.Log(gameObject.transform.position.x);

        miCollider = GetComponent<BoxCollider>();
        miCollider.enabled = false;
        Debug.Log(miCollider.enabled);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
