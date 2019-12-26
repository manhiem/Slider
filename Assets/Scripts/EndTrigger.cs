using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gamemanager;
    public Animator anim;
    public AudioClip otherClip;
    public AudioSource audio;
    void OnTriggerEnter()
    {
        audio.Play();
        audio.clip = otherClip;
        audio.Play();
        gamemanager.CompleteLevel();
    }

    
}
