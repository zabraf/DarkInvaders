using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenLight : MonoBehaviour
{
    public MonoBehaviour lightLeft;
    public MonoBehaviour lightRight;
    public MonoBehaviour lightShoot;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.OnInputEvent += InputManager_OnInputEvent;
        lightLeft.enabled = false;
        lightRight.enabled = false;
        lightShoot.enabled = false;
    }

    private void InputManager_OnInputEvent(object sender, InputEventArgs e)
    {
        if (e.InputType == InputTypes.LeftDown)
            lightLeft.enabled = true;
        if (e.InputType == InputTypes.RightDown)
            lightRight.enabled = true;
        if (e.InputType == InputTypes.FireDown)
            lightShoot.enabled = true;
        //light off
        if (e.InputType == InputTypes.LeftUP)
            lightLeft.enabled = false;
        if (e.InputType == InputTypes.RightUP)
            lightRight.enabled = false;
        if (e.InputType == InputTypes.FireUP)
            lightShoot.enabled = false;
    }
}
