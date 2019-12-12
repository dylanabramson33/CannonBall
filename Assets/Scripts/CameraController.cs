using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool hasFiredYet;
    public GameObject Cannon;   
    private float ballX;
    private float ballY;
    private Camera camera;
    private bool hasReached; 

    void Start()
    {
        hasFiredYet = false;
        hasReached = false;
    }

    // Update is called once per frame
    void Update()
    {   
        if (hasFiredYet) {

            camera = this.GetComponent<Camera>();
            ballX = Cannon.GetComponent<Fire1>().ballObj.transform.position.x;
            ballY = Cannon.GetComponent<Fire1>().ballObj.transform.position.y;
            if (!hasReached) {
                StartCoroutine("pivotToCharacter");

            }
            else (hasReached)
            {
                transform.position = new Vector3(ballX, ballY, -10);

            }


        }
    }

    private IEnumerator pivotToCharacter()
    {
        while(transform.position.x  < ballX || transform.position.y  < ballY )
        {
            if (transform.position.x < ballX)
            {   
                transform.position = new Vector3(transform.position.x + .25f, transform.position.y, -10);
            }
            if (transform.position.y < ballY)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + .25f, -10);
            }


            yield return new WaitForSeconds(.1f);

        }
        hasReached = true;
    }
}
