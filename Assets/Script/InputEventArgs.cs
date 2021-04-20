using System;
public enum InputTypes{
    Fire
}
public class InputEventArgs : EventArgs
{
    public object Sender;
    public InputTypes InputType;
    public InputEventArgs(Object _sender)
    {
        Sender = _sender;
    }
    public InputEventArgs(Object _sender, InputTypes _inputType)
    {
        Sender = _sender;
        InputType = _inputType;
    }
}
