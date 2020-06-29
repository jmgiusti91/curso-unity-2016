using UnityEngine;
using System.Collections;

public class Bomba : MonoBehaviour {

    public bool explotar;

    

    void Awake () {
        Invoke("Explosion", 1.2f);
    }

    void Update()
    {
        if (Input.GetButtonDown("Explotar"))
        {
            explotar = true;
        }
    }

    public void Explosion()
    {
        explotar = true;
    }

    public void OnTriggerStay(Collider c)
    {
        if (explotar)
        {
            Destroy(c.gameObject);
            Destroy(gameObject);
        }
    }

}