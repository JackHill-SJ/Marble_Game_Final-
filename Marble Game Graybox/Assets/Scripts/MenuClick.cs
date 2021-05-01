using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MenuClick : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite MenuClosed;
    public Sprite MenuOpen;
    
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            MenuClosed = MenuOpen;
        }  
    }
}