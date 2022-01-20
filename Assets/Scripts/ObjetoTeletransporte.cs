using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoTeletransporte : MonoBehaviour
{
    public GameObject jugador;
    public GameObject jugador_posicion;
    public GameObject camara;
    public Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entra en función");
        if (collision.collider == jugador.gameObject.GetComponentsInChildren<BoxCollider>()[0])
        {
            Debug.Log("Entra en if");
            jugador_posicion.transform.position = posicion;
            //jugador.transform.position = new Vector3(0f, 1.04f,0);
            //Vector3 posicion_camara = new Vector3(0.1999969f, 1.9f, -4.096f);
            //camara.transform.position = posicion;//+ posicion_camara;

        }
    }
}
