using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour
{
    public GameObject[] cubos;

	// Use this for initialization
	void Start ()
    {
        cubos = GameObject.FindGameObjectsWithTag("Player");
        StartCoroutine(ApagarCubos());
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Torres");
	}

    IEnumerator ApagarCubos()
    {
        yield return new WaitForSeconds(2.0f);
        cubos[0].SetActive(false);

        yield return new WaitForSeconds(2.0f);
        cubos[1].SetActive(false);

        yield return new WaitForSeconds(2.0f);
        cubos[2].SetActive(false);
    }
}
