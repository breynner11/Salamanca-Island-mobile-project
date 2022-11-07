using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour
{
    public string Escena;
    // Start is called before the first frame update
    public void CargarEscenaa()
    {
        //Entrar al nivel correspondiente
        SceneManager.LoadScene(Escena);
    }

    // Update is called once per frame
 
}
