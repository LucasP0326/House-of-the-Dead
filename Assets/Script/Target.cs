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
    public GameObject player;
    public GameObject spawner;

    // Update is called once per frame
    void Update()
    {
        if(health <=0)
        {
            Destroy(gameObject);
            enemyKillCount ++;
            PlayerMovement playerMovement = player.gameObject.GetComponent<PlayerMovement>();
            playerMovement.updateKill();
            Debug.Log("Enemy killed");
        }

        if(enemyKillCount == 5)
        {
            levelClear = true;
            // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        }

        if(enemyKillCount >= 30)
        {
            winState = true;

            // Restart the game
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (loseState == true)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // this loads the currently active scene
                }
            }

        }
    }

    // "hits" the target for a certain amount of damage
    public void Hit(float damage)
    {
        health -= damage;
        Debug.Log(health);

        if (health <= 0f)
        
        {
            Debug.Log("STOP");

        }
    }
}
