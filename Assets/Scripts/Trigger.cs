using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public DoorSwitch ds;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ds.IsOn = true;
        }
    }
        void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")
            {
                ds.IsOn = false;
            }


        }
    
}