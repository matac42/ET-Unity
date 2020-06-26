using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fade : MonoBehaviour
{
    float fadeSpeed = 0.02f;
    float red, green, blue, alfa;

    public bool isFadeIn = false;
    public bool isFadeOut = false;

    Image fadeImage;

    // Start is called before the first frame update
    public void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }

    // Update is called once per frame
    public void Update()
    {
        if(isFadeIn)
        {
            StartFadeIn();
        }
        if(isFadeOut)
        {
            StartFadeOut();
        }
    }

    void StartFadeOut()
    {
        fadeImage.enabled = true;
        alfa += fadeSpeed;
        SetAlfa();
        if(alfa >= 1)
        {
            isFadeOut = false;
        }
    }

    void StartFadeIn()
    {
        alfa -= fadeSpeed;
        SetAlfa();
        if(alfa <= 0)
        {
            isFadeIn = false;
            fadeImage.enabled = false;
        }
    }

    void SetAlfa()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
