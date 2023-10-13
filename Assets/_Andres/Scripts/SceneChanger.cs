using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    public TextMeshProUGUI playername;
    public GameObject falseresolver;

    public void Awake()
    {
        falseresolver.SetActive(false);
        playername.text = InputText.inputText.Player;
    }

    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void OnPause()
    {
        falseresolver.SetActive(true);
    }

    public void UnPause()
    {
        falseresolver.SetActive(false);
        DontDestroyField.isonmyFirstScene = true;
    }
}
