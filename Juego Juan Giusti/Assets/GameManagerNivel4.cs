using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.UI;

public class GameManagerNivel4 : MonoBehaviour {

    public int puntajeParaGanar;
    public int tiempoParaPerder;
    private ScoreManager scoreManager;
    private TimeManager timeManager;
    public AudioMixerSnapshot snapshotGanar;
    public AudioMixerSnapshot snapshotNormal;
    public AudioSource sonidoGanar;
    public GameObject canvasGanar;
    public GameObject canvasUI;
    public GameObject canvasPerder;
    public GameObject mensajeAlPerderPorTiempo;
    private Vida vidaJugador;
    int flag = 0;

    void Awake()
    {
        GameObject managerScore = GameObject.Find("ScoreManager");
        GameObject managerTiempo = GameObject.Find("TimeManager");

        if (managerScore != null)
        {
            scoreManager = managerScore.GetComponent<ScoreManager>();
        }
        else
        {
            Debug.LogError("Error. No hay objeto ScoreManager");
        }

        if (managerTiempo != null)
        {
            timeManager = managerTiempo.GetComponent<TimeManager>();
        }
        else
        {
            Debug.LogError("Error. No hay objeto TimeManager");
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

        if (scoreManager.score == this.puntajeParaGanar)
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
        else
        {
            if (timeManager.tiempo == this.tiempoParaPerder)
            {
                if (flag == 0)
                {
                    canvasUI.GetComponent<Canvas>().enabled = false;
                    canvasGanar.GetComponent<Canvas>().enabled = false;
                    canvasPerder.GetComponent<Canvas>().enabled = true;
                    Text mensajePerder = mensajeAlPerderPorTiempo.GetComponent<Text>();
                    mensajePerder.text = "Tiempo agotado... Perdiste";                  
                    flag = 1;
                }
                
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
