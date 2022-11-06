using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    // Start is called before the first frame update
    public string url= "https://www.google.com/webhp?hl=es-419&sa=X&ved=0ahUKEwjwsdaNlcn6AhXeRTABHWHqCz4QPAgI";
    public void open()
    {
        Application.OpenURL(url);
    }

    
}
