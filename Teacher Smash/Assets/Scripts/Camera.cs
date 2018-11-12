using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera : MonoBehaviour {

    [Header("List of players")]
    [SerializeField]
    List<Transform> Players;

    [Header("Customizables")]
    [SerializeField]
    int MaxPlayers = 4;
    [SerializeField]
    float Speed = 0.5f, Offset = -10, deltaTime, LimitX = 10, LimitY = 7.5f;

    [Header("UI Elements")]
    [SerializeField]
    bool UI;
    [SerializeField]
    Text Logs, Fps;

    float x, y, z;

    private void Start()
    {
        Logs = GameObject.Find("Logger").GetComponent<Text>();
        Fps = GameObject.Find("FPS").GetComponent<Text>();
        SearchForPlayers();
    }

    // public Transform CalculateNewPosition(List<Transform> Players)
    private void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        Fps.text = fps.ToString("F0") + "FPS";        

        for (int i = 0; i < Players.Count; i++)
        {
            if (Players[i] == null)
            {
                Players.RemoveAt(i);
                Logs.text = "Lost player: " + i + "! Removing from the list!\n" + Logs.text;
                Debug.LogWarning("Player not found.. Has it been killed?");
            }
            else
            {
                x += Players[i].position.x;
                y += Players[i].position.y;
            }
        }
        x /= Players.Count;
        y /= Players.Count;

        CheckMax();

        //z = (x + y) / (Players.Count * 2);

        if (Players.Count > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(x, y, z + Offset), Speed * Time.time);
        }
        
        x = 0;
        y = 0;
        //return transform;        
    }

    void SearchForPlayers(){
        for (int i = 1; i < MaxPlayers +1; i++)
        {
            if (GameObject.Find("Player" + i))
            {
                Logs.text = "Player: " + i + " Found!\n" + Logs.text;
                Players.Add(GameObject.Find("Player" + i).transform);
            }
            else
            {
                Logs.text = "Unable to find anything..\n" + Logs.text;
                Debug.LogError("No players could be found.. Make sure they're named properly in the scene!");
            }
        }
    }

    void CheckMax()
    {
        if (x > LimitX)
        {
            x = LimitX;
        }
        if (-LimitX > x)
        {
            x = -LimitX;
        }
        if (y > LimitY)
        {
            y = LimitY;
        }
        if (-LimitY > y)
        {
            y = -LimitY;
        }
    }
}
