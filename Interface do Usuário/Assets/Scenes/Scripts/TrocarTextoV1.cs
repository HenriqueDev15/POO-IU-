using TMPro;
using UnityEngine;

public class TrocarTextoV1 : MonoBehaviour
{
    public string texto;
    public TextMeshProUGUI textoUi;

    public void TrocarTextoUI()
    {
        textoUi.text = texto;
    }
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
