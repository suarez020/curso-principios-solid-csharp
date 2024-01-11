using SingleResponsability;

StudentRepository studentRepository = new();
//studentRepository.Export();
// ya no se encuentra por que estamos aplicando el single responsability

ExportHelper exportHelper = new();     //Estudent repository va a traer los datos y el otro los va a exportar son unicos.
exportHelper.ExportStudent(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");



/*
le damos un dotnet build
luego le damos un dotnet run:

el viene a la clase program   crea un objeto student repository
luego de crear un objeto student repository hace un dotnet run.
*/