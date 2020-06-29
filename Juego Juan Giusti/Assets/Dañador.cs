using UnityEngine;
using System.Collections;

public class Dañador : MonoBehaviour {

    public int daño;
    public AudioSource sonidoMetalico;
    Vida v;

	public void OnTriggerEnter(Collider c)
    {
        v = c.gameObject.GetComponent<Vida>();
        if (v != null)
        {
            if (gameObject.tag == "BalasJugador" && c.gameObject.tag == "JugadorPrincipal")
            {
                return;

            } else if(gameObject.tag == "BalasEnemigo" && c.gameObject.tag == "EnemigoBala")
            {
                return;
            }
            else
            {
                sonidoMetalico.Play();
                Invoke("Dañar", 0.2f);
            }
        }
    }

    void Dañar()
    {
        if (v != null)
        {
            v.cantidad -= daño;
            Destroy(gameObject);
        }   
    }
}
