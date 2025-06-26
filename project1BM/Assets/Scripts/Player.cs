using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string Nome;
    public int Vida;
    private int ataque;
    public int defesa;

    public void SetNome(string nome)
    {
        this.Nome = nome;
    }

    public string GetNome()
    {
        return this.Nome;
    }

    public void SetVida(int vida)
    {
        this.Vida = vida;
    }

    public int GetVida()
    {
        return this.Vida;
    }

    public void SetAtaque(int ataque)
    {
        this.ataque = ataque;
    }

    public int GetAtaque()
    {
        return this.ataque;
    }

    public void SetDefesa(int defesa)
    {
        this.defesa = defesa;
    }

    public int GetDefesa()
    {
        return this.defesa;
    }

    public string CompararAtaque(Player Inimigo)
    {
        if (this.ataque > Inimigo.GetAtaque())
        {
            return Nome + " é mais forte que " + Inimigo.GetNome();
        }
        else if (this.ataque < Inimigo.GetAtaque())
        {
            return Inimigo.GetNome() + " é mais forte que " + Nome;
        }
        else
        {
            return Nome + " e " + Inimigo.GetNome() + " têm a mesma força";
        }
    }

}
         