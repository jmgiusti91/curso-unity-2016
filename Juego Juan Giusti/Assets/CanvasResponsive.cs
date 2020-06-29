using UnityEngine;
using System.Collections;

public class CanvasResponsive : MonoBehaviour {

    public GameObject canvas1;
    public GameObject canvas2;

    void Update()
    {
        if (Screen.width < 500)
        {
            canvas1.SetActive(false);
            canvas2.SetActive(true);
        }
        else
        {
            canvas1.SetActive(true);
            canvas2.SetActive(false);
        }
    }
}
