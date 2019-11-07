using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ro : MonoBehaviour
{

    [Header("任務")]

    public string star = "ㄟ你過來一下";

    [Header("速度")]

    public float talkspeed = 5f;

    [Header("任務")]

    public bool mission_complete = false;

    public int count_player = 0;

    public int finish = 5;



    void Start()

    {

        Debug.Log(star);

    }

}