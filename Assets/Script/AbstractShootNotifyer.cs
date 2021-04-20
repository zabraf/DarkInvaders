using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractShoot : MonoBehaviour
{
    public delegate void ShootEventHandler(ShootEventArgs e);
    public static event ShootEventHandler OnShootingEvent;


    private ShootEventArgs eventArgs;

    private void Awake()
    {
        eventArgs = new ShootEventArgs(this);

    }
    protected void Notify(Transform _pos, bool _isEnnemy)
    {
        eventArgs.Position = _pos;
        eventArgs.IsEnnemy = _isEnnemy;
        OnShootingEvent?.Invoke(eventArgs);
    }
}
