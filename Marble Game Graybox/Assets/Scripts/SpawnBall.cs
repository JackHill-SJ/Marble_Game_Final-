using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ball;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(ball, transform.position, transform.rotation);
        }
    }
}
