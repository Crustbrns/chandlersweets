using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGenerate : MonoBehaviour
{
    private List<PlayerInfo> playerInfos;
    public List<GameObject> gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        playerInfos = new List<PlayerInfo>();
        playerInfos = PlayerData.GetTeam();
        
        if (gameObjects != null)
        {
            int index = 0;
            foreach (GameObject player in gameObjects) {
                player.GetComponentInChildren<TMP_Text>().text = playerInfos[index++].Nickname;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
