/********
Name:Elijah Tong
Student Number: 101126281
Source File: Start_Button_Script.cs
Last Modified: 2020-12-12
Description: When you click the back button this will take the player to the back to the start screen. On button click a button
click sound will play
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Back_Button_Instruction_Screen1_Script : MonoBehaviour
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

    public void OnBack_Button_Instruction_Screen_Script1Pressed()
    {
        SceneManager.LoadScene("Start_Screen");
        ClickSound.Play();
    }
}
