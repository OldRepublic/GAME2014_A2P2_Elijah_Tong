/********
Name:Elijah Tong
Student Number: 101126281
Source File: Resume_Button.cs
Last Modified: 2020-12-12
Description: When you click the resume button this will take the player back to the gameplay screen. When you click the button
a sound will play.
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Resume_Button : MonoBehaviour
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

    public void OnResume_ButtonPressed()
    {
        SceneManager.LoadScene("Level1");
        ClickSound.Play();
    }
}
