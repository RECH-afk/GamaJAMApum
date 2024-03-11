using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformforCube : MonoBehaviour
{
    public GameObject Door;

    private void Start()
    {
        Door.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            Door.SetActive(false);
        }
    }
  
}
