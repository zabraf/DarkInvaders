using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static event EventHandler<InputEventArgs> OnInputEvent;
    private InputEventArgs inputEventArgs;
    private void Start()
    {
        inputEventArgs = new InputEventArgs();
    }
    void Update()
    {
        
        //mouvement
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            inputEventArgs.InputType = InputTypes.LeftDown;
            OnInputEvent?.Invoke(this, inputEventArgs);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            inputEventArgs.InputType = InputTypes.RightDown;
            OnInputEvent?.Invoke(this, inputEventArgs);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inputEventArgs.InputType = InputTypes.FireDown;
            OnInputEvent?.Invoke(this, inputEventArgs);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            inputEventArgs.InputType = InputTypes.LeftUP;
            OnInputEvent?.Invoke(this, inputEventArgs);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            inputEventArgs.InputType = InputTypes.RightUP;
            OnInputEvent?.Invoke(this, inputEventArgs);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            inputEventArgs.InputType = InputTypes.FireUP;
            OnInputEvent?.Invoke(this, inputEventArgs);
        }


    }
}
