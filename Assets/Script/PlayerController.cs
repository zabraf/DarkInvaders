using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : AbstractShoot
{

    public float offset;
    public float speed;



    private bool canGoRight;
    private bool canGoLeft;
    private LaserPooler laserPooler;
    
    // Start is called before the first frame update
    void Start()
    {
        laserPooler = GetComponent<LaserPooler>();
        canGoRight = true;
        canGoLeft = true;
    }


    // Update is called once per frame
    void Update()
    {

        //mouvement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) && canGoLeft)
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y,transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) && canGoRight)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Notify(transform, false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "WallRight")
            canGoRight = false;
        else if (collision.gameObject.tag == "WallLeft")
            canGoLeft = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "WallRight")
            canGoRight = true;
        else if (collision.gameObject.tag == "WallLeft")
            canGoLeft = true; 
    }
}
