/********
Name:Elijah Tong
Student Number: 101126281
Source File: Start_Button_Script.cs
Last Modified: 2020-12-12
Description: When you click the pause menu button this will take the player to the pause menu screen. Also when you click the
button a click sound will play.
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause_Menu_Button_Script : MonoBehaviour
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

    public void OnPause_Menu_Button_ScriptPressed()
    {
        SceneManager.LoadScene("Pause_Menu");
        ClickSound.Play();
    }
}
