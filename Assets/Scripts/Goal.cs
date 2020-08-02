using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject GoalText;
    
    void OnTriggerExit(Collider other)
    {
        
        
        if(other.gameObject.CompareTag("Goal")){
            GoalText.SetActive(true);
            
            
            Invoke("finish", 3.0f);
            Debug.Log("goal");

        }
        
    }

    void finish(){
        SceneManager.LoadScene("Ending");
        
        
    }
// Start is called before the first frame update
    void Start()
    {
        GoalText.SetActive(false);
        
    
    }

// Update is called once per frame
    void Update()
    {
    
    
    }
}