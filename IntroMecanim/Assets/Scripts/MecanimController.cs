using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanimController : MonoBehaviour
{
    public Animator animController;

	// Use this for initialization
	void Start ()
    {
        animController = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Avanzar();
        Saltar();
        Viento();
        Escala();
	}

    void Avanzar()
    {
        if (Input.GetButtonDown("Fire1"))
            animController.SetBool("Avanzar", true);
        if (Input.GetButtonDown("Fire2"))
            animController.SetBool("Avanzar", false);
    }

    void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            animController.SetTrigger("Saltar");
    }

    void Viento()
    {
        if (Input.GetKeyDown(KeyCode.V))
            animController.SetFloat("Viento", 0.5f);
        if (Input.GetKeyDown(KeyCode.B))
            animController.SetFloat("Viento", 0.0f);
    }

    void Escala()
    {
        if (Input.GetKeyDown(KeyCode.S))
            animController.SetInteger("Escala", 2);
        if (Input.GetKeyDown(KeyCode.D))
            animController.SetInteger("Escala", 0);
    }
}
