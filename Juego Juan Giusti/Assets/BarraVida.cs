using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {

    public Vida vida;
    public Image barra;

    void Start()
    {
        barra.fillAmount = (float)(vida.cantidad / 100);
    }
	
	void Update () {
        float vidaRestante = vida.cantidad;
        float numero = vidaRestante / 100;
        barra.fillAmount = numero;
    }
}
