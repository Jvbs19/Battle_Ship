using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuicideStunBehavior : EnemysBehavior
{
    void Start()
    {
        StartStatus();

        shipTransform = GameObject.Find("AllShip").transform;
    }


    void Update()
    {
        UpdateMovimenteSpeed();
        MoveToShip();
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.transform.CompareTag("Ship")) 
        {
            other.transform.GetComponent<ShipController>().EnableStun(status[level -1].stunTime);
            Dead();
        }
    }
}
