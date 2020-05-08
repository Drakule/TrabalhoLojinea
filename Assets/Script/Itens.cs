using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public abstract class Itens
{
    //Script que declara os itens, seu nome e valor, e se é acumulavel, isso em classes diferentes

    protected int valor;
    protected string nome;
   

    public string Nome
    {
        get
        {
            return nome;
        }
    }

    public int ValorCompra
    {
        get
        {
            return valor;
        }
    }

}

public class Espada : Itens
{
    public bool acumulavel = true;
    
    public Espada(string _nome, int _valor)
    {
       
       
        nome = _nome;
        valor = _valor;
    }


}

public class Consumo : Itens
{
    public Consumo(string _nome, int _valor)
    {
        
        nome = _nome;
        valor = _valor;
    }
}

public class Armadura : Itens
{
    public Armadura(string _nome, int _valor)
    {
       
        nome = _nome;
        valor = _valor;

    }
}



 