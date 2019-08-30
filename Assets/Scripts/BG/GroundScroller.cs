using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    private new Renderer renderer;
    public float gruondSpeed = 0.01f;
    private Vector2 offSet;

    [HideInInspector]
    public bool canScroll;

    void Start()
    {
        renderer = GetComponent<Renderer>();

    }


    void Update()
    {
        if (canScroll)
        {
            offSet = new Vector2(Time.time * gruondSpeed, 0);
            renderer.material.mainTextureOffset = offSet;
        }
    }
}
