/********
Name:Elijah Tong
Student Number: 101126281
Source File: Start_Button_Script.cs
Last Modified: 2020-11-19
Description: When you click the back button this will take the player to the first instruction screen
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Back_Button_Instruction_Screen2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBack_Button_Instruction_Screen2()
    {
        SceneManager.LoadScene("Instructions_Screen");
    }
}
