using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameController gameController;
    public int score;
    void Start()
    {
        if(gameController == null)
        {
            Debug.Log("as");
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        score = gameController.SendScore();
    }
}
