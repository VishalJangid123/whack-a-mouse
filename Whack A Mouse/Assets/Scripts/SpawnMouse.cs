using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMouse : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] spawnPoints;
    public GameObject mouseModal;
    bool spawnAllowed = true;
    int pointToChoose = 0, lastPointChoosen = 0;
    Transform pointChoose;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int numberOfMouse = GameObject.FindGameObjectsWithTag("Mouse_Hit").Length;
        if(numberOfMouse <= 2)
        {
            spawnAllowed = true;
        }
        else
        {
            spawnAllowed = false;
        }

        if (spawnAllowed)
        {
            chooseSpawnPoint();
            Instantiate(mouseModal,pointChoose);
            spawnAllowed = false;
        }
    }
    void chooseSpawnPoint()
    {
        pointToChoose = Random.Range(0, spawnPoints.Length);
        if (pointToChoose == lastPointChoosen)
        {
            chooseSpawnPoint();
        }
        else
        {
            pointChoose = spawnPoints[pointToChoose].transform;
            lastPointChoosen = pointToChoose;
        }

            
      
       
    }


}
