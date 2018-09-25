using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempMovement : MonoBehaviour {

    [SerializeField]
    LayerMask[] mask;
    [SerializeField]
    float checkHeight;
    [SerializeField]
    float playerSpeed;
    [SerializeField]
    float jumpHeight;
    RaycastHit2D hit;
    Rigidbody2D player;
    Abilities ray;
    SpriteRenderer flip;

	void Start () {
        player = GetComponent<Rigidbody2D>();
        ray = GetComponent<Abilities>();
        flip = GetComponent<SpriteRenderer>();
	}
	
	void Update () {

        Controlls();
        CheckAbilities();
	}
    void CheckAbilities()
    {
        if (Input.GetKeyDown(KeyCode.E) && Input.GetKey(KeyCode.W))
        {
            ray.SpecialUp();
        }
        if (Input.GetKeyDown(KeyCode.E) && Input.GetKey(KeyCode.A))
        {
            ray.SpecialLeft();
        }
        if (Input.GetKeyDown(KeyCode.E) && Input.GetKey(KeyCode.D))
        {
            ray.SpecialRight();
        }
    }
    void Controlls()
    {
        if (Input.GetKey(KeyCode.W) && checkGrounded())
        {
            player.velocity = new Vector3(0,jumpHeight,0);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.velocity = new Vector3(-playerSpeed,0,0);
            flip.flipX = true;       
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.velocity = new Vector3(playerSpeed, 0, 0);
            flip.flipX = false;
        }

    }
    bool checkGrounded()
    {
        bool grounded = false;
        for(int i = 0; i < mask.Length; i++)
        {
            hit = Physics2D.Raycast(transform.position, -Vector2.up, checkHeight, mask[i]);
            if (hit.collider != null)
            {
                grounded = true;
            }
        }
        return grounded;
    }
}
