using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AreaEscolha : MonoBehaviour {
    public GameObject popUpEscolha;
    public GameObject pasta;
    public Toggle taskCheck;
    public Text task1, taskE;
    public bool acerta, fez;
    private void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Player") {
            popUpEscolha.SetActive (true);

        }
    }

    public void LoadFromJason () {
        string json = File.ReadAllText (Application.dataPath + "/Json/Missao1.json");
        Missao1 data = JsonUtility.FromJson<Missao1> (json);
        if (acerta) {
            task1.text = data.correta;
        } else {
            taskE.text = data.errada;
        }

    }

    public void SaveMissao () {
        SaveMissao save = new SaveMissao ();
        save.acertou = acerta;

        string json = JsonUtility.ToJson (save, true);
        File.WriteAllText (Application.dataPath + "/Json/SaveMissao.json", json);
    }

    public void Judiciario () {
        acerta = true;
        FechaQuest ();
    }
    public void Legislativo () {
        acerta = false;
        FechaQuest ();
    }
    public void Executivo () {
        acerta = false;
        FechaQuest ();
    }

    void FechaQuest () {
        SaveMissao ();
        LoadFromJason ();
        taskCheck.isOn = true;
        pasta.SetActive (false);
        popUpEscolha.SetActive (false);
        this.gameObject.SetActive (false);
    }

}