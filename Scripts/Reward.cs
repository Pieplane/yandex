using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class Reward : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowReward();
    string memeName;
    

    public void RewardVideo()
    {
        ShowReward();
    }
}
