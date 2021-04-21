using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPooler: MonoBehaviour
{
   // public delegate void EventHandler<BulletEventArs>(object? sender, BulletEventArs e);
    public GameObject prefabPlayer;
    public GameObject prefabEnnemy;

    public int Poolsize = 20;
    private List<GameObject> lasersPlayer;
    private List<GameObject> lasersEnnemy;
    // Start is called before the first frame update
    void Start()
    {
        AbstractShoot.OnShootingEvent += AbstractShoot_OnShootingEvent;
        GameObject instancePlayer = null;
        GameObject instanceEnnemy = null;
        lasersPlayer = new List<GameObject>();
        lasersEnnemy = new List<GameObject>();
        for (int i = 0; i < Poolsize; i++)
        {
            instancePlayer = Instantiate(prefabPlayer,transform);
            instancePlayer.SetActive(false);
            lasersPlayer.Add(instancePlayer);
            instancePlayer.GetComponent<LaserController>().SetLaserPooler(this);

            instanceEnnemy = Instantiate(prefabEnnemy,transform);
            instanceEnnemy.SetActive(false);
            lasersEnnemy.Add(instanceEnnemy);
            instanceEnnemy.GetComponent<LaserController>().SetLaserPooler(this);

        }
    }
    private void AbstractShoot_OnShootingEvent(ShootEventArgs e)
    {
        if (e.IsEnnemy)
        {
            activateNexBullet(lasersEnnemy,e.Position);
        }
        else
        {
            activateNexBullet(lasersPlayer,e.Position);
        }
    }

    public void DesativateBullet(GameObject laser)
    {
        laser.SetActive(false);
    }

    public void activateNexBullet(List<GameObject> listes,Transform _position)
    {
        foreach (GameObject laser in listes)
        {
            if (!laser.activeInHierarchy)
            {
                laser.SetActive(true);
                laser.transform.position = _position.position;
                return;
            }
        }
    }
}
