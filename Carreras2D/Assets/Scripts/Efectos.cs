using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Efectos : MonoBehaviour
{
    public Image efecto;
    public string[] escenas;


	// Use this for initialization
	void Start ()
    {
        efecto.CrossFadeAlpha(0, 0.5f, false);
	}
	
    public void EfectoImagen(int s)
    {
        efecto.CrossFadeAlpha(1, 0.5f, false);
        StartCoroutine(CambiarEscena(escenas[s]));
    }

    IEnumerator CambiarEscena(string escena)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(escena);
    }
}
