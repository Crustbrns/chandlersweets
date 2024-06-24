using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StairsMoving : MonoBehaviour
{
    public bool isDown;
    public Stairs stairs;
    public float randNumber;
    // Start is called before the first frame update
    void Start()
    {
        stairs = GetComponentInParent<Stairs>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (stairs.player == null && stairs.timeElapsed > 1f)
            {
                if (!isDown && !other.GetComponent<SquareMoving>().goingLeft)
                {
                    randNumber = UnityEngine.Random.value;
                    if(randNumber < 0.25f) {
                        other.gameObject.layer = 5;
                    }
                    else {
                        other.gameObject.layer = 1;
                    }
                }
            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (stairs.player == null && stairs.timeElapsed > 1f)
            {
                if (!isDown && !other.GetComponent<SquareMoving>().goingLeft)
                {
                    if (randNumber > 0.25)
                    {
                        stairs.player = other.gameObject;
                        stairs.isDown = isDown;
                        stairs.t = 0f;
                        other.GetComponent<SquareMoving>().dontMove = true;
                    }
                }
                else if (isDown)
                {
                    stairs.player = other.gameObject;
                    stairs.isDown = isDown;
                    stairs.t = 0f;
                    other.GetComponent<SquareMoving>().dontMove = true;
                }
            }
            else if (stairs.t >= 1)
            {
                stairs.timeElapsed = 0f;
                stairs.player = null;
                stairs.t = 0f;
                stairs.isDown = isDown;
                other.GetComponent<SquareMoving>().dontMove = false;
                other.GetComponent<SquareMoving>().goingLeft = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
