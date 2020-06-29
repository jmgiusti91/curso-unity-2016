using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class IrANivelDePrueba : MonoBehaviour {

    public AudioSource sonidoComenzar;
    public void CargarNivelDePrueba() 
    {
        sonidoComenzar.Play();
        EditorSceneManager.LoadScene("NiveldePrueba");
    }
}
