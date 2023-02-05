using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Target : MonoBehaviour
{
    public float health;
    private float enemyKillCount;

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
            Debug.Log("Enemy killed");
        }

        if(enemyKillCount >= 15)
        {
            levelClear = true;
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
            SceneManager.LoadScene("Game 1");
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
        Debug.Log(health);

        if (health <= 0f)
            Destroy(gameObject;
        {
            Debug.Log("STOP");

        }
    }
}
