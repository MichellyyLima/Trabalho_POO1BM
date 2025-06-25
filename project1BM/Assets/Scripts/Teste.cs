using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Teste : MonoBehaviour
{
    Vampiro Dexter = new Vampiro(); 
    Inimigo inimigo = new Inimigo();

    void Start()
    
    {
        Dexter.GetNome();
        Dexter.GetAtaque(20);
        Dexter.GetVida(20);
        Dexter.GetDefesa(20);
        Dexter.GetMordidaSanguinaria();
        
        
        inimigo.GetNome();
        inimigo.GetAtaqueInimigo(13);
        inimigo.GetEnergia(10);
        inimigo.GetVelocidade(11);
        
        Dexter.UsouMordidaSanguinaria(inimigo);
        Dexter.UsouMordidasanguinaria(inimigo);
        
        if (Inimigo.GetVida() <= 0)
        {
            Debug.Log("O " + inimigo.nome() + "Morreu");
        }
        else
        {
            Debug.Log("O " + inimigo.Nome() + " ainda tem " + inimigo.GetVida() + " de vida");
        }
    
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
