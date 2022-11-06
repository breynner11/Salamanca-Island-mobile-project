using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardarA : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource we;
    public AudioClip este;
    public float[] samples;
    public int chanel, frecuencia;
    void Start()
    {

    }

    // Update is called once per frame
    public void guardar(AudioSource este)
    {
        AudioSource we = GetComponent<AudioSource>();
        we.clip = AudioClip.Create("uno", este.clip.samples, este.clip.channels, este.clip.frequency, false);
    }

}
