using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController: MonoBehaviour
{
  

    public int speed;
    private LaserPooler _laserPooler;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    public void SetLaserPooler(LaserPooler laserPooler)
    {
        _laserPooler = laserPooler;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "WallUp")
        {
            _laserPooler.DesativateBullet(this.gameObject);
        }
    }
}
