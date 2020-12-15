/***
Name:Elijah Tong
Student Number: 101126281
Source File: Moving_Platform.cs
Last Modified: 2020-12-13
Description: This will move the platforms between the two points.
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    public float direction = 1.0f;
    public float HorizontalSpeed;
    public Transform StartPoint;
    public Transform EndPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckPoints();
    }

    void Move()
    {
        transform.position += new Vector3(HorizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
    }

    void CheckPoints()
    {
        if(transform.position.x < StartPoint.transform.position.x)//checks if the platform is at the start point
        {
            direction = 1.0f;
        }
        if(transform.position.x > EndPoint.transform.position.x)//checks if the platform is at the end point
        {
            direction = -1.0f;
        }
    }
}
