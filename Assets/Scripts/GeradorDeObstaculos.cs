using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar = 1;

    [SerializeField]
    private GameObject manualDeIntrucoes;

    private float cronometro;

    void Awake()
    {
        cronometro = this.tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;

        if (this.cronometro <= 0)
        {
            GameObject.Instantiate(this.manualDeIntrucoes, this.transform.position, Quaternion.identity);
            cronometro = this.tempoParaGerar;
        }
    }
}
