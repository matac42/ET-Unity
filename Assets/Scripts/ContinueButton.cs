﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public void OnClickContinueButton()
    {
        SceneManager.LoadScene("Opening");
    }
}
