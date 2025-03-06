 namespace Academy.Day1
{
    internal class Program
    {
        static int studByCourse = 9;
        static int maxCourseCount = 10;
        
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

            string[] students = new string[10];
            string[,] courses = new string[maxCourseCount, 1 + studByCourse];


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
                        addStudent(students);
                        break;
                    case "2":
                        showAllStudents(students);
                        break;
                    case "3":
                        addCourse(courses);
                        break;
                    case "4":
                        addStudByCourse(courses, students);
                        break;
                    case "5":
                        showAllStudByCourse(courses);
                        break;
                    case "6":
                        delStudent(students);
                        break;
                    case "7":
                        delCourses(courses);
                        break;
                    case "8":
                        showAllStudByCourse(courses);
                        break;
                    case "9":
                        delStudentByCourse(students, courses);
                        break;
                    case "10":
                        searchStudent(students);
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

        private static void addStudent(string[] students)
        {
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
        }
        private static void showAllStudents(string[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    Console.WriteLine($"{i + 1}. {students[i]}");
                }
            }
        }
        private static void showAllCourses(string[,] courses)
        {
            Console.WriteLine("Курсы:");
            for (int i = 0; i < maxCourseCount; i++)
            {
                if (courses[i, 0] != null)
                {
                    Console.WriteLine($"{i + 1}. {courses[i, 0]}");
                }
            }
        }
        private static void addCourse(string[,] courses)
        {
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
        }
        private static void addStudByCourse(string[,] courses, string[] students)
        {
            showAllCourses(courses);
            Console.Write("Выберите курс:");
            int courseId = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Студенты:");
            showAllStudents(students);
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
        }
        private static int showAllStudByCourse(string[,] courses)
        {
            showAllCourses(courses);
            Console.Write("Выберите курс:");
            int courseId = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine($"Студенты курса '{courses[courseId, 0]}'");
            for (int i = 1; i < studByCourse; i++)
            {
                if (courses[courseId, i] != null)
                    Console.WriteLine($"{i}. {courses[courseId, i]}");
            }

            return courseId;
        }
        private static void delStudent(string[] students)
        {
            showAllStudents(students);
            Console.Write("Выберите студента: ");
            int studentId6 = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"Студент {students[studentId6]} удалён");
            for (int i = studentId6; i < students.Length - 1; i++)
            {
                students[i] = students[i + 1];
            }
        }
        private static void delCourses(string[,] courses)
        {
            showAllCourses(courses);
            Console.Write("Выберите курс: ");
            int courseId6 = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"Курс {courses[courseId6, 0]} удалён");
            for (int i = 0; i < studByCourse + 1; i++)
            {
                courses[courseId6, i] = null;
            }
        }
        private static void showAllStudByALlCourse(string[,] courses)
        {
            for (int i = 0; i < maxCourseCount; i++)
            {
                if (courses[i, 0] != null)
                {
                    Console.WriteLine($"{i + 1}. {courses[i, 0]}");
                    for (int j = 1; j < studByCourse + 1; j++)
                    {
                        if (courses[i, j] != null)
                            Console.WriteLine($"   {j}. {courses[i, j]}");
                    }
                }
            }

        }
        private static void delStudentByCourse(string[] students, string[,] courses)
        {
            int courseId = showAllStudByCourse(courses);
            Console.Write("Выберите студента: ");
            int studentId = int.Parse(Console.ReadLine()); 
            Console.WriteLine($"Студент {courses[courseId, studentId]} снят с курса");
            for (int i = studentId; i < studByCourse - 1; i++)
            {
                courses[courseId, i] = courses[courseId, i + 1];
            }
        }
        private static void searchStudent(string[] students)
        {
            Console.Write("Введите имя: ");
            string studName1 = Console.ReadLine();
            bool isFind = false;
            for (int i = 0; i < students.Length; i++)
            {
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
        }

    }
}
