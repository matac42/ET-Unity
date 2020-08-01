﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    //カウントアップ
    private float second = 0.0f;
    private float minute = 0.0f;
    private float milis = 0.0f;

    private bool flag = true;


    //時間を表示するText型の変数
    public Text timeText;

    
   

    
    // Update is called once per frame
    void Update()
    {
        if (!flag) return;
        
        // //時間をカウントする
        second += Time.deltaTime;
        milis = second*1000%1000;
        if(second >= 60f)
        {
            minute ++;
            second = second - 60;
        }

        //時間を表示する
        // timeText.text = second.ToString("f2");

		timeText.text = minute.ToString("00") + ":" + ((int) second).ToString ("00") + ":" + ((int) milis).ToString ("000");
    
    }
    void OnTriggerExit(Collider other)
    {
        
        
        if(other.gameObject.CompareTag("Goal")){
            flag = false;
            Debug.Log("判定");

        }

        
    }
}