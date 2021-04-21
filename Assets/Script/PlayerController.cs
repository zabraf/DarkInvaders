using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : AbstractShoot
{
    public float offset;
    public float speed;

    private bool isGoingLeft;
    private bool isGoingRight;
    private bool canGoRight;
    private bool canGoLeft;
    private LaserPooler laserPooler;
    
    // Start is called before the first frame update
    void Start()
    {
        InputManager.OnInputEvent += InputManager_OnInputEvent;
        laserPooler = GetComponent<LaserPooler>();
        canGoRight = true;
        canGoLeft = true;
    }

    private void InputManager_OnInputEvent(object sender, InputEventArgs e)
    {
        if (e.InputType == InputTypes.LeftDown)
            isGoingLeft = true;
        if (e.InputType == InputTypes.RightDown)
            isGoingRight = true;
        if (e.InputType == InputTypes.FireDown)
            askLaserNotification(transform, false);
        //light off
        if (e.InputType == InputTypes.LeftUP)
            isGoingLeft = false;
        if (e.InputType == InputTypes.RightUP)
            isGoingRight = false;
    }


    // Update is called once per frame
    void Update()
    {

        //mouvement
        if (isGoingLeft && canGoLeft)
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y,transform.position.z);
        }
        if (isGoingRight && canGoRight)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
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
