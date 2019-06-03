using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("MazeRunner");
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<RectTransform>().position = new Vector3(player.GetComponent<RectTransform>().position.x, 
                                                                        player.GetComponent<RectTransform>().position.y, 
                                                                        gameObject.GetComponent<RectTransform>().position.z);
    }
}
