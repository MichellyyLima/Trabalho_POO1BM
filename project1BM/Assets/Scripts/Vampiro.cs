using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

using UnityEngine;

public class Vampiro : Player
{
    private string habilidade = "Mordida Sanguinária";

    public Vampiro(string nome, int vida, int velocidade, int ataque, int defesa) 
        : base(nome, vida, ataque, defesa)
    {
    }

    public string GetHabilidade()
    {
        return habilidade;
    }
    
    public void UsarHabilidade(alvo)
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

    }
}
