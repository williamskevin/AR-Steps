using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class API : MonoBehaviour
{
    public const string URL = "www.google.com";
    public Text responseText;
    public void Request()
    {
        UnityWebRequest request = new UnityWebRequest(URL);

    }
    private IEnumerator OnResponse(UnityWebRequest req)
    {
        yield return req;

        responseText.text = req.downloadHandler.text;
        
    }
}
