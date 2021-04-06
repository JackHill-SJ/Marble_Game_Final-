using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("win");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
