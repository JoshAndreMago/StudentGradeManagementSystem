using System;

namespace StudentGradeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PUP STUDENT GRADE MANAGEMENT SYSTEM");

            Console.WriteLine("Enter 1 - for Faculty Login");
            Console.WriteLine("Enter 2 - for Student Login");
            Console.WriteLine("Enter x - to exit");

            Console.Write("User Input: ");

            string facultyNumber = "2015ABC";
            string checkLogin = Console.ReadLine();

            string studentNumber = "2024-00556-BN-0";

            double gradeSub1 = 1.75;
            double gradeSub2 = 2.00;
            double gradeSub3 = 2.25;
            double gradeSub4 = 1.50;
            double gradeSub5 = 2.50;
            double gradeSub6 = 1.25;
            double gradeSub7 = 2.75;
            double gradeSub8 = 3.00;

            while (checkLogin != "x")
            {
                if (checkLogin == "1")
                {
                    Console.Write("Enter faculty number: ");
                    string facultyInput = Console.ReadLine();

                    if (facultyNumber == facultyInput)
                    {
                        Console.Write("Enter the student number: ");
                        string checkStudentNumber = Console.ReadLine();

                        if (checkStudentNumber == studentNumber)
                        {
                            Console.WriteLine($"\n--- CURRENT GRADES FOR STUDENT {studentNumber} ---");
                            Console.WriteLine($"1 - FUNDAMENTALS OF RESEARCH: {gradeSub1}");
                            Console.WriteLine($"2 - MULTIMEDIA: {gradeSub2}");
                            Console.WriteLine($"3 - DATABASE ADMINISTRATION: {gradeSub3}");
                            Console.WriteLine($"4 - APPLICATION DEVELOPMENT AND EMERGING TECHNOLOGIES: {gradeSub4}");
                            Console.WriteLine($"5 - PROJECT MANAGEMENT: {gradeSub5}");
                            Console.WriteLine($"6 - MOBILE APPLICATION: {gradeSub6}");
                            Console.WriteLine($"7 - SYSTEM ANALYSIS AND DESIGN: {gradeSub7}");
                            Console.WriteLine($"8 - ADVANCE PROGRAMMING: {gradeSub8}");

                            Console.Write("\nSelect Subject to Change Grade (1-8): ");
                            int subChoice = Convert.ToInt16(Console.ReadLine());

                            Console.Write("Enter new college grade (e.g., 1.0, 1.25, 2.0, 3.0, 5.0): ");
                            double newGrade = Convert.ToDouble(Console.ReadLine());

                            if (subChoice == 1) gradeSub1 = newGrade;
                            else if (subChoice == 2) gradeSub2 = newGrade;
                            else if (subChoice == 3) gradeSub3 = newGrade;
                            else if (subChoice == 4) gradeSub4 = newGrade;
                            else if (subChoice == 5) gradeSub5 = newGrade;
                            else if (subChoice == 6) gradeSub6 = newGrade;
                            else if (subChoice == 7) gradeSub7 = newGrade;
                            else if (subChoice == 8) gradeSub8 = newGrade;

                            Console.WriteLine("Student grade successfully updated!");
                        }
                        else
                        {
                            Console.WriteLine("Student ID not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Faculty Number.");
                    }
                }
                else if (checkLogin == "2")
                {
                    Console.Write("Enter your student number: ");
                    string userInput = Console.ReadLine();
                    bool response = userInput == studentNumber;

                    if (response)
                    {
                        Console.WriteLine("\nWelcome to PUP STUDENT GRADE SYSTEM!!");
                        Console.WriteLine("Type 1-8 to check you Subject grade");

                        Console.WriteLine("Type 1 - FUNDAMENTAL OF RESEARCH");
                        Console.WriteLine("Type 2 - MULTIMEDIA");
                        Console.WriteLine("Type 3 - DATABASE ADMINISTRATION");
                        Console.WriteLine("Type 4 - APPLICATION DEVELOPMENT AND EMERGING TECHNOLOGIES");
                        Console.WriteLine("Type 5 - PROJECT MANAGEMENT");
                        Console.WriteLine("Type 6 - MOBILE APPLICATION");
                        Console.WriteLine("Type 7 - SYSTEM ANALYSIS AND DESIGN");
                        Console.WriteLine("Type 8 - ADVANCE PROGRAMMING");
                        Console.WriteLine("Type 0 - to exit");

                        Console.Write("Enter your option: ");
                        int choice = Convert.ToInt16(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine($"FUNDAMENTAL OF RESEARCH Grade: {gradeSub1} | Status: {(gradeSub1 <= 3.0 ? "PASSED" : "FAILED")}");
                                break;
                            case 2:
                                Console.WriteLine($"MULTIMEDIA Grade: {gradeSub2} | Status: {(gradeSub2 <= 3.0 ? "PASSED" : "FAILED")}");
                                break;
                            case 3:
                                Console.WriteLine($"DATABASE ADMINISTRATION Grade: {gradeSub3} | Status: {(gradeSub3 <= 3.0 ? "PASSED" : "FAILED")}");
                                break;
                            case 4:
                                Console.WriteLine($"APPLICATION DEVELOPMENT AND EMERGING TECHNOLOGIES Grade: {gradeSub4} | Status: {(gradeSub4 <= 3.0 ? "PASSED" : "FAILED")}");
                                break;
                            case 5:
                                Console.WriteLine($"PROJECT MANAGEMENT Grade: {gradeSub5} | Status: {(gradeSub5 <= 3.0 ? "PASSED" : "FAILED")}");
                                break;
                            case 6:
                                Console.WriteLine($"MOBILE APPLICATION Grade: {gradeSub6} | Status: {(gradeSub6 <= 3.0 ? "PASSED" : "FAILED")}");
                                break;
                            case 7:
                                Console.WriteLine($"SYSTEM ANALYSIS AND DESIGN Grade: {gradeSub7} | Status: {(gradeSub7 <= 3.0 ? "PASSED" : "FAILED")}");
                                break;
                            case 8:
                                Console.WriteLine($"ADVANCE PROGRAMMING Grade: {gradeSub8} | Status: {(gradeSub8 <= 3.0 ? "PASSED" : "FAILED")}");
                                break;
                            case 0:
                                Console.WriteLine("Thank you for using PUP Grade Management System");
                                break;
                            default:
                                Console.WriteLine("Incorrect input...");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Student Number.");
                    }
                }

                Console.WriteLine("Enter 1 - for Faculty Login");
                Console.WriteLine("Enter 2 - for Student Login");
                Console.WriteLine("Enter x - to exit");
                Console.Write("User Input: ");
                checkLogin = Console.ReadLine();
            }
        }
    }
}