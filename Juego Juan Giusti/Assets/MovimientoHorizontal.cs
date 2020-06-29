using UnityEngine;
using System.Collections;

public class MovimientoHorizontal : MonoBehaviour {

    public int velocidadX;
    //private int contador = 0;

    void Awake()
    {
        InvokeRepeating("CambiarVelocidadIzq", 0, 0.2f);
    }

	void CambiarVelocidadIzq() {
        gameObject.transform.Translate(velocidadX * Time.deltaTime, 0, 0);
        Invoke("CambiarVelocidad", 1);
	}

    void CambiarVelocidad()
    {
        int velocidadNegativa = velocidadX * -1;
        gameObject.transform.Translate(velocidadNegativa * Time.deltaTime, 0, 0);
        CancelInvoke("CambiarVelocidadIzq");
        InvokeRepeating("CambiarVelocidadIzq", 1, 0.2f);
    }
}

