using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gerent : MonoBehaviour
{
    //Chamando a função Loja para poder ser aplicada aqui
    public Loja loja;
    public float moeda = 1000;//Definindo outra float para moedas
   
    public Text moeda_Text;
    public Text avisosText;
    public GameObject aceitar;
    

    private void AtualizarDinheiro()//Atualizando o dinheiro sempre que o jogador efetua alguma compra
    {
        moeda_Text.text = "Moedas: "+moeda.ToString();
    }

    private void Awake()//Colocamos ela dentro de uma Awake para estar sempre aplicada antes do Start
    {
        AtualizarDinheiro();
    }

    private void Start()
    {
        Avisos(0);
    }
    
    public void ComprarItem(int opcao)//A função que permite comprar itens
    { 
        //Se ele escolher qualquer uma desses cases, o jogador irá efetuar seu devido item
        if(opcao == 1)
        {
            
            PossoComprar(loja.espadaSimples.ValorCompra);
          
        }
        if(opcao == 2)
        {
            PossoComprar(loja.maca.ValorCompra);
         
        }
        if(opcao == 3)
        {
            PossoComprar(loja.armaduraLeve.ValorCompra);
           
        }
        if(opcao == 4)
        {
            PossoComprar(loja.armaduraPesada.ValorCompra);
        
        }
        if(opcao == 5)
        {
            
            PossoComprar(loja.espadaLonga.ValorCompra);
       
        }
        if(opcao == 6)
        {
            PossoComprar(loja.pocao.ValorCompra);
         
        }
        
    }

    public void PossoComprar(float preco)//Função que permite o jogador comprar até que o seu número de moedas chegue até zero
    {
       
        if(preco < moeda)
        {
            moeda -= preco;
            AtualizarDinheiro();
        }
        else
        {
            Avisos(1);
        }
        
    }
    public void Avisos(int param)//Caso chegue a zero, irá surgir uma mensagem de aviso que o jogador não pode comprar por não possuir saldo
    {
        if(param == 0)
        {
            avisosText.text = "";
            
        }
        if (param == 1)
        {
            avisosText.text = "Você não tem moedas";

        }
    }
    
}
