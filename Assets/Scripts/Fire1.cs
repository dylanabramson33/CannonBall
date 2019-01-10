using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fire1 : MonoBehaviour
{
    public GameObject ball;
    public GameObject quad;
    public GameObject explosion;
    public Transform controller;
    public GameObject ballObj;
    public Camera camera; 


    public void Fireball()
    {
        Instantiate(explosion, quad.transform.position, Quaternion.Euler(0, 0, 0), controller);
        ballObj = Instantiate(ball, quad.transform.position, Quaternion.Euler(0, 0, 0),controller) as GameObject;

        StartCoroutine("waitToSetBall");


    }

    IEnumerator waitToSetBall()
    {

        for (; ; )
        {

            yield return new WaitForSeconds(1);
            camera.transform.GetComponent<CameraController>().hasFiredYet = true;
        }

    }
}
