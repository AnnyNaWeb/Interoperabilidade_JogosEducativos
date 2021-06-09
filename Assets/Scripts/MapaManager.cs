using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapaManager : MonoBehaviour {
    public GameObject blockCongresso, blockJudiciario;
    public bool ativaBlockC, ativaBlockJ;
    void Start () {
        ativaBlockC = false;
        ativaBlockJ = false;
    }

    public void Congresso () {
        ativaBlockC = true;
    }
    public void Judiciario () {
        ativaBlockJ = true;
    }
    void Update () {
        if (ativaBlockC) {
            blockCongresso.SetActive (true);
        } else {
            blockCongresso.SetActive (false);
        }

        if (ativaBlockJ) {
            blockJudiciario.SetActive (true);
        } else {
            blockJudiciario.SetActive (false);
        }

    }
    public void OutCongresso () {
        ativaBlockC = false;
    }
    public void OutJudiciario () {
        ativaBlockJ = false;
    }
}