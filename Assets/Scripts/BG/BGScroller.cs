using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    MeshRenderer meshRenderer;

    public float bgSpeed = 0.01f;

    [HideInInspector]
    public bool canScroll;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (canScroll)
            meshRenderer.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0);
    }
}
