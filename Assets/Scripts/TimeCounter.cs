using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    //カウントアップ
    private float second = 0.0f;
    private float minute = 0.0f;
    private float oldSeconds = 0.0f;

    //時間を表示するText型の変数
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        //時間をカウントする
        second += Time.deltaTime;
        Debug.Log(second);
        if(second >= 60f)
        {
            minute ++;
            second = second - 60;
        }

        //時間を表示する
        // timeText.text = second.ToString("f2");

        if((int)second != (int)oldSeconds) {
			timeText.text = minute.ToString("00") + ":" + ((int) second).ToString ("f2");
		}
		oldSeconds = second;
    
    }
}