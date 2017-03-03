using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHomework7Script : MonoBehaviour
{
    MyHomework7Script_2 Object = new MyHomework7Script_2();
    private Renderer rend;
    public float endurance = 100;
    public float damage = 25;
    //amount of health & damage taken per collision 

   
    void Start()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name != "impact")
        {
            endurance = endurance - damage;
            transform.localScale += new Vector3(-1, 0, -1); 
            //decrease the size of the target
        }
            if (endurance < 0)
            {
                Destroy(gameObject);
            //upon reaching 0, target is destroyed
            Object.transform.localPosition += new Vector3(0, 5, 0);

            //Adam, I was trying to get a bridge to raise as the target is destroyed to get the player to the next level.. but i cannot seem to call upon my bridge properly
        }
        }
    }

