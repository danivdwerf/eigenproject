using System;
using System.Collections;

using UnityEngine;
using UnityEngine.UI;

public class Splashscreen : MonoBehaviour
{
    [SerializeField]private Image splashImage;
    private float fadeDuration, waitTime, fullAlpha, emptyAlpha;
    public event Action OnSplashscreenEnd;

    #if UNITY_EDITOR
    [SerializeField]private bool skip;
    #endif

    private void Start()
    {   
        fadeDuration = 1.5f;
        waitTime = 3f;
        fullAlpha = 1f;
        emptyAlpha = 0f;
        StartCoroutine ("fade");
    }

    private IEnumerator fade()
    {
        splashImage.gameObject.SetActive(true);
        splashImage.canvasRenderer.SetAlpha (0f);
        fadeIn ();
        yield return new WaitForSeconds (waitTime);
        fadeOut ();
        yield return new WaitForSeconds (waitTime);
        endSplashscreen();
    }

    private void Update()
    {
        #if UNITY_EDITOR
        if(skip)
            endSplashscreen();
        #endif
    }

    private void endSplashscreen()
    {
        if(OnSplashscreenEnd != null)
            OnSplashscreenEnd();
        this.enabled = false;
    }

    private void fadeIn(){splashImage.CrossFadeAlpha (fullAlpha, fadeDuration, false);}
    private void fadeOut(){splashImage.CrossFadeAlpha (emptyAlpha, fadeDuration, false);}
}
