using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHomework7Script : MonoBehaviour
{
    private Renderer rend;
    public float endurance = 100;
    public float damage = 25;
    private Vector3 position;

    //amount of health & damage taken per collision 

    void Start()
    {
        GameObject temp = GameObject.Find("bridge");
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

      
            // var MyHomework7Script_2 = transform.position += new Vector3(0, 10, 0);


         

        }
      }
    }

