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

    public int SetVida()
    {
        return this.Vida;
        
    }

    public void GetVida(int vida)
    {
        this.Vida = Vida;
    }
    
    public void SetAtaque(int ataque)
    {
        this.ataque = ataque;
    }
    
    public int GetAtaque(int ataque)
    {
        return this.ataque;
    }

    public void GetDefesa(int defesa)
    {
        this.defesa = defesa;
    }
    
    public int SetDefesa()
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
    
         
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
