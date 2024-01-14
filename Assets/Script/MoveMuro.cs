using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMuro : MonoBehaviour
{
    public float MuroSpeed;

    private void Update()
    {
        transform.position += Vector3.left * MuroSpeed * Time.deltaTime;
    }
}
