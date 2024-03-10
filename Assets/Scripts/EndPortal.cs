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
            StartCoroutine(ResetWait());
        }
    }

    
        

    

    IEnumerator ResetWait()
    {
        dm.entropy *= 2 * Time.deltaTime;
        yield return new WaitForSeconds(1);
        Debug.Log("ДУРА БЛЯТЬ ВРУБАЙСЯ УËБА НАХУЙ Z");
       
        dm.Reset();
    }
}