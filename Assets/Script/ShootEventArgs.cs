using System;
using UnityEngine;

public class ShootEventArgs : EventArgs
{
    public object Sender;
    public Transform Position;
    public bool IsEnnemy;
    public ShootEventArgs(object _sender)
    {
        Sender = _sender;
    }
    public ShootEventArgs(object _sender,Transform _postion, bool _isEnnemy)
    {
        Sender = _sender;
        Position = _postion;
        IsEnnemy = _isEnnemy;
    }
}
