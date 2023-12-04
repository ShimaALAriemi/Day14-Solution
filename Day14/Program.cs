namespace Day14
{
    internal class Program
    {
        [Flags]
        enum Gender
        {
            Male,
            Female
        }
        
        enum Months
        {
            jan,
            feb,
            mar,
            april,
            may,
            june,
            july,
            aug,
            sep,
            oct,
            nov,
            dec
        }

        [Flags]
        enum Permissions
        {
            None = 0, 
            Read = 1, 
            Write = 2,
            Delete = 4,
            Execute = 8, 

            Level1 = Read | Write,
            Admin = Read | Write | Delete,
            superAdmin = Read | Write | Delete | Execute,
        }

        public class User {
            public string name { get; set; }
            public int age { get; set; }
            public decimal money { get; set; }

            public User(string name, int age, decimal money)
            {
                this.name = name;
                this.age = age;
                this.money = money;
            }

            public static decimal operator +(User a, User b) => a.age + b.age;

            public static decimal operator -(User a, User b) => a.age - b.age;

            public static bool operator ==(User a, User b) => (a.money == b.money)? true: false;

            public static bool operator !=(User a, User b) => (a.money != b.money) ? true : false;




        }

        static void Main(string[] args)
        {
            Gender gender = Gender.Male;
            Gender[] gender1 = { (Gender)1, 0 };
            foreach(int gender2 in gender1) Console.Write(gender2);
            Console.WriteLine(gender1);

            Permissions mypermissions = Permissions.Read | Permissions.Write  ;
            if (mypermissions.HasFlag(Permissions.Admin))
            {
                Console.WriteLine("has read ");
            }

            User user1 = new User("Shaima", 24,5000);
            User user2 = new User("Noor", 12, 50);

            Console.WriteLine(user2 + user1);

            Console.WriteLine(user2 == user1);


        }
    }
}