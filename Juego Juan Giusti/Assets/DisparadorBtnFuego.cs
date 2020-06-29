using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class DisparadorBtnFuego : MonoBehaviour {

    public GameObject prefab;
    public string nombreAccion;
    public AudioSource disparos;
    GameObject jugador;


    void Update()
    {
        jugador = GameObject.Find("Jugador");
        if (CrossPlatformInputManager.GetButtonDown(nombreAccion))
        {
            InvokeRepeating("Disparar", 0, 0.3f);
        }

        if (CrossPlatformInputManager.GetButtonUp(nombreAccion))
        {
            CancelInvoke("Disparar");
        }
    }


    public void Disparar()
    {
        prefab.tag = "BalasJugador";
        Instantiate(prefab, jugador.transform.position, jugador.transform.rotation);
        disparos.Play();
    }
}
