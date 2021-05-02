using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayLoop : MonoBehaviour
{
    private static MusicPlayLoop instance = null;
    public static MusicPlayLoop Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
