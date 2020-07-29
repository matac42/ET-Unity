using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        
        
        if(other.gameObject.CompareTag("Goal")){
            Invoke("finish", 1f);
            Debug.Log("goal");
          }
        
    }

    void finish(){
        SceneManager.LoadScene("Ending");
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