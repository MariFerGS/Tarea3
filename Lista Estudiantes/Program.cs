using System;


namespace ListaEstudiantes
{
    class Program
    {

        static int option = 0;
        static int i = 0;
        static int size = 5;
        static int size2;
        static int cont1 = 0;
        static int cont2 = 0;
        static string fem = "F";
        static string mas = "M";
        static double minors = 0;
        static int young = 0;
        static int adults = 0;





        struct list
        {
            public int studentcode;
            public string studentname;
            public string studentsex;
            public double age;

        };




        static list[] lists;

        static void count()
        {
            Console.Clear();


            Console.WriteLine("======================================================================================\n" +

                                                "                  " + "Informe Clasificación estudiantil UH\n" +
                           "=====================================================================================");
            Console.WriteLine(" ");

            Console.WriteLine("Universidad UH");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Clasificación por edad    ||   Clasificación por Género ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Menores de edad: " + minors + "        " + "||" + "     " + "Hombres:   " + cont2);
            Console.WriteLine("Jóvenes: " + "        " + young + "        " + "||" + "     " + "Mujeres:   " + cont1);
            Console.WriteLine("Adultos: " + "        " + adults + "        " + "||");
            Console.WriteLine(" ");
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("Fin del informe");
            Console.WriteLine();
            Console.WriteLine("Presione la tecla INTRO para volver al menú");


            Console.ReadKey();
        }

        static void AddStudents()
        {

            int r = 0;

            while (r != 1)
            {
                Console.Clear();
                if (i < lists.Length)
                {
                    Console.WriteLine("Universidad UH");
                    Console.WriteLine("Ingreso de Estudiantes.             ");
                    Console.WriteLine();
                    Console.Write("Digite el código:                  ");
                    lists[i].studentcode = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del estudiante:    ");
                    lists[i].studentname = Console.ReadLine();
                    Console.Write("Ingrese el sexo:     ");
                    lists[i].studentsex = Console.ReadLine();
                    if (lists[i].studentsex == fem)
                    {
                        cont1++;

                    }
                    if (lists[i].studentsex == mas)
                    {
                        cont2++;
                    }
                    Console.Write("Ingrese la edad:");
                    lists[i].age = int.Parse(Console.ReadLine());
                    if (lists[i].age <= 18)
                    {
                        minors++;

                    }
                    if (lists[i].age >= 19 && lists[i].age <= 29)
                    {
                        young++;
                    }
                    if (lists[i].age >= 30)
                    {
                        adults++;

                    }


                    Console.WriteLine("Desea agregar otro estudiante 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de estudiantes lleno...");
                    r = 1;
                    Console.ReadKey();
                }
            }


        }
        static void ShowStudents()
        {
            int reg = 0;
            Console.Clear();


            Console.WriteLine("======================================================================================\n" +

                                                "                     " + "Listado Estudiantil\n" +
                           "=====================================================================================");
            Console.WriteLine(" ");

            Console.WriteLine("Universidad UH");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Reg          Código         Nombre          Sexo           Edad    ");
            for (i = 0; i < lists.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine(reg + "             " + lists[i].studentcode + "          " + lists[i].studentname + "             " + lists[i].studentsex + "              " + lists[i].age);
            }
            Console.WriteLine(" ");
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("Fin del informe");
            Console.WriteLine();
            Console.WriteLine("Presione la tecla INTRO para volver al menú");

            Console.ReadKey();
        }


