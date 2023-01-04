using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogro : MonoBehaviour
{

    //Pensando nos atributos do nosso ogro
    //Os atributos de uma classe s�o as vari�veis dela
    //Vida, velocidade, nome

    [SerializeField] private int vida = 10;
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private string nome = "Juquinha";

    [SerializeField] private Nerd nerd;

    // Start is called before the first frame update
    void Start()
    {
        Apresentar(nome);

        //checando se a vida � positiva
        nerd.Conta(vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //criando o metodo de apresenta��o
    public void Apresentar(string nome)
    {
        //este c�digo � meu metodo
        //Fazendo o ogro se apresentar
        Debug.Log($"Prazer meu nome � {nome}");

        
    }

}
