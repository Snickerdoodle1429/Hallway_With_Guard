using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animation leftOpen;
    public Animation rightOpen;


    void OnTriggerStay(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            leftOpen.Play();
            rightOpen.Play();
        }

        
    }
}
