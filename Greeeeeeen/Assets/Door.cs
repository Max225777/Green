using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool a,b;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        /*
        if(a == true)
            b = false;

        if(b == true)
            a = false;
        */

        if(a == true)
            OpenLeftDoor();
            
        if(b == true)
            ClouLeftDoor();
    }
    public void OpenLeftDoor() 
    {
        anim.SetBool("Open",true);
        anim.SetBool("Clou",false);
        //b = false;
    }
    public void ClouLeftDoor() 
    {
        anim.SetBool("Open",false);
        anim.SetBool("Clou",true);
        //a = false;
    }
}
