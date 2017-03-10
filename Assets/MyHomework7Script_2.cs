using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyHomework7Script_2 : MonoBehaviour {
    public object myvar;

    // Use this for initialization
    void Start () {
      

    } 
	
	// Update is called once per frame
	void Update () {
     if (Input.GetKey (KeyCode.Q))
        {
            transform.Translate(0, 1, 0);
        }
    }
}
