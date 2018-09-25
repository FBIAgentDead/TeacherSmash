using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour {

    private float ultCharge;
    //private MovementManager playerMovement;
    private Animator attackAnim;
    private Animation currentAnim;
    private Rigidbody player;

    private void Awake()
    {
        //playerMovement = GetComponent<MovementManager>();
        player = GetComponent<Rigidbody>();
        attackAnim = GetComponent<Animator>();
    }

    private void Update()
    {
    }
    public void NeutralLeft()
    {
    }
    public void NeutralRight()
    {
    }
    public void NeutralUp()
    {
    }
    public void NeutralDown()
    {
    }
    public void Neutral()
    {
    }
    public void SpecialLeft()
    {
        attackAnim.Play("Bomb Throw");
    }
    public void SpecialRight()
    {
        attackAnim.Play("Bomb Throw");
    }
    public void SpecialUp()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y+3,transform.position.z);
    }
    public void SpecialDown()
    {
    }
    public void Special()
    {
    }

}
