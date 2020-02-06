using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;

    private Aviao aviao;

    private Pontuacao pontuacao;

    private void Start()
    {
        aviao = GameObject.FindObjectOfType<Aviao>();
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    public void ResetGame()
    {
        Time.timeScale = 1;
        this.imagemGameOver.SetActive(false);

        this.aviao.ResetGame();

        this.pontuacao.ResetGame();

        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach (Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
    
    public void GameOver()
    {
        Time.timeScale = 0;
        this.imagemGameOver.SetActive(true);
    }
}
