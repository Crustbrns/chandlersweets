using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStart : MonoBehaviour
{
    public Camera maincamera;
    public float z;
    public float z_dist;
    static float t = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        maincamera.transform.position = new Vector3(maincamera.transform.position.x, maincamera.transform.position.y, z);
    }

    // Update is called once per frame
    void Update()
    {
        maincamera.transform.position = new Vector3(maincamera.transform.position.x, maincamera.transform.position.y, Mathf.Lerp(z, z_dist,  Mathf.SmoothStep(0.0f, 1.0f, t)));
        t += 0.5f * Time.deltaTime;
    }
}
