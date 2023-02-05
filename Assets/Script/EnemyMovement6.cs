using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement6 : MonoBehaviour
{
    public GameObject player;
    public float speed = 3;
    public Vector3 target = new Vector3(-17, 0, -3);

    private void Update()
    {
        PlayerMovement playerMovement = player.gameObject.GetComponent<PlayerMovement>();
        if(playerMovement.kills >= 25)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

}
