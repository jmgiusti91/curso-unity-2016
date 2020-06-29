using UnityEngine;
using System.Collections;

public class Disparador : MonoBehaviour {

    public GameObject prefab;
    public string nombreAccion;
    public AudioSource disparos;

	void Update () {
        if (Input.GetButtonDown(nombreAccion))
        {
            InvokeRepeating("Disparar", 0, 0.3f);
        }

        if (Input.GetButtonUp(nombreAccion))
        {
            CancelInvoke("Disparar");
        }
	}


    public void Disparar()
    {
        /*Vector3 posicion = transform.position;
        posicion.Set(transform.position.x + 1, transform.position.y, transform.position.z + 1);
        Instantiate(prefab, posicion, transform.rotation);*/
        prefab.tag = "BalasJugador";
        Instantiate(prefab, transform.position, transform.rotation);
        disparos.Play();
    }
}
