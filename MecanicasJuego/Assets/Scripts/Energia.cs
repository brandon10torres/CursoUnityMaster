using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energia : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {        
        if(other.GetComponent<Jugador>() != null)
        {
            //Destroy(this.gameObject);
            Debug.Log(other.name);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Jugador>() != null)
        {
            //Destroy(this.gameObject);
            Debug.Log(other.name);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Jugador>() != null)
        {
            //Destroy(this.gameObject);
            Debug.Log(other.name);
        }
    }
}

	
