using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorSwitch : MonoBehaviour
{

    public GameObject Door;

    private bool isOpen;

    public Animator anim;

    public bool IsOn;

    public GameObject Outline;

    // Start is called before the first frame update
    void Start()
    {
        Outline.SetActive(false);

        isOpen = false;
    }


    void OnMouseEnter()
    {
        if (!isOpen && IsOn)

        {
            Outline.SetActive(true);
        }
       
    }

        void OnMouseDown()
        {
        

        if (Input.GetMouseButton(0))
        {
            if (isOpen == false)
            {
                anim.SetTrigger("Open");
                isOpen = true;
                StartCoroutine(DelayedMethod());
                

                
            }

        }
    }

    IEnumerator DelayedMethod()
    {
        yield return new WaitForSeconds(0.2f);

        Destroy(Door);
    }

    

    void OnMouseExit()
    {
        
            Outline.SetActive(false);
        

    }

    private void Update()
    {
        if (!IsOn)
        {
            Outline.SetActive(false);
        }
    }

}
