using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MovimientoPersonaje : MonoBehaviour {

    public float velocidadMovimiento;
    public float velocidadRotacion;
    public GameObject prefabAcelerar;
    public AudioSource motor;

    void Update()
    {
        
        if (Input.GetButtonDown("Arriba"))
        {
            motor.loop = true;
            motor.Play();
            
        }
        if (Input.GetButtonUp("Arriba"))
        {
            motor.loop = false;
            motor.Stop();
        }
    }

    void FixedUpdate() {

        float moverY = 0;
        float moverX = 0;
        Vector3 posicionAlAcelerar;
        posicionAlAcelerar.z = gameObject.transform.position.z;
        posicionAlAcelerar.y = gameObject.transform.position.y;
        posicionAlAcelerar.x = gameObject.transform.position.x - 1;

        moverY = CrossPlatformInputManager.GetAxis("Arriba");
        
        if (moverY != 0)
        {
            
            transform.Translate(0, 0, this.velocidadMovimiento * moverY * Time.deltaTime);
            Instantiate(prefabAcelerar, posicionAlAcelerar, prefabAcelerar.transform.rotation);

            Invoke("DestruirParticulas", 1);
        }
        moverX = CrossPlatformInputManager.GetAxis("Derecha");
        transform.Rotate(0, this.velocidadRotacion * moverX * Time.deltaTime, 0);
        
        if (Input.GetButton("Arriba"))
        {
            transform.Translate(0, 0, this.velocidadMovimiento * Time.deltaTime);

            Instantiate(prefabAcelerar, posicionAlAcelerar, prefabAcelerar.transform.rotation);

            Invoke("DestruirParticulas", 1);
        }
        if (Input.GetButton("Abajo"))
        {
            transform.Translate(0, 0, this.velocidadMovimiento * Time.deltaTime * -1);
        }
        if (Input.GetButton("Derecha")) 
        {
            transform.Rotate(0, this.velocidadRotacion * Time.deltaTime, 0);
        }
        if (Input.GetButton("Izquierda")) 
        {
            transform.Rotate(0, this.velocidadRotacion * Time.deltaTime * -1, 0);
        }
        
    }

    void DestruirParticulas()
    {
        GameObject particulasADestruir = GameObject.Find("ParticulasAcelerarNave(Clone)");
        Destroy(particulasADestruir);
    }
}