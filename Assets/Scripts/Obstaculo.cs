using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.1f;

    [SerializeField]
    private float variacaoPosicaoY = 1.3f;

    private Vector3 posicaoDoAviao;

    private bool pontuei = false;

    private Pontuacao pontuacao;

    private void Start()
    {
        this.posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoPosicaoY, variacaoPosicaoY));
    }

    private void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);

        if (!this.pontuei && this.transform.position.x < this.posicaoDoAviao.x)
        {
            this.pontuei = true;
            this.pontuacao.adicionarPonto();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Colidiu
        Destruir();
    }

    public void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
