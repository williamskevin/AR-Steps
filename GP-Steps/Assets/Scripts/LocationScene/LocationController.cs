using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationController : MonoBehaviour
{
    //create new array for all the prizes to be spawned and a random prize
    public GameObject[] Prizes;
    GameObject randomPrize;
    //call to the avatar 
    public Transform MobileMaleFreeSimpleMovement1;

    //variable for timer to load map scene
    
    
    //call to the map object in the scene
    public Transform Map;

    //int for random prize
    public int randomprize;

    public int randomX;

    // create a vaariable and set it to 0;
    public float myTimer;

    //increment it with the time.delta 
    

    // if its time is greater than or equal to 1 hour 

        // then run script and reset it to zero 

    void Start()
    {
        MyRandomPrize();
    }

    void MyRandomPrize()
    {
        randomprize = Random.Range(0, Prizes.Length);
        //change the range values to change where it is spawned
        randomX = Random.Range(-15,15);
        randomPrize = Instantiate(Prizes[randomprize], new Vector3(randomX, Map.position.y, Map.position.z), Quaternion.identity) as GameObject;
    }
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(randomPrize.transform.position, MobileMaleFreeSimpleMovement1.position);
        myTimer += Time.deltaTime;
        //print(distance);
        if(myTimer >= 5f)
        {
            if (distance <= 5f)
            {
                Destroy(randomPrize);
                SceneManager.LoadScene("celebrate1");
                myTimer = 0;

            }
        }
        
        
    }
}
