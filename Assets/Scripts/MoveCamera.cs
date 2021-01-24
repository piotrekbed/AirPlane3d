using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float xAx = 0.0f;
    public float yAx = 5.0f;
    public float zAx = -5.0f;
    public bool grow = true;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        print(grow);
        if(grow==true && xAx <= (9.0f))
        {
            xAx += 0.1f;
        }
        if(grow==true && xAx >=(9.0f))
        {
            grow = false;
            xAx -= 0.1f;

        }
        if(grow == false && xAx >= (-9.0f))
        {
            xAx -= 0.1f;
        }
        if(grow== false && xAx <=(-9.0f))
        {
            grow = true;
        }
       
      
            transform.position= new Vector3(xAx, yAx, zAx);
        print("Os X: "+xAx);
    }
}
