using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : Player

{ 
    public string inimigo;
    public string Nome;
    
    public int AtaqueInimigo;

    public int GetAtaqueInimigo()
  {
     return AtaqueInimigo;
  }

    public void SetNome(string nome)
    {
        this.Nome = nome;
    }

    public string GetNome()
    {
        return this.Nome;
    }
}

