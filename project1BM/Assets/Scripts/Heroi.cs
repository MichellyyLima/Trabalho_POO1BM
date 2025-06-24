using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroi : MonoBehaviour
{
    private string Nome;
    public int Vida;
    private int ataque;
    public int defesa;

    public Heroi(string nome, int Vida, int velocidade, int ataque, int defesa)
    {
        this.Nome = Nome;
        this.Vida = Vida;
        this.ataque = ataque;
        this.defesa = defesa;
    }

    public string GetNome()
    {
        return this.Nome;
    }

    public void SetNome(string nome)
    {
        this.Nome = nome;
    }

    public int GetVida()
    {
        return this.Vida;
    }

    public void SetVida(int vida)
    {
        this.Vida = vida;
    }
    
    public int GetAtaque()
    {
        return this.ataque;
    }

    public void SetAtaque(int ataque)
    {
        this.ataque = ataque;
    }

    public int GetDefesa()
    {
        return this.defesa;
    }

    public void SetDefesa(int defesa)
    {
        this.defesa = defesa;
    }

}


