using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarItem : MonoBehaviour {
    public GameObject pasta;
    public GameObject areaEscolha;

    private void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Player") {
            pasta.SetActive (true);
            areaEscolha.SetActive (true);

            this.gameObject.SetActive (false);
        }
    }
}