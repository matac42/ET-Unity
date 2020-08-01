using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void OnClickStartButton()
    {
        //画面遷移先Gameover -> Game
        SceneManager.LoadScene("Game");
    }
}
