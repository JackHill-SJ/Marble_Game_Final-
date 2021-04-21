﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public GameObject attractedTo;
    public float attractStrength = 5.0f;
    public Rigidbody rb;


    private void OnTriggerStay(Collider other)
    {
        Vector3 direction = attractedTo.transform.position - other.transform.position;
        rb.AddForce(attractStrength * direction);
    }
}
