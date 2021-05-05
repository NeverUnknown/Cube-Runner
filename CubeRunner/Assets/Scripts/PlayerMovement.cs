using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    //public Vector3 startPos;

    public float forwardForce;
    public float sidewaysForce;
    public float jumpForce;
    public float jumpTimeConst;
    float jumpTime = 0f;

    void Start()
    {
        //startPos = rigidbody.position;
        //rigidbody.AddForce(0,0,1000);//x y z
        //Vector3();
    }

    // Update is called once per frame
    /*void Update()
    {
        rigidbody.AddForce(0, 100 * Time.deltaTime, 500 * Time.deltaTime); //force at z-ax
    }*/

    private void FixedUpdate()
    {
        //движение вперёд
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rigidbody.AddForce(0, 0, -4500 * Time.deltaTime);
        }
        //Debug.Log("Y = " + rigidbody.position.y);
        /*if (Input.GetKey("space") && rigidbody.position.y <= 1.26f && rigidbody.position.y != 0f)
        {
            
            Debug.Log("Y = " + rigidbody.position.y);
            rigidbody.AddForce(0, jumpForce, 0);
            rigidbody.AddForce(0, -jumpForce + 300, 0);
        }*/
        jumpTime -= Time.deltaTime;
        //Debug.Log(jumpTime);
        if (Input.GetKey("space") && jumpTime <= 0)
        {
            jumpTime = jumpTimeConst;
            rigidbody.AddForce(0, jumpForce, 0);
            Invoke("jumpForceDown", 0.25f);
            //rigidbody.AddForce(0, -jumpForce + (jumpForce / 10), 0);
        }

        if (rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<Score>().scoreText.text = "YOU DIED";
        }
    }

    void jumpForceDown()
    {
        rigidbody.AddForce(0, -jumpForce * 1.2f, 0);
    }
}