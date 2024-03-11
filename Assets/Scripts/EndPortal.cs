using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class EndPortal : MonoBehaviour
{
    public Datamosh dm;
    public PortalManager pm;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pm.IsStart = false;
            dm.Reset();
        }
    }

    
        

    

   
   
 
}