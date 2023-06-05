using System;

namespace iinheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person orang01 = new Person();
            Person orang02 = new Person("Ikhsan", 19);
            karyawan karyawan01 = new karyawan("Zahra", 20);

            orang01.InfoPerson();
            orang02.InfoPerson();

            karyawan01.InfoPerson();
            karyawan01.InfoPerson("Kowad", "001122");
            Console.ReadKey();
        }
    }
}