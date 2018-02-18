//Nombre: Miguel Valle Quinto
//Carnet: 17102
//Fecha: 17/02/2018


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    private float time;
    public GameObject child1,child2;
    public bool estado = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime; //Sirve para guardar el tiempo que ha transucrrido desde el ultimo frame
        if(time >= 3f) //Cada 3 segundos se apaga o encienden los campos de fuerza
        {
            estado = !estado;
            child1.SetActive(estado);
            child2.SetActive(estado);
            time = 0;
        } 
	}
}
