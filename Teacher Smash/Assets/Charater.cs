using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charater : MonoBehaviour {
    private Rigidbody characterPush;
    private Animator characterAnim;
    private SpriteRenderer characterFlip;
    public float movementSpeed = 10;
    public float jumpHeight;
    private bool canJump = true;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            canJump = true;
            characterAnim.Play("Walk");
        }
            
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Movement(0);
            if (canJump == true)
            {
                characterAnim.Play("Walk");
            }
            characterFlip.flipX = false;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            Movement(1);
            if(canJump == true)
            {
                characterAnim.Play("Walk");
            }
            characterFlip.flipX = true;
        }
        else
        {
            if(canJump == true)
            characterAnim.Play("Idle");
        }
        if (Input.GetKey(KeyCode.UpArrow) && canJump == true)
        {
            Movement(2);
            characterAnim.Play("jump");
            canJump = false;
        }
        
    }
    private void Awake()
    {
        characterPush = GetComponent<Rigidbody>();
        characterAnim = GetComponent<Animator>();
        characterFlip = GetComponent<SpriteRenderer>();
    }
    void Movement(int leftRight)
    {
        if(leftRight == 1)
        {
            characterPush.velocity = transform.right * movementSpeed;
            Debug.Log("test");
        }
        else
        {
            characterPush.velocity = transform.right * -movementSpeed;
        }
        if(leftRight == 2)
        {
            characterPush.velocity = transform.up * jumpHeight;
        }
    }
}
