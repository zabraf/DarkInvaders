using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyController : AbstractShoot
{
    public int speed;

    void Update()
    {            
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "WallRight" || collision.gameObject.tag == "WallLeft")
        {
            speed *= -1;
        }
    }
}
