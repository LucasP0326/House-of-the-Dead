using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Health : MonoBehaviour
{
    public GameObject LoseText;

    static float health = 500f;
    public GameObject player;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    public GameObject enemy9;
    public GameObject enemy10;
    public GameObject enemy11;
    public GameObject enemy12;
    public GameObject enemy13;
    public GameObject enemy14;
    public GameObject enemy15;
    public GameObject enemy16;
    public GameObject enemy17;
    public GameObject enemy18;
    public GameObject enemy19;
    public GameObject enemy20;
    public GameObject enemy21;
    public GameObject enemy22;
    public GameObject enemy23;
    public GameObject enemy24;
    public GameObject enemy25;
    public GameObject enemy26;
    public GameObject enemy27;
    public GameObject enemy28;
    public GameObject enemy29;
    public GameObject enemy30;


    public void TakeDamage(float amount)
    {
        health -= amount;

        Debug.Log(health);

        if (health <= 0f)
        {
            Debug.Log("STOP");
            Time.timeScale = 0;
            LoseText.SetActive(true);
        }
    }
    
        void Start()
    {
        LoseText.SetActive(false);
    }

    void Update()
    {
        if (enemy1 != null)
        {
            float distance1 = Vector3.Distance(player.transform.position, enemy1.transform.position);
            if (distance1 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy2 != null)
        {
            float distance2 = Vector3.Distance(player.transform.position, enemy2.transform.position);
            if (distance2 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy3 != null)
        {
            float distance3 = Vector3.Distance(player.transform.position, enemy3.transform.position);
            if (distance3 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy4 != null)
        {
            float distance4 = Vector3.Distance(player.transform.position, enemy4.transform.position);
            if (distance4 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy5 != null)
        {
            float distance5 = Vector3.Distance(player.transform.position, enemy5.transform.position);
            if (distance5 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy6 != null)
        {
            float distance6 = Vector3.Distance(player.transform.position, enemy6.transform.position);
            if (distance6 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy7 != null)
        {
            float distance7 = Vector3.Distance(player.transform.position, enemy7.transform.position);
            if (distance7 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy8 != null)
        {
            float distance8 = Vector3.Distance(player.transform.position, enemy8.transform.position);
            if (distance8 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy9 != null)
        {
            float distance9 = Vector3.Distance(player.transform.position, enemy9.transform.position);
            if (distance9 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy10 != null)
        {
            float distance10 = Vector3.Distance(player.transform.position, enemy10.transform.position);
            if (distance10 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy11 != null)
        {
            float distance11 = Vector3.Distance(player.transform.position, enemy11.transform.position);
            if (distance11 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy12 != null)
        {
            float distance12 = Vector3.Distance(player.transform.position, enemy12.transform.position);
            if (distance12 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy13 != null)
        {
            float distance13 = Vector3.Distance(player.transform.position, enemy13.transform.position);
            if (distance13 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy14 != null)
        {
            float distance14 = Vector3.Distance(player.transform.position, enemy14.transform.position);
            if (distance14 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy15 != null)
        {
            float distance15 = Vector3.Distance(player.transform.position, enemy15.transform.position);
            if (distance15 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy16 != null)
        {
            float distance16 = Vector3.Distance(player.transform.position, enemy16.transform.position);
            if (distance16 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy17 != null)
        {
            float distance17 = Vector3.Distance(player.transform.position, enemy17.transform.position);
            if (distance17 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy18 != null)
        {
            float distance18 = Vector3.Distance(player.transform.position, enemy18.transform.position);
            if (distance18 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy19 != null)
        {
            float distance19 = Vector3.Distance(player.transform.position, enemy19.transform.position);
            if (distance19 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy20 != null)
        {
            float distance20 = Vector3.Distance(player.transform.position, enemy20.transform.position);
            if (distance20 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy21 != null)
        {
            float distance21 = Vector3.Distance(player.transform.position, enemy21.transform.position);
            if (distance21 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy22 != null)
        {
            float distance22 = Vector3.Distance(player.transform.position, enemy22.transform.position);
            if (distance22 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy23 != null)
        {
            float distance23 = Vector3.Distance(player.transform.position, enemy23.transform.position);
            if (distance23 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy24 != null)
        {
            float distance24 = Vector3.Distance(player.transform.position, enemy24.transform.position);
            if (distance24 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy25 != null)
        {
            float distance25 = Vector3.Distance(player.transform.position, enemy25.transform.position);
            if (distance25 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy26 != null)
        {
            float distance26 = Vector3.Distance(player.transform.position, enemy26.transform.position);
            if (distance26 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy27 != null)
        {
            float distance27 = Vector3.Distance(player.transform.position, enemy27.transform.position);
            if (distance27 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy28 != null)
        {
            float distance28 = Vector3.Distance(player.transform.position, enemy28.transform.position);
            if (distance28 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy29 != null)
        {
            float distance29 = Vector3.Distance(player.transform.position, enemy29.transform.position);
            if (distance29 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
        if (enemy30 != null)
        {
            float distance30 = Vector3.Distance(player.transform.position, enemy30.transform.position);
            if (distance30 <= 5 && health >=1)
            {
                TakeDamage(1);
            }
        }
    }
}