/********
Name:Elijah Tong
Student Number: 101126281
Source File: Back_Button_Instruction_Screen2_Script.cs
Last Modified: 2020-12-12
Description: When you click the back button this will take the player to the first instruction screen. When the button is
clicked you will get a button clicked sound effect
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Back_Button_Instruction_Screen2 : MonoBehaviour
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

    public void OnBack_Button_Instruction_Screen2()
    {
        SceneManager.LoadScene("Instructions_Screen");
        ClickSound.Play();
    }
}
