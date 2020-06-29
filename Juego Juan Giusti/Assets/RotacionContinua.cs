using UnityEngine;
using System.Collections;

public class RotacionContinua : MonoBehaviour {

    public float velocidadX;
    public float velocidadY;
    public float velocidadZ;
	
	void Update () {
        transform.Rotate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, velocidadZ * Time.deltaTime);
	}
}
