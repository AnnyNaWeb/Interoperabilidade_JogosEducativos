using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    private int reset;
    private float px, pz;

    public void Jogar () {
        SceneManager.LoadScene ("Fases");
    }
    public void Sair () {
        Application.Quit ();
    }
    public void GamePlay () {

        SceneManager.LoadScene ("GamePlay");
    }
    public void Again () {
        reset = 60;
        Tempo data = new Tempo ();
        data.totalTime = reset.ToString ();

        string json = JsonUtility.ToJson (data, true);
        File.WriteAllText (Application.dataPath + "/Json/TempoData.json", json);

        px = 0;
        pz = 0;
        Player dPlayer = new Player ();
        dPlayer.x = px;
        dPlayer.z = pz;

        string json2 = JsonUtility.ToJson (dPlayer, true);
        File.WriteAllText (Application.dataPath + "/Json/PlayerPosition.json", json2);
        SceneManager.LoadScene ("GamePlay");

    }
    public void Voltar () {
        SceneManager.LoadScene ("Menu");
    }
}