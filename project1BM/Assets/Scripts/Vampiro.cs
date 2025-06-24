using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampiro : Player

{
    public string MordidaSanguinaria;

    public void setMordidaSanguinaria(string mordidaSanguinaria)
    {
        this.MordidaSanguinaria = MordidaSanguinaria;
    }

    public string MordidaSanguinária()
    {
        return this.MordidaSanguinaria;
    }
}