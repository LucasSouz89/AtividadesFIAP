using System;
using System.Collections;
using UnityEngine;

public class Atividade : MonoBehaviour
{
    //Atributos
    public string nome;
    public int vida;
    public string[] armas = new string[4];

    IEnumerator Tempo()
    {
        //Condi��o para que os atributos sejam preenchidos
        if (nome == "" || vida <= 0 || armas[0] == "" || armas[1] == "" || armas[2] == "" || armas[3] == "")
        {
            print("Preecha os atributos");
        }
        else if (vida > 20)
        {
            print("O limite de vida deve ser 20");

        }
        else
        {
            print("Seu nome: " + nome);
            yield return new WaitForSeconds(4.0f);
            print("Sua vida: " + vida);
            yield return new WaitForSeconds(4.0f);
            print("Suas armas:");
            //Listar todas as arma no console
            foreach (string i in armas)
            {
                print(i);
                yield return new WaitForSeconds(2.0f);
            }

            print(nome + " chega ao perigo!");
            yield return new WaitForSeconds(4.0f);

            if (vida_Morte(7))
            {
                yield return new WaitForSeconds(4.0f);
                print(nome + " chega � segunda fase");
                yield return new WaitForSeconds(4.0f);

                if (vida_Morte(8))
                {
                    yield return new WaitForSeconds(4.0f);
                    print(nome + " chega � terceira fase");
                    yield return new WaitForSeconds(4.0f);

                    if (vida_Morte(10))
                    {
                        
                        yield return new WaitForSeconds(4.0f);
                        print("Voc� venceu!");
                    }
                }
            }
        }
    }
     //Condi��o para verificar se a vida ser� maior ou menor que zero
    bool vida_Morte(int dano)
    {
        print("Sua vida: " + vida + " dano do inimigo: " + dano + " = " + (vida - dano));
        if ((vida - dano) <= 0)
        {
            
            print("Fim de jogo");
            return false;
        }
        print("EM JOGO");
        return true;
    }
    
    void Start()
    {
        StartCoroutine(Tempo());
    }
}