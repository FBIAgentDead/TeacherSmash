using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour {

    private InputManager inputMG;
    private PlayerManager plMG;
    private AttackManager attackMG;
    private int PlayerNumber;

    private bool[] PL_Input;

	void Start () {

        GameObject GameManager = GameObject.FindGameObjectWithTag("GameManager");
        inputMG = GameManager.GetComponent<InputManager>();
        plMG = GetComponent<PlayerManager>();
        PlayerNumber = plMG.PlayerNumber;
        attackMG = GetComponent<AttackManager>();
	}
	
	void Update () {

        if (PlayerNumber == 1) { PL_Input = inputMG.PL_1; }
        else if (PlayerNumber == 2) { PL_Input = inputMG.PL_2; }

        if (plMG.canMove && !plMG.isStunned)
        {
            if (PL_Input[0]) { Jump(); }
            if (PL_Input[1]) { Move("Left"); }
            if (PL_Input[2]) { Duck(); }
            if (PL_Input[3]) { Move("Right"); }
            if (PL_Input[4] || PL_Input[5]) { attackMG.I_Has_Been_Summoned(); }
        }

	}

    void Jump()
    {

    }

    void Move(string left_right)
    {

    }

    void Duck()
    {

    }
}
