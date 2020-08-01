using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallJudge : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("Clash3");
     
        if(collision.gameObject.CompareTag("Ground")){
     Debug.Log("Clash");
            SceneManager.LoadScene("Gameover");
            //音楽つける、リトライボタンを追加する。->ゲーム(スタート)画面に飛ぶ
            
          }
       
        
    }

// Start is called before the first frame update
    void Start()
    {
    
    }

// Update is called once per frame
    void Update()
    {
    
    }
}