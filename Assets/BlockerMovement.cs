using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerMovement : MonoBehaviour {
    GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("MazeRunner");
    }
	
	// Update is called once per frame
	void Update () {

        Move(player.GetComponent<RectTransform>().position);
	}
     public void Move(Vector3 positioner)
    {
        //print("blocker move");
        gameObject.GetComponent<RectTransform>().position = positioner;
    }
}
