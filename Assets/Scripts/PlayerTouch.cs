using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("playerinfo", LoadSceneMode.Additive);
    }
    void Update()
    {

    }
}
