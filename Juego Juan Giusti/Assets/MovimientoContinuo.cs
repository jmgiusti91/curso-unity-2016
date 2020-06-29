using UnityEngine;
using System.Collections;

public class MovimientoContinuo : MonoBehaviour {

    public float velocidadX;
    public float velocidadY;
    public float velocidadZ;
	
	void Update () {
        transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, velocidadZ * Time.deltaTime);
	}
}
