using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorKey : MonoBehaviour
{
    public Component leftDoorCollider;
    public Component rightDoorCollider;

    public GameObject deleteKey;

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            leftDoorCollider.GetComponent<BoxCollider>().enabled = true;
            rightDoorCollider.GetComponent<BoxCollider>().enabled = true;

            deleteKey.SetActive(false);

        }
        
    }

}
