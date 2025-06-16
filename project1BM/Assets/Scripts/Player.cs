using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string Nome;
    private int velocidade;
    public int Vida;
    private int ataque;
    public int defesa;

    public Player(string nome, int Vida, int velocidade, int ataque, int defesa)
    {
        this.Nome = Nome;
        this.Vida = Vida;
        this.velocidade = velocidade;
        this.ataque = ataque;
        this.defesa = defesa;
    }
    
    public string GetNome() { return this.Nome; }
    public void SetNome(string nome) { this.Nome = nome; }
    
    public int GetVida() { return this.Vida; }
    public void SetVida(int vida) { this.Vida = vida; }
    
    public int GetVelocidade() { return this.velocidade; }
    public void SetVelocidade(int vel) { this.velocidade = velocidade; }
    
    public int GetAtaque() { return this.ataque; }
    public void SetAtaque(int ataque) { this.ataque = ataque; }
    
    public int GetDefesa() { return this.defesa; }
    public void SetDefesa(int defesa) { this.defesa = defesa; }


    public void compararVida
    {
        if ( This.
    }
         
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
