using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPortal : MonoBehaviour
{
    public Transform destinationPortal;

    public PortalManager pm;

    public Datamosh dm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = destinationPortal.position;
            pm.IsStart = true;
            dm.Glitch();

        }
    }
}
