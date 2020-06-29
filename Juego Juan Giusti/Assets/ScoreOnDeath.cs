using UnityEngine;
using System.Collections;

public class ScoreOnDeath : MonoBehaviour {

    public int puntosGanados;
    private ScoreManager scoreManager;

    void Awake()
    {
        GameObject manager = GameObject.Find("ScoreManager");

        if (manager != null)
        {
            scoreManager = manager.GetComponent<ScoreManager>();
        }
        else
        {
            Debug.LogError("Error. No se encontro el objeto ScoreManager");
        }
    }

    void Mori()
    {
        scoreManager.score += this.puntosGanados;
    }
}
