using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Missoes : MonoBehaviour {
    public GameObject questList;
    public GameObject taskCheck;
    public GameObject erros;
    public GameObject dicaPopUp;
    public bool ativaQuestList;
    public bool equivocos;
    public bool dica;

    public Text missao, missao2, missao3;
    public Toggle completo, completo2, completo3;

    //gameOver
    public GameObject reverAcoes;
    bool ativaFeedback;

    public void LoadFromJason () {
        string json = File.ReadAllText (Application.dataPath + "/Json/Missoes.json");
        Lista data = JsonUtility.FromJson<Lista> (json);
        missao.text = data.missao;
        completo.isOn = data.completo;
        missao2.text = data.missao2;
        completo2.isOn = data.completo2;
        missao3.text = data.missao3;
        completo3.isOn = data.completo3;

    }
    void Start () {
        ativaQuestList = false;
        ativaFeedback = false;
        LoadFromJason ();

    }
    public void Rever () {
        ativaFeedback = true;
    }

    public void FecharRever () {
        ativaFeedback = false;
    }

    public void VerEquivocos () {
        equivocos = true;
    }
    public void FecharEquivocos () {
        equivocos = false;
    }

    public void VerLista () {
        ativaQuestList = true;
    }
    public void FecharLista () {
        ativaQuestList = false;
    }

    public void VerDica () {
        dica = true;
    }
    public void FecharDica () {
        dica = false;
    }

    void Update () {
        if (ativaQuestList) {
            questList.SetActive (true);
        } else { questList.SetActive (false); }

        if (ativaFeedback) {
            reverAcoes.SetActive (true);
        } else {
            reverAcoes.SetActive (false);
        }
        if (equivocos) {
            erros.SetActive (true);
        } else {
            erros.SetActive (false);
        }
        if (dica) {
            dicaPopUp.SetActive (true);
        } else {
            dicaPopUp.SetActive (false);
        }
    }

}