using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampiro : Player

{
    public string MordidaSanguinaria;

    public void setMordidaSanguinaria(int a)
    {
        this.MordidaSanguinaria = MordidaSanguinaria;
    }

    public string GetMordidaSanguinaria()
    {
        return this.MordidaSanguinaria;
    }
}