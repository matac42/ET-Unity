using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButton : MonoBehaviour
{
    void Quit()
    {
      UnityEngine.Application.Quit();
    }
    public void OnClickEndButton()
    {
        Quit();
    }
}
