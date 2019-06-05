using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    [SerializeField] Vector3 position = Pose.identity.position;
    BlockerMovement blocky;
    Vector2 finger;
    // Use this for initialization
    void Start () {
        // blocky = 
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            for (int i = 0; i < 4; i++) { 
            gameObject.transform.Translate(0, (float).04, 0);
        }
        }
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            for (int i = 0; i < 4; i++) { 
            gameObject.transform.Rotate(0, 0, .7f);
        }
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            for (int i = 0; i < 4; i++)
            {
                gameObject.transform.Rotate(0, 0, -.7f);
            }
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            for (int i = 0; i < 4; i++)
            {
                gameObject.transform.Translate(0, (float)-.04, 0);
            }
        }
        foreach(Touch touch in Input.touches)
        {

            if (touch.position.x < Screen.width/2)
            {
                gameObject.transform.eulerAngles.Set(0,0,Mathf.Atan((touch.position.y-Screen.height/2)/(touch.position.x - Screen.width / 2)));           }
            else
            {

            }
            //left
            /*if (touch.position.x < (Screen.width / 2)){
                gameObject.transform.Rotate(0, 0, -2);
                //gameObject.transform.Translate(0, (float).063, 0);
            }
            //right
            if (touch.position.x > (Screen.width / 2))
            {
                gameObject.transform.Rotate(0, 0, 2);
                //gameObject.transform.Translate(0, (float).063, 0);
            }*/
            //bottom
            /*if (touch.position.y < (Screen.height / 2))
            {
                //gameObject.transform.Rotate(0, 0, -1);
                gameObject.transform.Translate(0, (float)-.1, 0);
                if (touch.position.x > (Screen.width / 2))
                {
                    gameObject.transform.Rotate(0, 0, -2);
                    //gameObject.transform.Translate(0, (float).063, 0);
                }
                //right
                if (touch.position.x < (Screen.width / 2))
                {
                    gameObject.transform.Rotate(0, 0, 2);
                    //gameObject.transform.Translate(0, (float).063, 0);
                }
            }
            //top
            if (touch.position.y > (Screen.height / 2))
            {
                //gameObject.transform.Rotate(0, 0, 1);
                gameObject.transform.Translate(0, (float).1, 0);
                //left
                if (touch.position.x > (Screen.width / 2))
                {
                    gameObject.transform.Rotate(0, 0, 2);
                    //gameObject.transform.Translate(0, (float).063, 0);
                }
                //right
                if (touch.position.x < (Screen.width / 2))
                {
                    gameObject.transform.Rotate(0, 0, -2);
                    //gameObject.transform.Translate(0, (float).063, 0);
                }
            }*/
        }

        //gameObject.transform.Translate(Touch.rawPosition.x);
        // || Input.compass.magneticHeading.Equals("south")
        /*  if (Input.mousePosition.x>500)
          {
              gameObject.transform.Translate(0, (float).25, 0);
          }
          if (Input.GetKey("left"))
          {
              gameObject.transform.Rotate(0, 0, 4);
          }
          if (Input.GetKey("right"))
          {
              gameObject.transform.Rotate(0, 0, -4);
          }
          if (Input.GetKey("down"))
          {
              gameObject.transform.Translate(0, (float)-.25, 0);
          }*/
        //blocky.Move(position);
    }

    void fizedUpdate()
    {

    }
}
