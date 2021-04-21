using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ball;
    public GameObject temp;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            temp = Instantiate(ball, transform.position, transform.rotation);
        }
    }
}
