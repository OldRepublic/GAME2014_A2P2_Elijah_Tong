/***
Name:Elijah Tong
Student Number: 101126281
Source File: Player_Script.cs
Last Modified: 2020-12-13
Description: This script will move the player in the direction of the joystick.
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
    bool LastDir_Right = true;
    private Rigidbody2D RigidBody2d;
  
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
                    RigidBody2d.AddForce(Vector2.up * Vertical_Force * Time.deltaTime);// && LastDir_Right == true)
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
                    RigidBody2d.AddForce(Vector2.up * Vertical_Force * Time.deltaTime);// && LastDir_Right == false)
                    Animator.SetInteger("AnimationState", 4);
                    LastDir_Right = false;
                }
            }
            /***
            else if(joystick.Vertical > JS_Vertical_Sensitivity && joystick.Horizontal > JS_Horizontal_Sensitivity)
            {//jumps right
                RigidBody2d.AddForce(Vector2.up * Vertical_Force * Time.deltaTime);// && LastDir_Right == true)
                Animator.SetInteger("AnimationState", 5);
                LastDir_Right = true;
            }
            else if(joystick.Vertical > JS_Vertical_Sensitivity && joystick.Horizontal < -JS_Horizontal_Sensitivity)
            {//jump left
                RigidBody2d.AddForce(Vector2.up * Vertical_Force * Time.deltaTime);// && LastDir_Right == false)
                Animator.SetInteger("AnimationState", 4);
                LastDir_Right = false;
            }***/
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
}
