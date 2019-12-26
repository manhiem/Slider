using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Movement move;
    public AudioClip otherClip;
    public AudioSource audio;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            move.enabled = false;
            

            audio.Play();
            audio.clip = otherClip;
            audio.Play();
            FindObjectOfType<GameManager>().EndGame();

        }
        
    }
}
