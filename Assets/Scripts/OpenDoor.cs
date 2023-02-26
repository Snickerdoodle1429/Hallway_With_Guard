using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
  public Animation leftHinge;
  public Animation rightHinge;

 void OnTriggerEnter(Collider other) 
 {
    if (other.CompareTag("Player"))
    {
        leftHinge.Play();
        rightHinge.Play();
    }
    
 }
}
