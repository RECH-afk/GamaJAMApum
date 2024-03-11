using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeonPortaltp : MonoBehaviour
{
    public Transform destinationPortal;

    public PortalNEONManager pmm;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = destinationPortal.position;
            pmm.IsOpentp = false;
        }
        
    }
    

 
}
