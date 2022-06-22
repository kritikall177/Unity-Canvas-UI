public static class StringExtension
{
    public static Person StringToPersonEnum(this string str)
    {
        switch (str)
        {
            case"Student":
                return Person.Student;
            case"Employee":
                return Person.Employee;
            case"Driver":
                return Person.Driver;
        }

        return Person.Human;
    }
}
