using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoTeletransporte : MonoBehaviour
{
    public GameObject jugador;
    public GameObject jugador_posicion;
    public Vector3 posicion;
    public GameObject arbol;
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
        Debug.Log("Entra en función  " + posicion.x.ToString() + "   " + posicion.y.ToString() + "  " + posicion.z.ToString() + "");
        if (collision.collider == jugador.gameObject.GetComponent<BoxCollider>())
        {
            Debug.Log("Entra en if dentro del colisión");
            jugador_posicion.transform.position = arbol.transform.position;
            Debug.Log("sale en if dentro del colisión");
            //jugador.transform.position = new Vector3(0f, 1.04f,0);
            //Vector3 posicion_camara = new Vector3(0.1999969f, 1.9f, -4.096f);
            //camara.transform.position = posicion;//+ posicion_camara;

        }
    }
}
