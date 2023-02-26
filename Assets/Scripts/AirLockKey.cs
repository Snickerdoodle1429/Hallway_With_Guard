using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirLockKey : MonoBehaviour
{
    public Component leftDoorCollider;
    public Component rightDoorCollider;
    public GameObject keyGone;



void OnTriggerStay(Collider other) 
{
    if (other.CompareTag("Player"))
    {
        leftDoorCollider.GetComponent<BoxCollider>().enabled = true;
        rightDoorCollider.GetComponent<BoxCollider>().enabled = true;
        keyGone.SetActive(false);
    }

        
}



}
