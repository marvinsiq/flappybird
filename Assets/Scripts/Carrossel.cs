using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 5f;

    private Vector3 posicaoInicial;
    private float tamanhoRealImagem;

    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log(this.transform.position);
        this.posicaoInicial = this.transform.position;
        float tamanhoImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoRealImagem = tamanhoImagem  * escala;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoRealImagem);
        this.transform.position = 
            this.posicaoInicial + Vector3.left * deslocamento;
    }
}
