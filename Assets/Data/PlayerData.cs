using System;
using System.Collections.Generic;

static class PlayerData
{
    private static List<PlayerInfo> playerInfos;

    static PlayerData()
    {
        playerInfos = new List<PlayerInfo>();

        playerInfos.Add(new PlayerInfo("crustbrns", "Yehor Kirichenko"));
        playerInfos.Add(new PlayerInfo("reflow", "Max Stelmakh"));
        playerInfos.Add(new PlayerInfo("Andromeda", "Andrey Fedotov"));
        playerInfos.Add(new PlayerInfo("thet1x", "Vadim Lebedovich"));
        playerInfos.Add(new PlayerInfo("maL", "Yegor Malinin"));
        playerInfos.Add(new PlayerInfo("freed", "Dmitriy Fred"));
        playerInfos.Add(new PlayerInfo("SnowEagle", "Slavik Dudarev"));
        playerInfos.Add(new PlayerInfo("ffuuys", "Fusia Zigamet"));
        playerInfos.Add(new PlayerInfo("pejeb", "Alex Crypto"));
        playerInfos.Add(new PlayerInfo("kbx", "Kirill Benbo"));
    }

    public static List<PlayerInfo> GetTeam()
    {
        List<PlayerInfo> players = new List<PlayerInfo>();

        for (int i = 0; i < 5; i++)
        {
            PlayerInfo tempPlayer = playerInfos[Convert.ToInt32(Math.Floor(UnityEngine.Random.value * playerInfos.Count))];
            while (players.Contains(tempPlayer))
            {
                tempPlayer = playerInfos[Convert.ToInt32(Math.Floor(UnityEngine.Random.value * playerInfos.Count))];

            }
            players.Add(tempPlayer);
        }

        return players;
    }
}