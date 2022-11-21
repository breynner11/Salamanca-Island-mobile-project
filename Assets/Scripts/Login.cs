using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using TMPro;

public class Login : MonoBehaviour
{
    public string linkapi;
    public int num;
    public Text textoerror;
    public TextMeshProUGUI titulo;
    public TextMeshProUGUI tema;
    private List<infolink> listaDeLinkss;
    void Start()
    {
        StartCoroutine(GetColegiosList());
    }

    public void OnLoginBtnClicked()
	{
		Debug.Log("click!");
        Application.OpenURL(listaDeLinkss[num-1].url_dir);
    }

    IEnumerator GetColegiosList()
    {
        string json;
        UnityWebRequest request = UnityWebRequest.Get("https://epics-si-api.onrender.com/api/task/1/links");
        yield return request.SendWebRequest();

        if (request.isNetworkError)
        {
            textoerror.text = "Comprueba tu conexión a Internet";
            Debug.Log(request.error);
        }
        else
        {
            string content = System.Text.Encoding.UTF8.GetString(request.downloadHandler.data);
            listaDeLinkss = JsonConvert.DeserializeObject<List<infolink>>(content);
            Debug.Log(listaDeLinkss);
            Debug.Log(listaDeLinkss[num-1].tema);
            titulo.text = "Help link N°"+listaDeLinkss[num - 1].id_link;
            tema.text = listaDeLinkss[num - 1].tema;


        }
    }

    
}
public class LinkListObject
{
    public List<infolink> infodelinks;
}
public class infolink
{
    public int id_link;
    public string tema;
    public string url_dir;
    public int id_task;
}


