using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiceController : MonoBehaviour
{
    // Start is called before the first frame update

    int timeToMoveUp;
    float timeToWait;
    float timer;
    bool isMoving = true, isMovingDown = false;
    void Start()
    {
        timeToMoveUp = UnityEngine.Random.Range(1, 3);
        timeToWait = UnityEngine.Random.Range(0.5f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        MoveThis();
    }

    private void MoveThis()
    {
        if (isMoving)
        {
            if (Mathf.Round(timer) == timeToMoveUp)
            {
                timer = 0;
                StartCoroutine("moveDown");
            }
            else { transform.Translate(Vector3.forward * 0.001f); }
           
        }
        if(isMovingDown)
        {
            transform.Translate(Vector3.forward * -0.001f);
            if(Mathf.Round(timer) == timeToMoveUp)
            {
                Destroy(this.gameObject);
            }
        }

    }
   IEnumerator moveDown()
    {
        isMoving = false;
        yield return new WaitForSeconds(timeToWait);
        isMovingDown = true;
        timer = 0;
        
    }
}
