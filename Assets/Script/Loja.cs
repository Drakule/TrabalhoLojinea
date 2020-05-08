using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loja : MonoBehaviour
{
  

    //Está definindo o nome da string e o valor da int
    public Espada espadaSimples = new Espada("Espada Simples", 100);
    public Espada espadaLonga = new Espada("Espada Longa", 250);

    public Armadura armaduraLeve = new Armadura("Armadura Leve", 150);
    public Armadura armaduraPesada = new Armadura("Armadura Pesada", 300);

    public Consumo maca = new Consumo("Maçã", 10);
    public Consumo pocao = new Consumo("Poção", 25); 
   

  
 
}
