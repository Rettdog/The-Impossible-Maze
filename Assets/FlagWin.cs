using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlagWin : MonoBehaviour {
    //GameObject go;
    ParticleSystem ps; 
    // Use this for initialization
    void Start() {
        //go = GameObject.Find("Flag");
        //ps = gameObject.GetComponentInChildren<"Particle System">
       // ps.startSize = 1;
        //ps.Play();

    }

    // Update is called once per frame
    void Update() {
       // if(gameObject.GetComponent<RectTransform>().position.x- gameObject.
    }

    void OnTriggerEnter(Collider collider){
       Debug.Log("FDSF");
        //ps.startSize = 1f;
    }

    
}
//.GetComponent<ParticleSystem>().main.startSize=0.25f;