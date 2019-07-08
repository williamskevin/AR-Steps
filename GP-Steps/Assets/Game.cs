using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    public const string WEB_URL = "www.google.com";
   
    void Start()
    {
        StartCoroutine(RestClient.Instance.Get(WEB_URL));
    }

  
}
