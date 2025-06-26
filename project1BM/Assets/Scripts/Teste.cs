using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Teste : MonoBehaviour
{
    Player Dexter = new Vampiro(); 
    Player inimigo = new Inimigo();

    void Start()
    {
        Dexter.SetNome("Dexter");
        Dexter.SetAtaque(20);
        Dexter.SetVida(20);
        Dexter.SetDefesa(20);
        Dexter.GetMordidaSanguinaria();

        inimigo.SetNome("ww");
        inimigo.SetAtaque(15);
        inimigo.SetVida(20);
        inimigo.SetDefesa(20);

        Dexter.UsouMordidaSanguinaria(inimigo);  

        if (inimigo.GetVida() <= 0)
        {
            Debug.Log("O " + inimigo.GetNome() + " morreu");
        }
        else
        {
            Debug.Log("O " + inimigo.GetNome() + " ainda tem " + inimigo.GetVida() + " de vida");
        }
    }
}
