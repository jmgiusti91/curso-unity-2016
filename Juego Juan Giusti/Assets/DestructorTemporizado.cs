using UnityEngine;
using System.Collections;

public class DestructorTemporizado : MonoBehaviour {

	void Awake()
    {
        Invoke("Destruirse", 5);
    }

    public void Destruirse()
    {
        Destroy(gameObject);
    }
}
