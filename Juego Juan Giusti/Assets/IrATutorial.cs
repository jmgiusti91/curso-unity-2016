using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class IrATutorial : MonoBehaviour {

    public AudioSource sonidoBoton;
    public void IrAlTuto() 
    {
        sonidoBoton.Play();
        Invoke("CambiarEscena", 0.5f);
        
    }

    public void CambiarEscena() 
    {
        EditorSceneManager.LoadScene("tutorial");
    }
}
