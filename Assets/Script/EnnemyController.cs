using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyController : AbstractShoot
{
    public int speed;
    private void Start()
    {
        StartCoroutine("Fire");    
    }
    void Update()
    {            
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        
    }

    private IEnumerator Fire()
    {
        while (true) { 
            yield return new WaitForSeconds(Random.Range(0,3));
            askLaserNotification(transform, true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "WallRight" || collision.gameObject.tag == "WallLeft")
        {
            speed *= -1;
        }
    }
}
