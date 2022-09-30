using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
    }
    public bool gravar, ir, y = true;
    public string names;
    int W;
    guardarA este;
    public float a = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gravar)
        {
            gravar = true;
            foreach (var device in Microphone.devices)
            {
                names = device;
                Debug.Log("Name: " + device);
            }


            if (gravar)
            {

                AudioSource audioSource = GetComponent<AudioSource>();
                audioSource.clip = Microphone.Start(names, false, 1, 44100);
                if (y)
                {
                    a = Time.deltaTime;
                    y = false;
                }
                if (!y&& a*2< Time.deltaTime)
                {
                    Microphone.End(names);
                    este.we = audioSource;
                }
                ir = audioSource.isPlaying;
                audioSource.Play();

            }


        }
    }
}
