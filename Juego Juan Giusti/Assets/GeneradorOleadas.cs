using UnityEngine;
using System.Collections;

public class GeneradorOleadas : MonoBehaviour {

    public GameObject prefab;

	void Awake()
    {
        InvokeRepeating("Oleadas", 0, 15);
    }

    public void Oleadas()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
