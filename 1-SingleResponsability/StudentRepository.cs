using System.Text;

namespace SingleResponsability
{
    public class StudentRepository
    {
        private static FakeStorage<Student> storage;

        // seria la  este seria nuestro oncreate de la app
       
        public StudentRepository()
        {
            storage = new();
            InitData();
        }

        private void InitData()
        {
            storage.Add(new Student(1, "Pepito Pérez", new List<double>() {3,4.5,2}));
            storage.Add(new Student(2, "Mariana Lopera", new List<double>() {4,5,1,2}));
            storage.Add(new Student(3, "José Molina", new List<double>() {2,3}));
        }

        public IEnumerable<Student> GetAll() 
        {
            return storage.GetAll();
        }
        
        
        //ya tenemos una clase mas limpia nunca se debio poner alli todo ese fracmento que corresponde a exporta unicamente

        // public void Export() 
        // {
        //     IEnumerable<Student> students = this.GetAll();
        //     string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
        //     System.Text.StringBuilder sb = new System.Text.StringBuilder();
        //     sb.AppendLine("Id;Fullname;Grades");
        //     foreach (var item in students)
        //     {
        //         sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
        //     }
        //     System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
        // }
    }
}