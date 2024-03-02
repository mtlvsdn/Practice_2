using System;

enum OccupationEnum
{
    Child = 0,
    Student,
    Employee
}

namespace MyNamespace
{
    internal class PersonClass
    {
        private static void Main(string[] args)
        {
            ReferenceTypeAssignment();
        }
        private int _age;
        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int newAge)

        {
            _age = newAge;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Name2
        {
            get { return _name; }
        }
        public OccupationEnum Occupation { get; set; }

        public PersonClass(int age)
        {
            Console.WriteLine("Constructor(default");
            this._age = age;
        }

        public PersonClass(int age, string name, OccupationEnum occupation):this(age)
        {
            Console.WriteLine("Constructor(parameters)");
            Name = name;
            Occupation = occupation;
        }

        public PersonClass(PersonClass previousPerson):this(previousPerson.GetAge(), previousPerson.Name, previousPerson.Occupation)
        {
            Console.WriteLine("Copy Constructor");
        }

        ~PersonClass()
        {
            Console.WriteLine("Destructor");
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Occupation: {2}", Name, _age, Occupation);
        }

        private static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types\n");
            var personClass1 = new PersonClass(1, "Matei", OccupationEnum.Child);
            var personClass2 = personClass1;

            Console.WriteLine(personClass1);
            Console.WriteLine(personClass2);

            personClass1.Name = "Mihai";
            personClass1.SetAge(23);
            Console.WriteLine("\n=> Changed personClass1.Name and personClass1._age\n");
            Console.WriteLine(personClass1);
            Console.WriteLine(personClass2);
        }
    }
}