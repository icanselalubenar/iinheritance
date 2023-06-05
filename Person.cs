using System;
namespace iinheritance
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "[belum diatur]";
            Age = 0;
        }
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void InfoPerson()
        {
            Console.WriteLine("Nama saya {0}, dan umur saya {1} tahun.\n", Name, Age);
        }
    }

    public class karyawan : Person
    {
        public string KaryawanID { get; set; }
        public string subject { get; set; }

        public karyawan()
        {
            Name = "[belum diatur]";
            Age = 0;
        }
        public karyawan(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void InfoPerson(string subject, string KaryawanID)
        {
            this.subject = subject;
            this.KaryawanID = KaryawanID;

            Console.WriteLine("Saya disini sebagai {0}, dengan ID {1}", this.subject, this.KaryawanID);
        }
    }
}

