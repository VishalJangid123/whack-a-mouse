using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text score_text;
    public GameObject saveManager;
    private SaveManger saveMangerScript;
    
    void Awake()
    {
        
    }

    void Start()
    {
        saveManager = GameObject.Find("SaveManager");
        if(saveManager == null)
        {
            Debug.Log("Game Controller not found");
        }
        saveMangerScript = saveMangerScript.GetComponent<SaveManger>();
        if (saveMangerScript == null)
        {
            Debug.Log("Game Controller Script not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = saveMangerScript.score.ToString();
    }
}
