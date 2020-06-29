using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RecargarNivel : MonoBehaviour {

    public string recargaNivel;

    public void RecargaDeNivel()
    {
        SceneManager.LoadScene(recargaNivel);
    }
}
