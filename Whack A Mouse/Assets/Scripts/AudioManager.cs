using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource mainGameSoundBack;
    void Start()
    {
        StartCoroutine(FadeIn(mainGameSoundBack, 0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }

    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
    {
        float startVolume = 0.01f;

        audioSource.volume = 0;
        audioSource.Play();

        while (audioSource.volume < 0.5f)
        {
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.volume = 1f;
    }
}
