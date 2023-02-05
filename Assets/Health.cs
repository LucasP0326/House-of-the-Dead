using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
    static float health = 3f;
    public GameObject player;

    public void TakeDamage(float amount)
    {
        health -= amount;

        Debug.Log(health);

        if (health <= 0f)
        {
            Debug.Log("STOP");
           
        }
    }
}