using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    [SerializeField]
    private float forca = 6;

    private Rigidbody2D fisica;

    private Diretor diretor;

    private Vector3 posicaoInicial;

    private void Start()
    {
        diretor = GameObject.FindObjectOfType<Diretor>();
    }

    // Start is called before the first frame update
    private void Awake()
    {
        fisica = this.GetComponent<Rigidbody2D>();
        posicaoInicial = this.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if ( Input.GetButtonDown("Fire1") )
        {
            this.Impulsionar();
        }
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.fisica.simulated = false;
        this.diretor.GameOver();
    }

    public void ResetGame()
    {
        this.transform.position = posicaoInicial;
        this.fisica.simulated = true;
    }
}
