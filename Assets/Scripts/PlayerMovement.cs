using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	// this has jumping, movement, and the code for groundCheck. You must do
    // things yourself in the unity editor to for groundCheck. Code Tested
    // unity 2d platformer
    
    public event EventHandler eatenCandy;
    
    public float speed = 5f;
    public float jumpSpeed = 3f;
    private float direction = 0f;
    private float eatCandy = 0f;
    private Rigidbody2D player;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    private bool isTouchingLadder;

    private bool canJump;

    public SpriteRenderer spriteRenderer;

    public Sprite[] Skins;
    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Skins[PlayerSkin.playerSkin];
    }
    // Start is called before the first frame update
    void Start()
    {
        
        canJump = false;
        isTouchingLadder = false;
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.IsTouchingLayers(GetComponent<Collider2D>(), groundLayer);
        //Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        direction = Input.GetAxis("Horizontal");
        eatCandy = Input.GetAxis("Fire1");

        if (direction > 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else if (direction < 0f)
        {
            player.velocity = new Vector2(direction * speed, player.velocity.y);
        }
        else
        {
            player.velocity = new Vector2(0, player.velocity.y);
        }
        
        if (Input.GetButtonDown("Jump") && isTouchingGround && canJump)
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            if(isTouchingLadder)
            {
                canJump = true;
            }
            else
            {
                canJump = false;
            }
            
        }
        if(eatCandy > 0f && InventoryScript.numOfCandies > 0)
        {
            InventoryScript.numOfCandies--;
            eatenCandy?.Invoke(this, EventArgs.Empty);
            StartCoroutine(waitUntilNotClick());
        }
        
    }
    void OnCollisionEnter2D(Collision2D collidedWithThis)
    {
        Debug.Log(collidedWithThis.transform.tag);
        if (collidedWithThis.transform.tag == "Untagged" || collidedWithThis.transform.tag == "Crate" || collidedWithThis.transform.tag == "Ladder")
        {
            Debug.Log("I can jump!");
            canJump = true;
            if(collidedWithThis.transform.tag == "Ladder")
            {
                isTouchingLadder = true;
            }
            else
            {
                isTouchingLadder = false;
            }
        }
    }
    IEnumerator waitUntilNotClick()
    {
        while(eatCandy != 0f)
        {
            yield return null;
        }
    }
}