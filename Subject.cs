using System;

namespace ConsoleApplication
{
    public class Subject {
        public string name {get; set;}
        public int groupAverage {get; set;}
        public int actualScore {get; set;}

        public void InputGroupAverage(){
            bool valid = false;
            while(!valid){
                int groupAvgInput;
                Console.Write("Group Average Score: ");
                if(int.TryParse(Console.ReadLine(), out groupAvgInput)){
                    valid = true;
                    this.groupAverage = groupAvgInput;
                }else{
                    Console.WriteLine("You have entered an invalid input. Try again!");
                    valid = false;
                }
            }
        }

        public void InputActualScore(){
            bool valid = false;
            while(!valid){
                int actualScoreInput;
                Console.Write("Actual Score: ");
                if(int.TryParse(Console.ReadLine(), out actualScoreInput)){
                    valid = true;
                    this.actualScore = actualScoreInput;
                }else{
                    Console.WriteLine("You have entered an invalid input. Try again!");
                    valid = false;
                }
            }
        }
    }
}