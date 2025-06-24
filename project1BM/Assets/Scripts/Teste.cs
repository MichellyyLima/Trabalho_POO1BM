using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Teste : MonoBehaviour
{
    Vampiro Dexter = new Vampiro();
    Inimigo = new Inimigo();

    void Start()
    {
        Dexter.GetNome("Dexter");
        Dexter.GetAtaque();
        Dexter.GetVida();
        Dexter.GetDefesa();
        Dex.UsarHabilidade("");
        
        
        Dex.AtribuirNome("Dex");
        Dex.AtribuirForca_Ataque(13);
        Dex.AtribuirForca_do_pulo(8);
        Dex.AtribuirEnergia(10);
        Dex.AtribuirVelocidade(11);
        
        Dex.UsarContratoDeSangue(Raul);

        // Verifica energia de Raul após o ataque
        if (Raul.Energia() <= 0)
        {
            Debug.Log("O " + Raul.Nome() + " ficou sem energia");
        }
        else
        {
            Debug.Log("O " + Raul.Nome() + " ainda tem " + Raul.Energia() + " de energia");
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
