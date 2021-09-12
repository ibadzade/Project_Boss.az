using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Classes
{
    public class Cv
    {
        public int Id { get; set; }
        public string Speciality { get; set; }
        public string FirstSchool { get; set; }
        public int Score { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Companie> Companies { get; set; }
        public List<Language> Languages { get; set; }
        public bool IsDiplom { get; set; }

        public override string ToString()
        {
            return $@"ID : {Id}
            Speciality : {Speciality}
            School : {FirstSchool}
            Score : {Score}
            Diplom : {IsDiplom}
";
        }
        public void Show()
        {
            Console.WriteLine("==========Cv Info=======");
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Speciality : {Speciality}");
            Console.WriteLine($"School : {FirstSchool}");
            Console.WriteLine($"Score : {Score}");
            Console.WriteLine($"Diplom : {IsDiplom}");

            foreach (var item in Skills)
            {
                Console.WriteLine(item.ToString());
            }
            foreach (var item in Companies)
            {
                Console.WriteLine(item.ToString());
            }
            foreach (var item in Languages)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
