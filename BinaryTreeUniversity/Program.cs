using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;

            Position vicRecPosition = new Position();
            vicRecPosition.Name = "Vicerector financiero";
            vicRecPosition.Salary = 750;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria financiera 1";
            secFin1Position.Salary = 350;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria financiera 2";
            secFin2Position.Salary = 310;

            Position vicRecAcaPosition = new Position();
            vicRecAcaPosition.Name = "Vicerector academico";
            vicRecAcaPosition.Salary = 780;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe reg";
            jefeRegPosition.Salary = 640;

            Position secretg2Position = new Position();
            secretg2Position.Name = "Secretg2";
            secretg2Position.Salary = 360;

            Position secretg1Position = new Position();
            secretg1Position.Name = "Seretg1";
            secretg1Position.Salary = 400;

            Position asist2Position = new Position();
            asist2Position.Name = "Asist2";
            asist2Position.Salary = 170;

            Position asist1Position = new Position();
            asist1Position.Name = "Asist1";
            asist1Position.Salary = 250;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicRecPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicRecPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicRecPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicRecAcaPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicRecAcaPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secretg2Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secretg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secretg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asist1Position, secretg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asist2Position.Name);


            universityTree.PrintTree(universityTree.Root);
            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: {totalSalary}");
            Console.ReadLine();
        }
    }
}
