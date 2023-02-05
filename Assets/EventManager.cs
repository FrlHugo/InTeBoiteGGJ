using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EventManager : MonoBehaviour
{
    public GameObject[] players;
    public int playerNumber;

    [SerializeField] private Animator LeverAnimator1;

    public float timer;
    public float delay;


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            players = GameObject.FindGameObjectsWithTag("Player");
            playerNumber = players.Length;
            timer = 0f;
        }

        if (playerNumber == 4)
        {
            LeverAnimator1.SetTrigger("activate");
        }
    }
}
