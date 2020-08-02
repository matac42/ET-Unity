using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultScore = PlayerPrefs.GetFloat("SCORE");
        Debug.Log(resultScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
