using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {
    [SerializeField] public static float totalTime;
    public Text tempo;

    private float minutes;
    private float seconds;
    public GameObject gameOver;
    public GameObject areaEscolha;

    public static string novoTotal;

    void Start () {
        LoadFromJason ();

        // totalTime = 60.0f;

        seconds = 60;
        gameOver.SetActive (false);
        areaEscolha.SetActive (false);
    }

    void Time_ () {
        totalTime -= Time.deltaTime;
        minutes = (int) (totalTime / 60);
        seconds = (int) (totalTime % 60);
        tempo.text = minutes.ToString () + ": " + seconds.ToString ();
        novoTotal = minutes.ToString () + ": " + seconds.ToString ();
        if (seconds >= 0) {
            transform.Translate (0, 0, 0);
        } else {
            totalTime = 0;
        }
    }

    void Update () {

        if (seconds >= 0) {
            Time_ ();

        } else {
            gameOver.SetActive (true);

        }
    }
    //Jason é um apelido carinhoso kkk
    public void SaveToJason () {
        Tempo data = new Tempo ();
        data.totalTime = totalTime.ToString ();

        string json = JsonUtility.ToJson (data, true);
        File.WriteAllText (Application.dataPath + "/Json/TempoData.json", json);
    }

    public void LoadFromJason () {

        string json = File.ReadAllText (Application.dataPath + "/Json/TempoData.json");
        Tempo data = JsonUtility.FromJson<Tempo> (json);
        totalTime = float.Parse (data.totalTime);

    }

}