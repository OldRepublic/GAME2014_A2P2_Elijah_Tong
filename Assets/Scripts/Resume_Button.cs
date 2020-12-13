/********
Name:Elijah Tong
Student Number: 101126281
Source File: Start_Button_Script.cs
Last Modified: 2020-11-19
Description: When you click the resume button this will take the player back to the gameplay screen 
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Resume_Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnResume_ButtonPressed()
    {
        SceneManager.LoadScene("Level1");
    }
}
