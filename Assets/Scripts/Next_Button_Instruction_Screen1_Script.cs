/********
Name:Elijah Tong
Student Number: 101126281
Source File: Start_Button_Script.cs
Last Modified: 2020-12-12
Description: When you click the next button this will take the player to the next instructions screen. Plays a click sound
on click
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Next_Button_Instruction_Screen1_Script : MonoBehaviour
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

    public void OnNext_Button_Instruction_Screen1_ScriptPressed()
    {
        SceneManager.LoadScene("Instructions_Screen_2");
        ClickSound.Play();
    }
}
