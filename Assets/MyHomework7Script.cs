using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHomework7Script : MonoBehaviour
{
    private Renderer rend;
    public float endurance = 100;
    public float damage = 25;
    //amount of health & damage taken per collision 

    private Vector3 position;
    public GameObject bridge;


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
            bridge.transform.position += new Vector3(0, 14, 0);
            //upon reaching 0, target is destroyed, and bridge is raised.





        }
    }
    }

