using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System.Collections;

public class GameManagerNivel1 : MonoBehaviour {

    public int enemigosAMorir;
    private EnemyManager enemyManager;
    public AudioMixerSnapshot snapshotGanar;
    public AudioMixerSnapshot snapshotNormal;
    public AudioSource sonidoGanar;
    public GameObject canvasGanar;
    public GameObject canvasUI;
    public GameObject canvasPerder;
    private Vida vidaJugador;

    int flag = 0;

    void Awake()
    {
        GameObject manager = GameObject.Find("EnemyManager");

        if (manager != null)
        {
            enemyManager = manager.GetComponent<EnemyManager>();
        }
        else
        {
            Debug.LogError("No se encontro objeto EnemyManager");
        }
    }

    void Start() 
    {
        canvasUI.GetComponent<Canvas>().enabled = true;
        canvasGanar.GetComponent<Canvas>().enabled = false;
        canvasPerder.GetComponent<Canvas>().enabled = false;
        GameObject jugador = GameObject.Find("Jugador");
        vidaJugador = jugador.GetComponent<Vida>();
    }

	void Update () {

        if (this.enemigosAMorir == enemyManager.muertos)
        {
            //Application.LoadLevel("Nivel2"); //Arroja advertencia de que application.loadlevel esta obsoleta.
            if (flag == 0)
            {
                canvasUI.GetComponent<Canvas>().enabled = false;
                canvasGanar.GetComponent<Canvas>().enabled = true;
                canvasPerder.GetComponent<Canvas>().enabled = false;
                snapshotGanar.TransitionTo(1);
                sonidoGanar.Play();
                flag = 1;
            }
        }

        if (vidaJugador.cantidad == 0)
        {
            Invoke("YaMori", 1.5f);
            
        }

	}

    void YaMori() 
    {
        canvasUI.GetComponent<Canvas>().enabled = false;
        canvasGanar.GetComponent<Canvas>().enabled = false;
        canvasPerder.GetComponent<Canvas>().enabled = true;
    }
}
