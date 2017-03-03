using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript4 : MonoBehaviour {

    public float parameter1 = 100;
	//amount of Cylinder health
    public float parameter2 = 10;
	//amount of damage done per collision 

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter(Collision collision)
    {
        print(collision.collider.name);
        if(collision.collider.name != "Terrain")
        {
			//prints object being collided with
            parameter1 = parameter1 - parameter2;
            print(parameter1);
			//prints the current cylinder health after collision
        }
        if(parameter1 < 0)
        {
            Destroy(gameObject);
			//upon reaching 0, cylinder is destroyed
        }
    }
}
