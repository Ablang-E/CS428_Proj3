using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound1Script : MonoBehaviour
{
    public AudioSource playSound;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
            if (!playSound.isPlaying) {
            Debug.Log("Triggered");
            anim.SetTrigger("triggered");
            //animation.SetBool("triggered", true);
            playSound.Play();
            
        }        
    }

    void OnTriggerExit(Collider other) {
        //animation.SetBool("triggered", false);
    }
}
