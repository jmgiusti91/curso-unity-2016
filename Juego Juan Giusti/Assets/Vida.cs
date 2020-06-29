using UnityEngine;
using System.Collections;

public class Vida : MonoBehaviour {

    public int cantidad;
    public GameObject explosion;
    public AudioSource sonidoExplosion;
    int flag = 0;

	void Update () {
        if (cantidad <= 0)
        {
            if ((gameObject.tag == "EnemigoBala" || gameObject.tag == "EnemigoBomba" || gameObject.tag == "EdificioPuntaje") && flag == 0)
            {
                sonidoExplosion.Play();
                Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
                flag = 1;
                Invoke("Explotar", 0.3f);
            }

            if (gameObject.tag == "JugadorPrincipal" && flag == 0)
            {
                sonidoExplosion.Play();
                Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
                flag = 1;
                Invoke("Explotar", 0.6f);
            }
             
        }
	}

    void Explotar()
    {
        
        Destroy(gameObject);
        if (gameObject.tag == "EnemigoBala" || gameObject.tag == "EnemigoBomba" || gameObject.tag == "EdificioPuntaje")
        {
            SendMessage("Mori");
        }
    }
}
