using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleFade : MonoBehaviour
{
    // Start is called before the first frame update
    private CanvasGroup fadeCanvasGroup;
    public GameObject canvasToHide;
    bool checkForFade = true;
    void Start()
    {
        fadeCanvasGroup = FindObjectOfType<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (checkForFade)
        {
            fadeCanvasGroup.alpha = 1 - Time.timeSinceLevelLoad * 0.5f;
        }
       

        if(fadeCanvasGroup.alpha == 0)
        {
            canvasToHide.SetActive(false);
            checkForFade = false;
        }
        /*if (Time.time < 2)
        {
            fadeCanvasGroup.alpha = 1 - Time.time;
        }*/
    }
}
