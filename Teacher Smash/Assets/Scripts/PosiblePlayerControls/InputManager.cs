using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public bool[] PL_1;
    public bool[] PL_2;

    void Start()
    {
        PL_1 = new bool[6];
        PL_2 = new bool[6];
    }

    // Update is called once per frame
    void Update () {

        GetInput();

	}

    void GetInput()
    {

        PL_1[0] = Input.GetButton("PL_1_UP");
        PL_1[1] = Input.GetButton("PL_1_LEFT");
        PL_1[2] = Input.GetButton("PL_1_DOWN");
        PL_1[3] = Input.GetButton("PL_1_RIGHT");
        PL_1[4] = Input.GetButton("PL_1_Normal");
        PL_1[5] = Input.GetButton("PL_1_Special");

        PL_2[0] = Input.GetButton("PL_2_UP");
        PL_2[1] = Input.GetButton("PL_2_LEFT");
        PL_2[2] = Input.GetButton("PL_2_DOWN");
        PL_2[3] = Input.GetButton("PL_2_RIGHT");
        PL_2[4] = Input.GetButton("PL_2_Normal");
        PL_2[5] = Input.GetButton("PL_2_Special");
    }
}
