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
            SceneManager.LoadScene("Ending");
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