using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour {

    private float ultCharge;
    //private MovementManager playerMovement;
    private Animator attackAnim;
    private Rigidbody player;

    private void Awake()
    {
        //playerMovement = GetComponent<MovementManager>();
        player = GetComponent<Rigidbody>();
        attackAnim = GetComponent<Animator>();
    }

    private void Update()
    {
         
        if (ultCharge < 100)
            ultCharge += Time.deltaTime;
        
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
    }
    public void SpecialRight()
    {
    }
    public void SpecialUp()
    {
    }
    public void SpecialDown()
    {
    }
    public void Special()
    {
        if (ultCharge > 99)
            Debug.Log("UsedUlt");
    }

}
