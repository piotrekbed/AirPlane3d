using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSmiglo1 : MonoBehaviour
{
    public float MoveSmiglo = 90.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
       
        MoveSmiglo += 0.01f;
        transform.Rotate(MoveSmiglo,0, 0, Space.Self);      
      //  print(MoveSmiglo);
    }
}
