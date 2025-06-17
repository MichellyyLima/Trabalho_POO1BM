using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

using UnityEngine;

public class Vampiro : Player
{
    private string habilidade = "Mordida Sanguinária";

    public Vampiro(string nome, int vida, int velocidade, int ataque, int defesa) 
        : base(nome, vida, velocidade, ataque, defesa)
    {
    }

    public string GetHabilidade()
    {
        return habilidade;
    }

    // Habilidade especial: suga vida
    public void UsarHabilidade(Player alvo)
    {
        int dano = GetAtaque() - alvo.GetDefesa();
        if (dano < 0) dano = 0;

        alvo.SetVida(alvo.GetVida() - dano);
        SetVida(GetVida() + dano / 2); // recupera metade do dano causado

        Debug.Log(GetNome() + " usou " + habilidade + " causando " + dano + " de dano e recuperando " + (dano / 2) + " de vida.");

        if (alvo.GetVida() <= 0)
        {
            Debug.Log(alvo.GetNome() + " foi derrotado!");
        }
        else
        {
            Debug.Log(alvo.GetNome() + " ficou com " + alvo.GetVida() + " de vida.");
        }
    }
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
