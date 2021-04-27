using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleRollFX : MonoBehaviour
{
    public AudioSource playSound;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Track" && GetComponent<Rigidbody>().velocity.x != 0)
        {
            playSound.Play();
        }
        else
        {
            playSound.Stop();
        }
    }
}