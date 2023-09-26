using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    public TextMeshProUGUI playername;

    public void Awake()
    {
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
}
