using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    [SerializeField]
    private float forca = 6;

    private Rigidbody2D fisica;

    // Start is called before the first frame update
    void Start()
    {
        fisica = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonDown("Fire1") )
        {
            this.Impulsionar();
        }
    }

    private void Impulsionar()
    {
        Debug.Log("clicou");

        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }
}
