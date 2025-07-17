using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

using System.Security.Policy;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public int HighScoreNum;
    public string PlayerName;
    public string TempPlayer;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            
            
        }
        else
            Destroy(gameObject);
        LoadData();
    }
    
    

    

    [Serializable]
    class GameData
    {
        public int HighScoreNum;
        public string PlayerName;
        public string TempPlayer;
    }

    public void SaveData()
    {
        GameData data = new GameData();
        data.HighScoreNum = HighScoreNum;
        data.PlayerName = PlayerName;
        data.TempPlayer = TempPlayer;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/dataSaveFile.json", json);

    }
    public void LoadData()
    {
        string path = Application.persistentDataPath + "/dataSaveFile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            GameData data = JsonUtility.FromJson<GameData>(json);
            HighScoreNum = data.HighScoreNum;
            PlayerName = data.PlayerName;
            TempPlayer = data.TempPlayer;
        }
    }
}
