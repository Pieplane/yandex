using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
    public int Coins;
    public int[] IntsCoins = new int[79];

    public int WasBoughtSpider;
    public int WasBoughtSuper;
    public int WasBoughtGirl;
    public int WasBoughtRep;
    public int WasBoughtNlo;

    public string RewardSpider;
    public string RewardSuper;
    public string RewardGirl;
    public string RewardRep;
    public string RewardNlo;

    public int SetHappy;
    public int SetSpider;
    public int SetSuper;
    public int SetGirl;
    public int SetRep;
    public int SetNlo;

    public float TimeGame01;
    public float TimeGame02;
    public float TimeGame03;
    public float TimeGame04;
    public float TimeGame05;
    public float TimeGame06;
    public float TimeGame07;
    public float TimeGame08;
    public float TimeGame09;
    public float TimeGame10;

    public int LevelReached;
}
//public class PlayerInfoNull
//{

//}

public class Progress : MonoBehaviour
{
    public PlayerInfo PlayerInfo;
    [DllImport("__Internal")]
    private static extern void SaveExtern(string date);
    [DllImport("__Internal")]
    private static extern void LoadExtern();

    public static Progress Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            LoadExtern();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Save()
    {
        string jsonString = JsonUtility.ToJson(PlayerInfo);
        SaveExtern(jsonString);
    }

    public void SetPlayerInfo(string value)
    {
        PlayerInfo = JsonUtility.FromJson<PlayerInfo>(value);
    }
}
