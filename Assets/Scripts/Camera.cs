using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform ball; // Цель, за которой следует камера
   
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player").transform;
    }

  
    void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = ball.position.x;
        temp.y = ball.position.y;
        transform.position = temp;
    }
}
