 namespace Academy.Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить студента");
            Console.WriteLine("2. Показать всех студентов");
            Console.WriteLine("3. Добавить курс");
            Console.WriteLine("4. Записать студента на курс");
            Console.WriteLine("5. Показать студентов курса");
            Console.WriteLine("6. Удалить студента");
            Console.WriteLine("7. Удалить курс");
            Console.WriteLine("8. Показать все записи студентов на курсы");
            Console.WriteLine("9. Снятие студента с курса");
            Console.WriteLine("10. Поиск студента по имени");
            Console.WriteLine("11. Выход");

            int studByCourse = 9;
            int courseCount = 10;
            string[] students = new string[10];
            string[,] courses = new string[courseCount, 1+studByCourse];


            bool f = true;

            while (f)
            {
                Console.WriteLine();
                Console.Write("Выбрать опцию: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите имя студента: ");
                        string studName = Console.ReadLine();
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i] == null)
                            {
                                students[i] = studName;
                                Console.WriteLine($"Студент {studName} добавлен");
                                break;
                            }
                        }
                        break;
                    case "2":
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i] != null)
                            {
                                Console.WriteLine($"{i+1}. {students[i]}");
                            }
                        }
                        break;
                    case "3":
                        Console.Write("Введите название курса: ");
                        string courseName = Console.ReadLine();
                        for (int i = 0; i < courses.Length; i++)
                        {
                            if (courses[i, 0] == null)
                            {
                                courses[i, 0] = courseName;
                                Console.WriteLine($"Курс '{courseName}' добавлен");
                                break;
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Курсы:");
                        for (int i = 0; i < courseCount; i++) {
                            if (courses[i, 0] != null)
                            {
                                Console.WriteLine($"{i + 1}. {courses[i, 0]}");
                            }
                        }
                        Console.Write("Выберите курс:");
                        int courseId = int.Parse(Console.ReadLine()) - 1;

                        Console.WriteLine("Студенты:");
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i] != null)
                            {
                                Console.WriteLine($"{i + 1}. {students[i]}");
                            }
                        }
                        Console.Write("Выберите студента: ");
                        int studentId = int.Parse(Console.ReadLine()) - 1;

                        for (int i = 1; i <= studByCourse; i++)
                        {
                            if (courses[courseId, i] == null)
                            {
                                courses[courseId, i] = students[studentId];
                                break;
                            }
                        }

                        Console.WriteLine($"Студент {students[studentId]} зачислен на курс '{courses[courseId, 0]}'");
                        break;
                    case "5":
                        Console.WriteLine("Курсы:");
                        for (int i = 0; i < courseCount; i++)
                        {
                            if (courses[i, 0] != null)
                            {
                                Console.WriteLine($"{i + 1}. {courses[i, 0]}");
                            }
                        }
                        Console.Write("Выберите курс:");
                        int courseId5 = int.Parse(Console.ReadLine()) - 1;

                        Console.WriteLine($"Студенты курса '{courses[courseId5, 0]}'");
                        for (int i=1; i < studByCourse;i++)
                        {
                            if (courses[courseId5,i] != null)
                                Console.WriteLine($"{i}. {courses[courseId5, i]}");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Студенты:");
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i] != null)
                            {
                                Console.WriteLine($"{i + 1}. {students[i]}");
                            }
                        }
                        Console.Write("Выберите студента: ");
                        int studentId6 = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine($"Студент {students[studentId6]} удалён");
                        for (int i=studentId6; i < students.Length-1; i++)
                        {
                            students[i] = students[i+1];
                        }
                        break;
                    case "7":
                        Console.WriteLine("Курсы:");
                        for (int i = 0; i < courseCount; i++)
                        {
                            if (courses[i,0] != null)
                            {
                                Console.WriteLine($"{i + 1}. {courses[i,0]}");
                            }
                        }
                        Console.Write("Выберите курс: ");
                        int courseId6 = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine($"Курс {courses[courseId6,0]} удалён");
                        for (int i = 0; i <studByCourse+1; i++)
                        {
                            courses[courseId6, i] = null;
                        }
                        break;
                    case "8":
                        for (int i = 0; i < courseCount; i++)
                        {
                            if (courses[i, 0] != null)
                            {
                                Console.WriteLine($"{i + 1}. {courses[i, 0]}");
                                for (int j = 1; j < studByCourse+1; j++)
                                {
                                    if (courses[i, j] != null)
                                        Console.WriteLine($"   {j}. {courses[i, j]}");
                                }
                            }
                        }
                        break;
                    case "9":
                        Console.WriteLine("Курсы:");
                        for (int i = 0; i < courseCount; i++)
                        {
                            if (courses[i, 0] != null)
                            {
                                Console.WriteLine($"{i + 1}. {courses[i, 0]}");
                            }
                        }
                        Console.Write("Выберите курс:");
                        int courseId9 = int.Parse(Console.ReadLine()) - 1;

                        Console.WriteLine($"Студенты курса '{courses[courseId9, 0]}'");
                        for (int i = 1; i < studByCourse; i++)
                        {
                            if (courses[courseId9, i] != null)
                                Console.WriteLine($"{i}. {courses[courseId9, i]}");
                        }
                        Console.Write("Выберите студента: ");
                        int studentId9 = int.Parse(Console.ReadLine());;
                        Console.WriteLine($"Студент {courses[courseId9, studentId9]} снят с курса");
                        for (int i = studentId9; i < studByCourse - 1; i++)
                        {
                            courses[courseId9,i] = courses[courseId9, i+1];
                        }
                        break;
                    case "10":
                        Console.Write("Введите имя: ");
                        string studName1 = Console.ReadLine();
                        bool isFind = false; 
                        for (int i = 0; i < students.Length; i++){
                            if (students[i] != null && students[i].Equals(studName1))
                            {
                                Console.WriteLine($"Найден студент {i + 1}. {studName1}");
                                isFind = true;
                                break;
                            }
                        }
                        if (!isFind)
                        {
                            Console.WriteLine($"Студент с именем {studName1} не найден");
                        }
                        break;
                    case "11":
                        f = false;
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова");
                        break;
                }
            }


        }
    }
}
