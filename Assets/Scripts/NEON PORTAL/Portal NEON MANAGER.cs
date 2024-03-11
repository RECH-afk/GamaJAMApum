using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalNEONManager : MonoBehaviour
{
    public GameObject kal;
    public GameObject kal1;

   

    

    public bool IsOpentp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        if (IsOpentp)
        {
            kal.SetActive(true);
            kal1.SetActive(true);
         
        }
        else
        {
            kal.SetActive(false);
            kal1.SetActive(false);
            
        }

      
    }
}
