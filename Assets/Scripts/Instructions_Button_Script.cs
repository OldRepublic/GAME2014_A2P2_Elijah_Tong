/********
Name:Elijah Tong
Student Number: 101126281
Source File: Instructions_Button_Script.cs
Last Modified: 2020-12-12
Description: When you click the Instructions button this will take the player to the first instructions screen
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Instructions_Button_Script : MonoBehaviour
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

    public void OnInstructions_Button_ScriptPressed()
    {
        SceneManager.LoadScene("Instructions_Screen");
        ClickSound.Play();
    }
}
