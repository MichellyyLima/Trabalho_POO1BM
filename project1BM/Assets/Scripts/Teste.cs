using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Teste : MonoBehaviour
{
    Vampiro Dexter = new Vampiro(); 
    Inimigo inimigo = new Inimigo();

    void Start()
    {
        Dexter.SetNome("Dexter");
        Dexter.SetAtaque(85);
        Dexter.SetVida(20);
        Dexter.SetDefesa();
        Dexter.SetHabilidade("mordida sanguinária");
        
        
        inimigo.SetNome("Iui");
        inimigo.SetAtaqueInimigo(13);
        inimigo.GetEnergia(10);
        inimigo.GetVelocidade(11);
        
        Dexter.UsouMordidaSanguinaria(inimigo);
        Dexter.UsouMordidasanguinaria(inimigo);
        
        if (Inimigo.GetVida() <= 0)
        {
            Debug.Log("O " + inimigo.nome() + "Morreu");
        }
        else
        {
            Debug.Log("O " + inimigo.GetNome() + " ainda tem " + inimigo.GetVida() + " de vida");
        }
    }

    void Update()
    {
        // Atualizações por frame (caso precise no futuro)
    }
}

    void Update()
    {
        
    }
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
