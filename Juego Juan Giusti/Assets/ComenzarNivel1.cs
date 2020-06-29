using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ComenzarNivel1 : MonoBehaviour {

    public AudioSource sonidoBoton;
	public void CargarNivel()
    {
        sonidoBoton.Play();
        Invoke("CambiarEscena", 0.5f);
    }

    public void CambiarEscena() 
    {
        SceneManager.LoadScene("Nivel1");
    }
}
