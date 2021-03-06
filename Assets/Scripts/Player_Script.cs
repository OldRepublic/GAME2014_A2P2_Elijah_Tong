﻿/***
Name:Elijah Tong
Student Number: 101126281
Source File: Player_Script.cs
Last Modified: 2020-12-14
Description: This script will move the player in the direction of the joystick and respawn the player on contact with the death plane. This script also provides the functionality to the jump pad platform by increasing your jump force while
collision is detected between you the player and the platform.
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    public Joystick joystick;
    public float JS_Horizontal_Sensitivity;// JS == joystick
    public float JS_Vertical_Sensitivity;
    public float Horizontal_Force;
    public float Vertical_Force;
    public bool isGrounded;
    public Transform SpawnPoint;


    private Rigidbody2D RigidBody2d;
    public GameObject MovePlatform;
    bool LastDir_Right = true;
    float JumpPad_Force;

    private Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        RigidBody2d = GetComponent<Rigidbody2D>();
        
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()// as you might guess the function for moving the player
    {
        if(isGrounded)
        {// Animator states: 0 = idle right, 1 = idle left, 2 = run left, 3 = run right, 4 = jump left, 5 = jump right
            if (joystick.Horizontal > JS_Horizontal_Sensitivity)
            {//Moving right
                RigidBody2d.AddForce(Vector2.right * Horizontal_Force * Time.deltaTime);
                Animator.SetInteger("AnimationState", 3);
                LastDir_Right = true;

                if (joystick.Vertical > JS_Vertical_Sensitivity)
                {//jumps right
                    RigidBody2d.AddForce(Vector2.up * Vertical_Force * Time.deltaTime * JumpPad_Force);
                    Animator.SetInteger("AnimationState", 5);
                    LastDir_Right = true;
                }
            }
            else if(joystick.Horizontal < -JS_Horizontal_Sensitivity)
            {//moving left
                RigidBody2d.AddForce(Vector2.left * Horizontal_Force * Time.deltaTime);
                Animator.SetInteger("AnimationState", 2);
                LastDir_Right = false;

                if (joystick.Vertical > JS_Vertical_Sensitivity)
                {//jump left
                    RigidBody2d.AddForce(Vector2.up * Vertical_Force * Time.deltaTime * JumpPad_Force);
                    Animator.SetInteger("AnimationState", 4);
                    LastDir_Right = false;
                }
            }
            else
            {
                if (LastDir_Right)
                {//idle right
                    Animator.SetInteger("AnimationState", 0);
                }
                else //idles left
                    Animator.SetInteger("AnimationState", 1);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeathPlane"))
            transform.position = SpawnPoint.position;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("JellyBouncePad"))//doubles jump force while on tile
        {
            JumpPad_Force = 2.0f;
            isGrounded = true;
            
        }
        else//resets jump force back to normal
        {
            JumpPad_Force = 1.0f;
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("MovingPlatform")) //moves the player with the platform
        {
            //Moving_Platform MovingPlatform = collision.gameObject.GetComponent<Moving_Platform>();
            //transform.position += new Vector3(transform.position.x + MovingPlatform.direction, 0.0f, 0.0f);
            MovePlatform = GameObject.FindGameObjectWithTag("MovingPlatformParent");
            Moving_Platform movingPlatform = MovePlatform.gameObject.GetComponent<Moving_Platform>();
            transform.position += new Vector3(movingPlatform.HorizontalSpeed * movingPlatform.direction * Time.deltaTime, 0.0f, 0.0f);
        }
    }
    
}
