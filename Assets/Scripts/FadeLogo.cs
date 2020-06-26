using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class FadeLogo : Fade
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        base.isFadeOut = true;
    }

    // Update is called once per frame
    bool end = false;
    async void Update()
    {
        base.Update();

        if(!isFadeOut && !isFadeIn)
        {
            if(end)
            {
                SceneManager.LoadScene("Opening");
            }
            await Task.Delay(3000);
            isFadeIn = true;
            end = true;
        }
    }
}
