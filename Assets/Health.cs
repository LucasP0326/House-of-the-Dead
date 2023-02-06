using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
    static float health = 3f;
    public GameObject player;
    public GameObject enemies;
    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log(health);
        if(health<= 0f)
        {
            Debug.Log("stop");
        }
    }
    void Update()
        {
            float distance = Vector3.Distance(player.transform.position, enemies.transform.position);
            if(distance <= 5 && health >= 1)
            {
                TakeDamage(1);
            }
        }
}