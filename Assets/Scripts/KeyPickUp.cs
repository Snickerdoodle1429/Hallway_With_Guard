using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    public bool inTrigger;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                DoorScript.cardKey = true;
                Destroy(this.gameObject);
            }
        }
    }
}
