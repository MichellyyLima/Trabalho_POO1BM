using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampiro : Player{
    public string mordidaSanguinaria;

    public void setMordidaSanguinaria(string mordidaSanguinaria)
    {
        this.mordidaSanguinaria = mordidaSanguinaria;
    }

    public string GetMordidaSanguinaria()
    {
        return this.mordidaSanguinaria;
    }

    public void UsouMordidaSanguinaria(Vampiro)
    
    {
        Debug.Log(this.GetNome() + " usou " + GetMordidaSanguinaria() + " em " + Inimigo.SetNome());
    }

    
}