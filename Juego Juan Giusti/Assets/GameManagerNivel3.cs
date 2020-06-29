using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System.Collections;

public class GameManagerNivel3 : MonoBehaviour {

    public int tiempoParaGanar;
    public int enemigosAMorir;
    private EnemyManager enemyManager;
    private TimeManager timeManager;
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
        GameObject managerEnemigos = GameObject.Find("EnemyManager");
        GameObject managerTiempo = GameObject.Find("TimeManager");

        if (managerEnemigos != null)
        {
            enemyManager = managerEnemigos.GetComponent<EnemyManager>();
        }
        else
        {
            Debug.LogError("Error. No hay EnemyManager en la escena");
        }


        if (managerTiempo != null)
        {
            timeManager = managerTiempo.GetComponent<TimeManager>();
        }
        else
        {
            Debug.LogError("Error. No hay TimeManager en la escena");
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

        if (this.tiempoParaGanar == timeManager.tiempo || this.enemigosAMorir == enemyManager.muertos)
        {
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
        flag = 1;
    }
}
