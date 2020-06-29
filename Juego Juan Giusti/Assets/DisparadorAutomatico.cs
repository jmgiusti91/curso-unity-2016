using UnityEngine;
using System.Collections;

public class DisparadorAutomatico : MonoBehaviour {

    public GameObject prefab;
    public AudioSource disparos;

    void Awake() {
        InvokeRepeating("Disparar", 0, 0.4f);
    }

    public void Disparar() {

        /*Vector3 posicion = transform.position;
        posicion.Set(transform.position.x + 1, transform.position.y, transform.position.z + 2);
        Instantiate(prefab, posicion, transform.rotation);*/
        prefab.tag = "BalasEnemigo";
        Instantiate(prefab, transform.position, transform.rotation);
        disparos.Play();
    }
}