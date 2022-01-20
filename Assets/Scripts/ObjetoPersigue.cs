using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoPersigue : MonoBehaviour
{
	public Transform target; 
	private float moveSpeed = 3;
	private float rotationSpeed = 6;
	private Transform myTransform;
	public float umbral;

	void Awake()
	{
		myTransform = transform;
	}


	void Start()
	{
		//target = GameObject.FindWithTag("Player").transform; //target the player

	}


	void Update()
	{
		//Calcular distancia
		float distancia;
		distancia = Vector3.Distance(target.transform.position, transform.position);

		//Si la distancia es menor a 4
		if (distancia < umbral && distancia > 1)
		{
			//Voltear
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
			Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
			//Caminar
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
			//Lineas de debug que aparecen en la ventana Scene
			Debug.DrawLine(target.transform.position, transform.position, Color.red, Time.deltaTime, false);
		}
	}
}
