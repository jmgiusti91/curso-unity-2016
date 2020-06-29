using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SiguienteNivel : MonoBehaviour {

    public string nuevoNivel;
    public AudioMixerSnapshot snapshotNormal;

    public void PasarDeNivel() 
    {
        snapshotNormal.TransitionTo(1);
        SceneManager.LoadScene(nuevoNivel);
    }
}