        static void SeekStudents()
        {

            int Code = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("Universidad UH");
                Console.WriteLine("Búsquedad de Estudiantes           ");
                Console.WriteLine("Digite el código del estudiante a buscar");
                Code = int.Parse(Console.ReadLine());
                for (i = 0; i < lists.Length; i++)
                {
                    if (Code == lists[i].studentcode)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Código:   " + lists[i].studentcode);
                        Console.WriteLine("Nombre:   " + lists[i].studentname);
                        Console.WriteLine("Sexo:     " + lists[i].studentsex);
                        Console.WriteLine("Edad:     " + lists[i].age);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese código");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }
        static void modifydata()
        {
            int option = 0;
            int user = 0;
            int r = 0;

            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("Universidad Hispanoamericana");
                Console.WriteLine("Modificación de Información");
                Console.WriteLine("Digite el código del estudiante a buscar");
                user = int.Parse(Console.ReadLine());
                for (i = 0; i < lists.Length; i++)
                {
                    if (user == lists[i].studentcode)
                    {

                        while (option != 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese la opcion que desea cambiar");
                            Console.WriteLine("1.Nombre");
                            Console.WriteLine("2.Sexo");
                            Console.WriteLine("3.Edad");
                            Console.WriteLine("4.Ver cambios");
                            Console.WriteLine("5.Salir");
                            option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Digite el nuevo nombre");
                                    lists[i].studentname = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Digite el sexo");
                                    lists[i].studentsex = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Ingrese la edad:");
                                    lists[i].age = int.Parse(Console.ReadLine());

                                    break;
                                case 4:

                                    Console.Clear();
                                    Console.WriteLine("Actuales Modificaciones");
                                    if (user == lists[i].studentcode)
                                    {

                                        Console.WriteLine("Nombre:   " + lists[i].studentname);
                                        Console.WriteLine("Sexo:     " + lists[i].studentsex);
                                        Console.WriteLine("Edad:   " + lists[i].age);

                                    }

                                    Console.WriteLine("Desea realizar otro cambio 0-Sí 1-No");
                                    r = int.Parse(Console.ReadLine());

                                    break;
                                case 5:
                                    break;
                            }
                        }
                    }

                    if (user != lists[i].studentcode)
                    {
                        Console.WriteLine("No se encontro ese código");


                    }
                }
            }
        }
        static void deletestudents()
        {
            int codigo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("Registro Universidad Hispanoamericana");
                Console.WriteLine("Digite el código del estudiante que desa borrar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < lists.Length; i++)
                {
                    if (codigo == lists[i].studentcode)
                    {
                        Console.Clear();

                        reg = i + 1;
                        reg = 0;
                        lists[i].studentcode = 0;
                        lists[i].studentname = "";
                        lists[i].studentsex = "";
                        lists[i].age = 0;


                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea borrar otro estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }


        static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Digite la cantidad de estudiantes a ingresar");
                size2 = int.Parse(Console.ReadLine());

                if (size2 < size)
                {
                    Console.Clear();
                    Console.WriteLine("Digite minimo 5 estudiantes");
                    Console.ReadKey();


                }

                else
                {


                    lists = new list[size2];
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Menú Principal");
                        Console.WriteLine("1. Ingreso de Estudiantes.");
                        Console.WriteLine("2. Modificación de Estudiantes.");
                        Console.WriteLine("3. Borrado de Estudiantes.");
                        Console.WriteLine("4. Búsquedad de Estudiantes.");
                        Console.WriteLine("5. Listado de Estudiantes.");
                        Console.WriteLine("6. Informe clasificación de estudiantes.");
                        Console.WriteLine("7. Salir.");
                        Console.WriteLine("Selecciones una opción");
                        option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                {
                                    AddStudents();
                                    break;
                                }
                            case 2:
                                {
                                    modifydata();
                                    break;
                                }
                            case 3:
                                {
                                    deletestudents();
                                    break;
                                }
                            case 4:
                                {
                                    SeekStudents();
                                    break;
                                }
                            case 5:
                                {
                                    ShowStudents();
                                    break;
                                }
                            case 6:
                                {
                                    count();
                                    break;
                                }
                            case 7:

                                break;
                            default:
                                {
                                    Console.WriteLine("Seleccione inválida..");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                        }

                    }  while (size2 >= size && option !=7);
                }
            }while (option != 7);
        }
    }
}

