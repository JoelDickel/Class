using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Nerd : MonoBehaviour
{
    //criando atributos da classe
    [SerializeField] private string nome;
    [SerializeField] private float num;
    [SerializeField] private float teste = -100f;
    private Rigidbody2D meuRB;

    //criando o atributo do ogro, que � quem vai me dar o m�todo Apresentar()
    [SerializeField] private Ogro meuParca;

    // Start is called before the first frame update
    void Start()
    {

        //checando se eu tenho em mim um rigidbody2d e passando ele para minha vari�vel
        meuRB = GetComponent<Rigidbody2D>();

        meuParca.Apresentar(nome);

        Conta(num);



        teste = Positivando(teste);
        
        Debug.Log(teste);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Passar um numero para o nerd e ele vai dizer se � = ou maior que zero e negativo se for menor que 0

    public void Conta(float numero)
    {
        //checando se o n�mero � positivo
        if(numero >= 0)
        {
            Debug.Log("Este n�mero � positivo");
        }
        else
        {
            Debug.Log("Este n�mero � negativo");
        }
    }

    //criar um m�todo que transforma n�meros negativos em positivos e n�o mexe em n�meros negativos
    public float Positivando(float numero)
    {
        //checando se � menor do que zero
        if(numero < 0)
        {
            float numeroRetorno = numero * -1;
            //numero � menor que zero, converter ele para positivo
            return (numeroRetorno); //valor retornado
        }
        //o return encerra o m�todo


        //se ele n�o for negativo
        return numero;
    }
}
