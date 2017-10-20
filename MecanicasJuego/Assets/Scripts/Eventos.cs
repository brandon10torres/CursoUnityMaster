using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventos : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("AWAKE");
    }
    
    void Start ()
    {
        Debug.Log("START");
    }
		
	void Update ()
    {
        Debug.Log("UPDATE");
    }

    void OnDisable()
    {
        Debug.Log("ON DISABLE");
    }

    void OnEnable()
    {
        Debug.Log("ON ENABLE");
    }

    private void OnMouseDown()
    {
        Debug.Log("ON MOUSE DOWN");
    }

    private void OnMouseEnter()
    {
        Debug.Log("ON MOUSE ENTER");
    }

    private void OnMouseExit()
    {
        Debug.Log("ON MOUSE EXIT");
    }

    private void OnMouseOver()
    {
        Debug.Log("ON MOUSE OVER");
    }
}
