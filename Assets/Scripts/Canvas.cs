using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    [SerializeField]
    private Text record;
    public void AtualizarInterfaceGrafica()
    {
        record.text = PlayerPrefs.GetInt("Record").ToString();
    }
}

