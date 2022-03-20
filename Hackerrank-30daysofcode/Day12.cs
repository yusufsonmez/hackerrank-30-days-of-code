using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_30daysofcode
{
   




class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);

        }
    }

    class Student : Person
    {
        private int[] testScores;


        public Student(string _firstName, string _lastName, int _idNumber, int[] _scores)
        {
            firstName = _firstName;
            lastName = _lastName;
            id = _idNumber;
            testScores = _scores;
        }



        public char Calculate()
        {
            int temp = 0;
            foreach (var i in testScores)
            {
                temp = i + temp;
            }


            int grade = temp / testScores.Length;


            if (grade < 40)
            {
                return 'T';
            }
            else if (grade >= 40 && grade < 55)
            {
                return 'D';
            }
            else if (grade >= 55 && grade < 70)
            {
                return 'P';
            }
            else if (grade >= 70 && grade < 80)
            {
                return 'A';
            }
            else if (grade >= 80 && grade < 90)
            {
                return 'E';
            }
            else if (grade >= 90 && grade <= 100)
            {
                return 'O';
            }
            else
            {
                return 'X';
            }


        }


        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
    }

 

          
     








}
