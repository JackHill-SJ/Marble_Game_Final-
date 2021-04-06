using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint : MonoBehaviour
{
    Vector3 Pos;

    float offset = -0.7f;
    private void OnTriggerStay(Collider other)
    {
        Pos = other.transform.position;

        transform.parent.position = new Vector3(Pos.x - offset, Pos.y, Pos.z);
    }
}
