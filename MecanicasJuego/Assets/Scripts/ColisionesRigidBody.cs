using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesRigidBody : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.GetComponent<Jugador>() != null)
        {
            Debug.Log(collision.collider.name);
        }
    }

}
