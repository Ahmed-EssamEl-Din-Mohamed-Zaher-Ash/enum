namespace EnumProject;
using EnumProject.Enums;
using global::EnumApp;

class EnumApp
{
    static void Main(string[] args)
    {

        #region
        /*2-  Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.*/
        #endregion
        /*   foreach (Days day in Enum.GetValues(typeof(Days)))
        {
            Console.WriteLine(day);
        }*/
        /*
        3-  Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as  its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
      */
        /*  Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
        string input = Console.ReadLine();
        if (Enum.TryParse(input, true, out Season season))
        {
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring: March to May");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer: June to August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Autumn: September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter: December to February");
                    break;
                default:
                    Console.WriteLine("Invalid season entered.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid season entered.");
        }*/

        #region
        /*4-  . Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
        Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable*/
        User user = new User();
        user.Id = 1;
        user.Permissions = user.Permissions | Permission.Read;
        Console.WriteLine($" Adding : {user.Permissions}");
        user.Permissions = user.Permissions & Permission.Write;
        Console.WriteLine($" Remov : {user.Permissions}");
        user.Permissions = user.Permissions ^ Permission.Read;
        Console.WriteLine($" comping : {user.Permissions}");
        if ((user.Permissions & Permission.Delete) == Permission.Delete)
        {
            Console.WriteLine("User Has Delete Permission");
        }
        else
        {
            Console.WriteLine("User Donot  Delete Permission");
        }
        #endregion
    }
}