using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryController : MonoBehaviour
{
    private float timeElapsed;
    private float timer = 10f;


    // Update is called once per frame
    void Update()
    {

        timeElapsed += Time.deltaTime;
        if (timeElapsed > timer)
        {
            SceneManager.LoadScene("Location-basedGame");
        }

    }
}
