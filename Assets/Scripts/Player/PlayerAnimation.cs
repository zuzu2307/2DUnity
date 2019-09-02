using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator playerAnimator;
    private Rigidbody2D playerRigidbody;
    private bool gameStarted;
    private BGScroller bGScroller;
    private GroundScroller groundScroller;
    private BoxSpawn boxSpawner;
    public LayerMask groundLayer;
    public float jump = 400f;
    public Transform groundCheckPos;
    public float radius = 1.19f;
    public bool isGrounded;
    private int jumpCheck = 0;

    void Awake()
    {
        playerAnimator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();
        bGScroller = GameObject.Find("Background").GetComponent<BGScroller>();
        groundScroller = GameObject.Find("Ground").GetComponent<GroundScroller>();
        boxSpawner = GameObject.Find("BoxSpawner").GetComponent<BoxSpawn>();

    }
    void Start()
    {
        StartCoroutine(StartGame());

    }

    void PlayerGrounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPos.position, radius, groundLayer);
        Debug.Log(isGrounded);


    }

    void FixedUpdate()
    {
        if (gameStarted)
        {
            PlayerWalk();
            PlayerGrounded();
            PlayerJump();
        }
    }

    void PlayerWalk()
    {
        if (isGrounded)
            playerAnimator.SetFloat("Walk", 2f);
        else
            playerAnimator.SetFloat("Walk", 0f);
    }

    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                playerAnimator.SetBool("Jump", true);
                playerRigidbody.AddForce(new Vector3(0, jump, 0));
                jumpCheck = 1;
            }
        }
        else
        {
            if (jumpCheck == 1 && isGrounded)
            {
                playerAnimator.SetBool("Jump", false);
                jumpCheck = 0;
            }

        }
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(3f);
        gameStarted = true;
        bGScroller.canScroll = true;
        groundScroller.canScroll = true;
        boxSpawner.canSpawn = true;
    }

}
