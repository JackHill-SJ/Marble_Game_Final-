using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebsiteButton : MonoBehaviour
{

    public string URL;
    public void Open()
    {
        Application.OpenURL(URL);
        Debug.Log("Check");
    }
}
