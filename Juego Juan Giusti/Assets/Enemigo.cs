using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

    private EnemyManager enemyManager;
	
    void Awake()
    {
        GameObject manager = GameObject.Find("EnemyManager");
        if (manager != null)
        {
            enemyManager = manager.GetComponent<EnemyManager>();
        }
        else
        {
            Debug.LogError("No existe objeto EnemyManager");
        }
        
    }


    void Mori()
    {
        enemyManager.muertos += 1;
    }
}
