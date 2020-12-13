/********
Name:Elijah Tong
Student Number: 101126281
Source File: Start_Button_Script.cs
Last Modified: 2020-12-12
Description: When you click the GameOver button this will take the player to the GameOver screen. Also when the button is
clicked you will get a button click sound effect
***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver_Button : MonoBehaviour
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

    public void OnGameOver_ButtonPressed()
    {
        SceneManager.LoadScene("GameOver_Screen");
        ClickSound.Play();
    }
}
