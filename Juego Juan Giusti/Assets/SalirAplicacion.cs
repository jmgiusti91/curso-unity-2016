using UnityEngine;
using System.Collections;

public class SalirAplicacion : MonoBehaviour {

    public AudioSource sonidoSalir;
	public void Salir()
	{
        sonidoSalir.Play();
        Invoke("CambiarEscena", 0.5f);
        
	}

    public void CambiarEscena() 
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
