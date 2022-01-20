using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoQuitaObstaculos : MonoBehaviour
{

    public GameObject jugador;
    public GameObject muro;
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
        if (collision.collider == jugador.gameObject.GetComponent<BoxCollider>())
        {
            Debug.Log("Entra en if");
            muro.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            
        }
    }
}
