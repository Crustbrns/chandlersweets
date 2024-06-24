using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class SquareMoving : MonoBehaviour
{
    public int count;
    public GameObject player;
    public bool goingLeft;
    public bool dontMove;
    public bool idling;
    public float idleTime;
    public float timeUntilIdle;
    public float timeToIdleElapsed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            goingLeft = !goingLeft;
        }
    }
    void Update()
    {
        if (!dontMove && !idling)
        {
            player.transform.position = new Vector2(player.transform.position.x + 3f * (goingLeft ? -1f : 1f) * Time.deltaTime, player.transform.position.y);
        }

        if (!dontMove && !idling)
        {
            timeToIdleElapsed += 1f * Time.deltaTime;
            if (timeToIdleElapsed > timeUntilIdle)
            {
                idling = true;
                idleTime = 0f;
            }
        }
        else if (idling)
        {
            idleTime += 1f * Time.deltaTime;
            if (idleTime > 3f)
            {
                idling = false;
                timeToIdleElapsed = 0f;
                timeUntilIdle = 5 + UnityEngine.Random.value * 5;
            }
        }
    }
}
