using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    public void ChangeMainScene()
    {
        SoundManager.instance.BtnClickSound();
        SceneManager.LoadScene("Main");
    }
    public void ChangeStoryScene()
    {
        SoundManager.instance.BtnClickSound();
        SceneManager.LoadScene("Story");
    }
    public void ChangeStage1Scene()
    {
        SoundManager.instance.BtnClickSound();
        SceneManager.LoadScene("Stage1");
    }
    public void ChangeStage2Scene()
    {
        SoundManager.instance.BtnClickSound();
        SceneManager.LoadScene("Stage2");
    }
    public void ChangeEndingScene()
    {
        SoundManager.instance.BtnClickSound();
        SceneManager.LoadScene("Ending");
    }
    public void ChangeLoadingScene()
    {
        SoundManager.instance.BtnClickSound();
        SceneManager.LoadScene("Loading");
    }
    public void ChangeLoading2Scene()
    {
        SoundManager.instance.BtnClickSound();
        SceneManager.LoadScene("Loading2");
    }
}
