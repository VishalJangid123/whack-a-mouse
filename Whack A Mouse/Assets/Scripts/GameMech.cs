using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMech : MonoBehaviour
{
    // Start is called before the first frame update
    public SpatulaController spc;
    
    void Start()
    {
       
    }


    void Update()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse clicked");

            Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("Something Hit");
                //MoveSpactula(raycastHit.point);
                spc.target = raycastHit.point;
                spc.startAnimation = true;

                //OR with Tag

                if (raycastHit.collider.CompareTag("Mouse_Hit"))
                {
                    
                    //Destroy(raycastHit.collider.gameObject);
                }
            }
        }
    
        /////
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
            {
                Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit raycastHit;
                if (Physics.Raycast(raycast, out raycastHit))
                {
                    Debug.Log("Something Hit");
                //MoveSpactula(raycastHit.point);
                spc.target = raycastHit.point;
                spc.startAnimation = true;
               
                 
                }
            }
        }
    

   
}
