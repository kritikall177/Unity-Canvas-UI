using System;

public class WindowParameters
{
    public Type Type { get; private set; }
    public int IndexInList { get; private set; } = -1;

    public void SetType<T>() where T : Human
    {
        Type = typeof(T);
    }

    public void SetTypeFrom(Type type)
    {
        Type = type;
    }


    public void SetIndex(int index)
    {
        IndexInList = index;
    }
}