using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NeonPortaldis : MonoBehaviour
{
    public PortalNEONManager pmm;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            pmm.IsOpentp = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
