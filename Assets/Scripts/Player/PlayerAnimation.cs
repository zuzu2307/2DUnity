using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator playerAnimator;
    private Rigidbody2D playerRigidbody;
    private bool gameStarted;
    void Awake()
    {
        playerAnimator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();

    }
    void Start()
    {
        StartCoroutine(StartGame());

    }

    void FixedUpdate()
    {
        if (gameStarted)
        {
            playerAnimator.SetFloat("Walk", 1f);

        }

    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(10f);
        gameStarted = true;

    }

}
