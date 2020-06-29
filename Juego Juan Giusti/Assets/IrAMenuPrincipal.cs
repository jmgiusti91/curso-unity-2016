using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IrAMenuPrincipal : MonoBehaviour {

    public AudioSource sonidoBoton;
	public void IrAMenu()
	{
        sonidoBoton.Play();
        Invoke("CambiarEscena", 0.5f);
	}

    public void CambiarEscena() 
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
