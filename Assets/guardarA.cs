using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardarA : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource we;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void iniciar()
    {
        AudioSource we = GetComponent<AudioSource>();
        we.Play();
    }
}
