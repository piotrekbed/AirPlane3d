using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlainStaring : MonoBehaviour
{

        float timeLeft;
        float visibleCursorTimer = 10.0f;
        float cursorPosition;
        bool catchCursor = true;
        float xAngel = 0.1f;
        private void OnMouseEnter()
        {
            xAngel += 0.1f;

          //  transform.Rotate(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0f, Space.Self);
           // print(Input.GetAxis("Mouse X"));
        }
        void Update()
        {
            /*  if (catchCursor)
              {
                  catchCursor = false;
                  cursorPosition = Input.GetAxis("Mouse X");
              }
              if (Input.GetAxis("Mouse X") == cursorPosition)
              {
                  print("Mouse stop");
                  timeLeft -= Time.deltaTime;
                  if (timeLeft < 0)
                  {
                      timeLeft = visibleCursorTimer;
                      Cursor.visible = false;
                      catchCursor = true;
                  }
              }
              else
              {
                  timeLeft = visibleCursorTimer;
                  Cursor.visible = true;
              }*/

          //  transform.Rotate(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0f, Space.Self);
          //  print(Input.GetAxis("Mouse X"));

     
        }
  }


