using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    public GameObject player;
    public float speed = 3;
    public Vector3 target = new Vector3(-90, 1, -45);

    private void Update()
    {
        PlayerMovement playerMovement = player.gameObject.GetComponent<PlayerMovement>();
        if(playerMovement.kills >= 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

}
