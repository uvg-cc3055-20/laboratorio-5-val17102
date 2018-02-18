//Nombre: Miguel Valle Quinto
//Carnet: 17102
//Fecha: 17/02/2018
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {


    Rigidbody2D rb2d;
    SpriteRenderer sr;
    Animator anim;
    private float speed = 5f;
    private float jumpForce = 250f;
    private bool facingRight = true;
    public LayerMask layerMask;
    public GameObject feet;


	void Start () { //Le asigna a las variables el Rigidbody2D, SpriteRenderer y Animator del personaje
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
	

	void Update () {
        float move = Input.GetAxis("Horizontal"); //Si se puede mover el personaje en el eje x
        if (move != 0) {
            rb2d.transform.Translate(new Vector3(1, 0, 0) * move * speed * Time.deltaTime);//Se mueve
            facingRight = move > 0;
        }

        anim.SetFloat("Speed", Mathf.Abs(move));

        sr.flipX = !facingRight;

        if (Input.GetButtonDown("Jump")) {
            RaycastHit2D raycast = Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f, layerMask);//Lanza un raycast hacia bajo hasta los pies del personaje
            if (raycast.collider != null) //Si los pies estan tocando algo permite el salto
            rb2d.AddForce(Vector2.up*jumpForce);
        }
	}
}
