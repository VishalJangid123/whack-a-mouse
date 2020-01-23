using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatulaController : MonoBehaviour
{
    public GameObject spatula;
    //public Transform target;
    public Transform intial;
    float minAngle = -90, maxAngle = -130;
    float speed = 2;
    bool spatulaMoving = true, reachDestination;
    public bool startAnimation = false;
    public Vector3 target;


    public GameObject particleSystem_custom;
    // Update is called once per frame
    void Update()
    {
        
        if (startAnimation)
        {
            StartAnim();
        }
    }

    void StartAnim()
    {
        if (spatulaMoving || reachDestination == false)
        {
            MoveSpactula(target);
        }
        if (reachDestination)
        {
            ResetSpactulaPosition();
        }


        if (spatula.transform.localEulerAngles.x == 270)
        {

            spatulaMoving = false;

        }
    }
    void MoveSpactula(Vector3 target)
    {
        
        if (spatula.transform.position == target)
        {
            GameObject temp = Instantiate(particleSystem_custom, target, Quaternion.identity);
            Destroy(temp, 0.8f);
            Debug.Log("created");
            reachDestination = true;
          
        }
        float step = speed * Time.deltaTime;
        spatula.transform.position = Vector3.MoveTowards(spatula.transform.position, target, step*3);

        /*float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
        transform.eulerAngles = new Vector3(angle, 0, 0);*/
        Quaternion newEulerAngle = Quaternion.Euler(-90, 0, 0);
        spatula.transform.rotation = Quaternion.RotateTowards(spatula.transform.rotation, newEulerAngle, step * 15 * 3);



    }

    void ResetSpactulaPosition()
    {
        if (spatula.transform.position == intial.position)
        {
            reachDestination = false;
           
            startAnimation = false;
        }

        float step = speed * Time.deltaTime;
        spatula.transform.position = Vector3.MoveTowards(spatula.transform.position, intial.position, step * 3);
        
        /*float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
        transform.eulerAngles = new Vector3(angle, 0, 0);*/
        Quaternion newEulerAngle = Quaternion.Euler(-130, 0, 0);
        spatula.transform.rotation = Quaternion.RotateTowards(spatula.transform.rotation, newEulerAngle, step * 15 * 3);

    }
}
