using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timer_text;
    public Text hit_score;
    public int score=0;
    float timer = 50;
    public AudioSource GameSoundInback;

    public GameObject[] objectsToHide;
    public GameObject[] objectsToShow;
 
    void Start()
    {
        timer_text.text = "50";
        for (int i = 0; i < objectsToShow.Length; i++)
        {
            objectsToShow[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        timer -= Time.deltaTime;
        timer_text.text = Mathf.Round(timer).ToString();
        hit_score.text = Mathf.Round(score).ToString();


        if (Mathf.Round(timer) == 2)
        {
            StartCoroutine(AudioManager.FadeOut(GameSoundInback, 0.5f));
        }
        if (Mathf.Round(timer) == 0)
        {
            for( int i=0;i< objectsToHide.Length; i++)
            {
                objectsToHide[i].SetActive(false);
            }
            for (int i = 0; i < objectsToShow.Length; i++)
            {
                objectsToShow[i].SetActive(true);
            }
            //UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");
        }
    }

    public int SendScore()
    {
        return score;
    }
}
