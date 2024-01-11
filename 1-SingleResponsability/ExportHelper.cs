using System;
using System.Text;

namespace SingleResponsability
{
    public class ExportHelper
    {
    
    
    // solo tiene la responsabilidad de exportar datos. al crear el objeto el constructor me crea todos los datos
        private Random randomGenerator = new Random();
        public void ExportStudent(IEnumerable<Student> students)
        {
            string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");
            
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
           int numeroAleato = randomGenerator.Next(1,100);
           System.IO.File.WriteAllText(System.IO.Path.Combine
           (AppDomain.CurrentDomain.BaseDirectory,"Students"+numeroAleato.ToString()+".csv"), sb.ToString(), Encoding.Unicode);
        }
    }

}
