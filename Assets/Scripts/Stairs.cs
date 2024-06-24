using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    public GameObject up, down;
    public GameObject player;
    public bool isDown;
    public float t = 0.0f;
    public float timeElapsed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (!isDown)
            {
                player.transform.position = new Vector3(Mathf.Lerp(down.transform.position.x, up.transform.position.x, t), Mathf.Lerp(down.transform.position.y, up.transform.position.y, t), player.transform.position.z);
            }
            else {
                player.transform.position = new Vector3(Mathf.Lerp(up.transform.position.x, down.transform.position.x, t), Mathf.Lerp(up.transform.position.y, down.transform.position.y, t), player.transform.position.z);

            }

            t += 0.5f * Time.deltaTime;
        }
        else {
            timeElapsed += 1f * Time.deltaTime;
        }
    }
}
