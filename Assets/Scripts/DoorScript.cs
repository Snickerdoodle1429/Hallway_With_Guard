using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public static bool cardKey;
    public bool open;
    public bool close;
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
            if(close)
            {
                if(cardKey)
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        close = false;
                    }
                }
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                open = false;
                close = true;
            }
        }

        if(inTrigger)
        {
            if(open)
            {
                var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
                transform.rotation = newRot;
            }
            else
            {
                var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);
                transform.rotation = newRot;
            }
        }
    }
}
