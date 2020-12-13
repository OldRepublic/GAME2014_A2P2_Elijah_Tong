﻿/********
Name:Elijah Tong
Student Number: 101126281
Source File: Start_Button_Script.cs
Last Modified: 2020-12-12
Description: When you click the start button this will take the player to the gameplay screen level 1. When button is clicked a button
click sound will play.
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start_Button_Script : MonoBehaviour
{
    AudioSource ClickSound;
    // Start is called before the first frame update
    void Start()
    {
        ClickSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnstartButtonPressed()
    {
        SceneManager.LoadScene("Level1");
        ClickSound.Play();
    }
}
