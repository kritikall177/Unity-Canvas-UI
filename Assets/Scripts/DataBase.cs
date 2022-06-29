using System.Collections.Generic;


public static class DataBase
{
    public static readonly List<Human> ListOfHumans = new List<Human>();
    public static readonly List<Window> ListOfWindows = new List<Window>();

    public static T GetWindow<T>() where T : Window
    {
        foreach (var window in ListOfWindows)
        {
            if (window is T resultWindow)
            {
                return resultWindow;
            }
        }

        return null;
    }
}
