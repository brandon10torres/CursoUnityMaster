using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectosSonido : MonoBehaviour
{
    public AudioClip[] efectos;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void SonidoChoque()
    {
        audio.clip = efectos[0];
        audio.Play();
    }

    public void SonidoMusica()
    {
        audio.clip = efectos[1];
        audio.Play();
    }
}
