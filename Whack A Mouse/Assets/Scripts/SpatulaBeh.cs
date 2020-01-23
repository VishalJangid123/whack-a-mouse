using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatulaBeh : MonoBehaviour
{
    // Start is called before the first frame update

    public GameController gameController;
    public AudioClip[] spatulaHitSound;
    public AudioSource spatulaAudioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
       

        if (col.gameObject.tag == "Mouse_Hit")
        {
            spatulaAudioSource.clip = spatulaHitSound[Random.Range(0, spatulaHitSound.Length)];
            spatulaAudioSource.Play();
            Destroy(col.gameObject);
            gameController.score += 1;
        }
    }
   /* private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == "Mouse_Hit") {
            Destroy(collision.gameObject);
        } 
    }*/
}
