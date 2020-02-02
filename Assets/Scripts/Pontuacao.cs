using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;

    private int pontos = 0;

    public void adicionarPonto()
    {
        this.pontos++;
        //Debug.Log(this.pontos);
        this.textoPontuacao.text = this.pontos.ToString();
        this.GetComponent<AudioSource>().Play();
    }

    public void ResetGame()
    {
        pontos = 0;
        this.textoPontuacao.text = "0";
    }
}
