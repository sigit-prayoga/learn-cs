using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Student 
    {
        public string name {get; set;}
        public string sid {get; set;}
        private List<Subject> subjects {get; set;}

        public Student(){
            this.subjects = new List<Subject>();
        }
        public Student (string name, string sid){
            this.name = name;
            this.sid = sid;
            this.subjects = new List<Subject>();
        }

        public void InputData(){
            Console.Write("Student Name: ");
            this.name = Console.ReadLine();

            Console.Write("Student ID: ");
            this.sid = Console.ReadLine();

            Console.WriteLine("===============");

            Console.Write("Would you like to enter subjects? (Y/n) ");
            string answer = Console.ReadLine();
            if(answer.Equals("y") || answer.Equals("Y")){
                int many;
                Console.Write("How Many Subjects? ");
                //TODO: should validate user input
                int.TryParse(Console.ReadLine(), out many);
                for(int i = 1; i <= many; i++){
                    Console.WriteLine("===============");
                    Console.WriteLine("Subject No."+i);
                    //continue
                    Subject subjectInput = InputSubject();
                    //add to the list
                    this.subjects.Add(subjectInput);
                }
            }
            int finalScore = CountFinalScore();
            string converted = ConvertScore(finalScore);
            Console.WriteLine("===============");
            Console.WriteLine("The Final Score Is: " + converted);
            Console.WriteLine("Cheers!");
        }

        public Subject InputSubject(){
            Subject subject = new Subject();
            Console.WriteLine("** Input Subject Information **");

            Console.Write("Name: ");
            subject.name = Console.ReadLine();

            subject.InputGroupAverage();
            subject.InputActualScore();

            return subject;
        }

        public int CountFinalScore(){
            if(subjects.Count == 0){
                return 0;
            }
            int totalScore = 0;
            foreach (Subject current in subjects){
                totalScore += current.actualScore;
            }

            return totalScore/subjects.Count;
        }

        private string ConvertScore(int score){
            if(score >= 90){
                return "A";
            }else if(score >= 80){
                return "B";
            }else if(score >= 70){
                return "C";
            }else if(score >= 60){
                return "D";
            }
            return "E";
        }
    }
}
