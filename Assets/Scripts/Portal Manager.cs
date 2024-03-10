using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{

    public bool IsStart = true;

   

    public GameObject AStartPort;
    public GameObject AEndPort;

    public GameObject BStartPort;
    public GameObject BEndPort;

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        if (IsStart)
        {
            AEndPort.SetActive(true);
            AStartPort.SetActive(false);

            BEndPort.SetActive(true);
            BStartPort.SetActive(false);

            
        }
        else
        {
            BEndPort.SetActive(false);
            BStartPort.SetActive(true);

            AEndPort.SetActive(false);
            AStartPort.SetActive(true);
           
        }
    }
}
