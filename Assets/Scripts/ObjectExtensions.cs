public static class ObjectExtensions
{
    public static Person TypeOfPerson(this object obj)
    {
        return obj.GetType().Name switch
        {
            "Student" => Person.Student,
            "Employee" => Person.Employee,
            "Driver" => Person.Driver,
            _ => Person.Null
        };
    }
}
