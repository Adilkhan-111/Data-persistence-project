using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuUI : MonoBehaviour
{
    public TextMeshProUGUI Name;

    public TMP_InputField NameFromField;
    private void Start()
    {
        
        if (GameManager.instance.TempPlayer != null)
        {
            GameManager.instance.LoadData();
            Name.text = "High Score By - " + GameManager.instance.TempPlayer + " is " + GameManager.instance.HighScoreNum;
            NameFromField.text = GameManager.instance.TempPlayer;
        }
        


    }
    public void PlayGame()
    {
        GameManager.instance.PlayerName = NameFromField.text;
        GameManager.instance.SaveData();
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    
}
