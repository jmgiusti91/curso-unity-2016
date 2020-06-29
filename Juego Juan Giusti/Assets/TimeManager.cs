using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

    public int tiempo = 0;

    void Awake()
    {
        InvokeRepeating("TiempoTranscurrido", 0, 1);
    }

    void TiempoTranscurrido()
    {
        this.tiempo += 1;
    }
}
