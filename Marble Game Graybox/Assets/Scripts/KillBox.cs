using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBox : MonoBehaviour
{
    private Scene activeScene;

    private void Start()
    {
        activeScene = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        SceneManager.LoadScene(activeScene.name);
    }
}
