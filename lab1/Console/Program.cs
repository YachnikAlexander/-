using Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Sergei = new Student("Sergei Mikovoz", new int[] { 3, 4, 5 });
            Student Vsevolod = new Student("Vsevolod Drobish", new int[] { 7, 6, 4, 3 });
            Student Artem = new Student("Artem Zagorovskiy", new int[] { 9, 8, 7, 6, 5 });

            Student[] studs = new Student[] { Sergei, Vsevolod, Artem};
            Group.Group group = new Group.Group(2, studs);

            System.Console.WriteLine($"Group: {group.AverageScore()}");
            System.Console.WriteLine($"Sergei : {Sergei.AverageScore()}");

            System.Console.ReadKey();
        }
    }
}
