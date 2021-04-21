using System;
public enum InputTypes{
    FireDown,
    LeftDown,
    RightDown,
    FireUP,
    LeftUP,
    RightUP,
}
public class InputEventArgs : EventArgs
{
    public InputTypes InputType;
    public InputEventArgs() { }
    public InputEventArgs(InputTypes _inputType)
    {
        InputType = _inputType;
    }
}
