using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTraslacion : MonoBehaviour
{
    private Transform miTransform;
    public float velocidad;
    public float velocidadRotacion;

    // Use this for initialization
    void Start ()
    {
        miTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        miTransform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        miTransform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
	}
}
