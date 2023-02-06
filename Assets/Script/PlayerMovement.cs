using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jump = 1f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public int kills = 0;
    public GameObject WinText;

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        WinText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        /*if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }*/

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if(kills == 5)
        {
            transform.position = new Vector3(-185,2.5f,80);
        }

        if(kills == 10)
        {
            transform.position = new Vector3(-185,2.5f,10);
        }

        if(kills == 15)
        {
            transform.position = new Vector3(-150,20,-50);
        }

        if(kills == 20)
        {
            transform.position = new Vector3(-195,20,-90);
        }

        if(kills == 25)
        {
            transform.position = new Vector3(-155,20,-155);
        }
        if(kills == 30)
        {
            Time.timeScale = 0;
            WinText.SetActive(true);
        }
    }
        

    public void updateKill()
    {
        kills++;
        Debug.Log(kills);
    }
}