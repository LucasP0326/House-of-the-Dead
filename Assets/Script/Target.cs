using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Target : MonoBehaviour
{
    public float health;
    public static int enemyKillCount;

    bool winState;
    bool loseState;
    bool levelClear;
    public TextMeshPro winText;
    public TextMeshPro loseText;

    // Update is called once per frame
    void Update()
    {
        if(health <=0)
        {
            Destroy(gameObject);
            enemyKillCount ++;
            Debug.Log("Enemy killed" + enemyKillCount);
        }

        if(enemyKillCount >= 15)
        {
            levelClear = true;
        }

        if(enemyKillCount >= 30)
        {
            winState = true;
        }
    }

    // "hits" the target for a certain amount of damage
    public void Hit(float damage)
    {
        health -= damage;
    }
}
