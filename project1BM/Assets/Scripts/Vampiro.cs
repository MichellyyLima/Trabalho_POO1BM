using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampiro : Player
    
{
    public string MordidaSanguinaria;

    public void SetMordidaSanguinaria(string mordidaSanguinaria)
    {
        this.MordidaSanguinaria = mordidaSanguinaria;
    }

    public string GetMordidaSanguinaria()
    {
        return this.MordidaSanguinaria;
    }

    public void UsarMordidaSanguinaria(Player vampiro)

    {
        
        Debug.Log(vampiro.GetNome() + " agora tem" + vampiro.Vida);
    }

    
}