using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//conjunto do array de dados propriamente dito
[System.Serializable]
public class Pessoa {
    public string nome;
    public int idade;
    public bool interrogado;
    public string[] itens;
}

//para a classe do JSON “suspeitos”
[System.Serializable]
public class PessoaRaiz {
    public Pessoa[] suspeitos;
}