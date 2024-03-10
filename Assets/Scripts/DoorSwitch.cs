using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{

    public GameObject Door;

    private bool isOpen;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            if (isOpen == false)
            {
                anim.SetTrigger("Open");
                Destroy(Door);
                isOpen = true;
            }
                
        }
    }

}
