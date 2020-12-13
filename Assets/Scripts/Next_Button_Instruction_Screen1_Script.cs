/********
Name:Elijah Tong
Student Number: 101126281
Source File: Start_Button_Script.cs
Last Modified: 2020-11-19
Description: When you click the next button this will take the player to the next instructions screen
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Next_Button_Instruction_Screen1_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNext_Button_Instruction_Screen1_ScriptPressed()
    {
        SceneManager.LoadScene("Instructions_Screen_2");
    }
}
