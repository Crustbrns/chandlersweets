using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SquareMoving : MonoBehaviour
{
    public int count;
    public GameObject player;
    private bool stoped;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            stoped = !stoped;
        }
    }
    void Update()
    {
        player.transform.position = new Vector2(player.transform.position.x + 3f * (stoped ? 1f : -1f) * Time.deltaTime, player.transform.position.y);
    }
}
