using UnityEngine;
using System.Collections;

public class VelocidadPowerUp : MonoBehaviour {

    public float bonus;
    public GameObject prefabParticulas;
    public AudioSource sonidoVelocidad;
    MovimientoPersonaje mp;
	
	public void OnTriggerEnter(Collider c)
    {
        mp = c.gameObject.GetComponent<MovimientoPersonaje>();
        if (mp != null)
        {
            sonidoVelocidad.Play();
            Invoke("AumentarVelocidad", 0.2f);
        }
        
    }

    void AumentarVelocidad()
    {
        mp.velocidadMovimiento += bonus;
        Instantiate(prefabParticulas, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
    }
}
