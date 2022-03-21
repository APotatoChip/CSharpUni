using System;
using System.Linq;
using System.Collections.Generic;

namespace _C
{
    class Program
    {
  
    public class StudentsQuiz{
        private int quizID;

         public int QuizID{
            get => quizID;
            set => quizID=value;
        }
       private string quizType;

        public string QuizType{
            get => quizType;
            set => quizType=value;
        }
       private string fn;

        public string FN{
            get => fn;
            set => fn=value;
        }
        private int points;

        public int Points{
            get => points;
            set => points=value;
        }
        private double grade;

         public double Grade{
             
            get => grade;
            set=>grade=value;
            
        }
        private double rate;

         public double Rate{
            get => rate;
            set => rate = value;
            
        }

         public void calc_grade(){
             if(quizType=="final"){
                 if(points==15){
                        grade=2.50;
                 }else if(points==16){
                    grade=2.75;
                 }
                 else if(points==17){
                     grade=3.00;
                 }
                 else if(points==18){
                     grade=3.25;
                 }
                 else if(points==19){
                     grade=3.50;
                 }
                 else if(points==20){
                     grade=3.75;
                 }
                 else if(points==21){
                     grade=4.00;
                 }
                 else if(points==22){
                     grade=4.25;
                 }
                 else if(points==23){
                     grade=4.50;
                 }else if(points==24){
                     grade=4.75;
                 }else if(points==25){
                     grade=5.00;
                 }else if(points==26){
                     grade=5.25;
                 }else if(points==27){
                     grade=5.50;
                 }else if(points==28){
                     grade=5.75;
                 }else if(points==29 || points==30){
                     grade=6.00;
                 }else{
                     grade=2.00;
                 }
             }
             if(quizType=="period"){
                 if(points==8 || points==9){
                    grade=3.00;
                 }else if(points==10){
                     grade=3.50;
                 }else if(points==11){
                     grade=4.00;
                 }else if(points==12){
                     grade=4.50;
                 }else if(points==13){
                     grade=5.00;
                 }else if(points==14){
                     grade=5.50;
                 }else if(points==15){
                     grade=6.00;
                 }else{
                     grade=2.00;
                 }
             }
        }

        public void calc_rate(){
            double res;
            if(grade==2.00){
                Rate=0;
            }else{
            if(quizType=="final"){
             res=(double)Points/30;
              Rate=Math.Round(res,2);
            }
            if(quizType=="period"){
                res=(double)Points/15;
           Rate=Math.Round(res,2);
            }
             }
        }

        public string calc_passed(){
            if(grade>2){
                return "passed";
            }else{
                return "failed";
            }
        }
    }

    public static void Main(string[] args){
        List<StudentsQuiz> testsCollection = new List<StudentsQuiz>();
          List<StudentsQuiz> deletedTestsCollection = new List<StudentsQuiz>();
            int operation;
            string testType;
            string fn;
            int pts;
            int idCount=0;
          do{
              Console.WriteLine("Operation (1-add;2-list;3-delete;4-end):");
              operation=int.Parse(Console.ReadLine());
                if(operation==1){
                    StudentsQuiz test = new StudentsQuiz();

                    Console.Write("Quiz Type (f-final; p-period):");
                    testType=Console.ReadLine();
                    if(testType=="f"){
                        test.QuizType="final";
                    }else{
                        test.QuizType="period";
                    }

                    Console.Write("FN:");
                    fn = Console.ReadLine();
                    test.FN=fn;

                    Console.Write("Points:");
                    pts = int.Parse(Console.ReadLine());
                    test.Points=pts;

                        StudentsQuiz isTest = testsCollection.Where(t=>t.FN==test.FN && t.QuizType==test.QuizType).FirstOrDefault();

                    if(testsCollection.Exists(t=>t.FN==test.FN) && testsCollection.Exists(t=>t.QuizType==test.QuizType)){
                        isTest.Points=pts;
                        isTest.calc_grade();
                        isTest.calc_rate();
                        Console.WriteLine("The points for {0} quiz of {1} are changed to {2}",isTest.QuizType,isTest.FN,isTest.Points);
                    Console.WriteLine("The grade is {0:0.00}, the rate is {1:0.00}",isTest.Grade,isTest.Rate);
                   Console.WriteLine("Exam is {0}",isTest.calc_passed());

                    }else{
                    idCount++;
                    test.QuizID=idCount;
                    testsCollection.Add(test);
                    Console.WriteLine("New exam is added");
                       test.calc_grade();
                        test.calc_rate();
                     Console.WriteLine("The grade is {0:0.00}, the rate is {1:0.00}",test.Grade,test.Rate);
                    Console.WriteLine("Exam is {0}",test.calc_passed());
                    }
                }else if(operation==2){
                        for(int i=0;i<testsCollection.Count;i++){
                            StudentsQuiz currQuiz = testsCollection[i];
                            Console.WriteLine("QuizID {0}",currQuiz.QuizID);
                            Console.WriteLine("Type {0}, FN {1} Points {2}, Grade {3:0.00}, Rate {4:0.00}, Result {5}", currQuiz.QuizType, currQuiz.FN, currQuiz.Points, currQuiz.Grade, currQuiz.Rate, currQuiz.calc_passed());
                        }
                }else if(operation==3){
                    Console.Write("Delete exam:");
                    int id=int.Parse(Console.ReadLine());
                       StudentsQuiz deletedTest=testsCollection.Where(t=>t.QuizID==id).FirstOrDefault();
                       deletedTestsCollection.Add(deletedTest);
                       testsCollection.Remove(deletedTest);
                }else if(operation==4){
                    double avgGrade=0.00;
                    int count=testsCollection.Count;
                    for(int i=0;i<count;i++){
                         StudentsQuiz currQuiz = testsCollection[i];
                         avgGrade+=currQuiz.Grade;
                    }
                    avgGrade/=count;
                    if(avgGrade<2){
                        avgGrade=2.00;
                    }
                    Console.WriteLine("Number of quizzes: {0}, Average grade: {1:0.00}.",count,Math.Round(avgGrade));
                    Console.WriteLine("Deleted quizzes: {0}",deletedTestsCollection.Count);
                    return;
                }
          }while(operation>=0 && operation<5);
    }
            
    }
}