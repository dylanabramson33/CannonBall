using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverScript : MonoBehaviour
{
   
    private float rotate;
    private float power;
    private Rigidbody2D rb;  

    void Start()
    { 
        rotate = this.transform.parent.GetComponent<CharacterController>().rotation;
        power = this.transform.parent.GetComponent<CharacterController>().power;
        Vector2 force = new Vector2 (30f + (power * Mathf.Cos(rotate * Mathf.PI/180)), 30f + (power * Mathf.Sin(rotate * Mathf.PI/180)));

        rb = this.GetComponent<Rigidbody2D>();
        rb.AddForce(force);
        rb.AddTorque(-power/3);



    }


}
