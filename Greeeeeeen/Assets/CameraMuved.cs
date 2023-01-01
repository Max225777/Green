using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMuved : MonoBehaviour
{
    public bool Pov = false;
    public Vector3 ToRot;
    public int SpeedS;

    /*public float angle = 0;
    public float Speed = 1;
    public float radius = 0.5f;
    public bool IsC = false;
    public Vector2 CachedCenter;*/

    void FixedUpdate()
    {
        /*if (IsC)
        {
            angle += Time.deltaTime;
            var x = Mathf.Cos(angle * Speed) * radius;
            var y = Mathf.Sin(angle * Speed) * radius;
            transform.position = new Vector2(x, y ) + CachedCenter - new Vector2(radius, 1.5f);
        }
        else
        {
            angle = 0;
            CachedCenter = transform.position;
            var x = transform.position.x;
            var y = transform.position.y;

            x += 0.5f * Time.deltaTime;

            transform.position = new Vector2(x, y );
        }*/
        this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(ToRot), SpeedS);
        //transform.RotateAround(this.transform.position, Vector3.up, 20  * Time.deltaTime);


        if(Input.GetKeyUp(KeyCode.Space))
            Pov = !Pov;

        if(Pov == false)
            ToRot.y = 180;
        else 
            ToRot.y = 360;

    }
}
