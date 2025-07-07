using System;
using TMPro;
using UnityEngine;

public class TextoRandomizado : MonoBehaviour
{
    public string novoTexto;
    public TextMeshProUGUI UItexto;

    public int numero;
   
    private void Start()
    {
        UItexto.text = novoTexto + "  " + numero;
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && numero > 0)
        {
            numero--;
            UItexto.text = novoTexto + "  " + numero;
        }
    }
}
