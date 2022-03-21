using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace DesignPatterns
{
    public class JSONSaveSystem : MonoBehaviour
    {
        [System.Serializable]
        class SaveData
        {
            public int highScore;
            public int numberOfTries;
        }

        private void Start()
        {
            SaveHighScore();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.L))
            {
                LoadHighScore();
            }
        }

        public void SaveHighScore()
        {
            SaveData data = new SaveData();
            data.highScore = 10;
            data.numberOfTries = 10;

            string json = JsonUtility.ToJson(data);

            File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
            Debug.Log("Game saved");
        }

        public void LoadHighScore()
        {
            string path = Application.persistentDataPath + "/savefile.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                SaveData data = JsonUtility.FromJson<SaveData>(json);

                int highScoreGame = data.highScore;
                Debug.Log("highScoreGame:" + highScoreGame);
            }
        }
    }
}
