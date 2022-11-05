using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string username;
    public string bestScoreUser;
    public int bestScoreValue;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadBestScore();
    }

    public void setName(string name)
    {
        DataManager.Instance.username = name;
    }
    

    [System.Serializable]
    class SaveData
    {
        public string bestScoreUser;
        public int bestScoreValue;
    }

    public void SaveBestScore()
    {
        SaveData data = new SaveData();
        data.bestScoreUser = bestScoreUser;
        data.bestScoreValue = bestScoreValue;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestScoreUser = data.bestScoreUser;
            bestScoreValue = data.bestScoreValue;
        }
        else {
            bestScoreUser = "None";
            bestScoreValue = 0;
        }
    }

}



