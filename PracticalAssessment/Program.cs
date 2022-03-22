using System;
using System.Linq;
using System.Collections.Generic;

namespace _C
{
    class Program
    {
       public class MyFnNumber{
           private string fnumber;
            public string Fnumber{
            get => fnumber;
            set => fnumber=value;
        }
           private int enrollYear;

          public int EnrollYear{
            get => enrollYear;
            set => enrollYear=value;
        }
           private bool isValid;
           public bool IsValid{
            get => isValid;
            set => isValid=value;
        }

       public void setenrollYear(){
           if(isValid){
               int year=int.Parse(fnumber.Substring(0,2))+2000;
               enrollYear=year;

           }else{
               enrollYear=0;
           }
       }

       public void setIsValid(){
           if(fnumber.Length<7 ){
               isValid=false;
           }else{
               var str = fnumber.Substring(0,2);
               int num;
               bool isNumber = int.TryParse(str,out num);
               if(isNumber){
               isValid=true;

               }else{
                isValid=false;
               }
           }
       }
       }
         
    public static void Main(string[] args){
       List<MyFnNumber> fnNumbersCollection = new List<MyFnNumber>();
       List<MyFnNumber> deletedFnNumbersCollection = new List<MyFnNumber>();
       
       while(true){
            Console.WriteLine("Operation (1-add;2-list;3-delete;4-end): ");
                int operation = int.Parse(Console.ReadLine());
       switch(operation){
           case 1:
           Console.WriteLine("FNumber:");
           string fn = Console.ReadLine();
           MyFnNumber fnNumber=new MyFnNumber();
           fnNumber.Fnumber=fn;
           fnNumber.setIsValid();
           fnNumber.setenrollYear();
           Console.WriteLine(fnNumber.EnrollYear);
           fnNumbersCollection.Add(fnNumber);
           break;
           case 2:
           for(int i =0;i<fnNumbersCollection.Count;i++){
               Console.WriteLine("{0}, {1}, {2}",fnNumbersCollection[i].Fnumber,fnNumbersCollection[i].IsValid,fnNumbersCollection[i].EnrollYear);
           }
           break;
           case 3:
           Console.WriteLine("Delete FNumber:");
           string fnToDeleteStr=Console.ReadLine();
           MyFnNumber fnToDelte = fnNumbersCollection.Where(f => f.Fnumber==fnToDeleteStr).FirstOrDefault();
          fnNumbersCollection.Remove(fnToDelte);
            deletedFnNumbersCollection.Add(fnToDelte);
           break;
           case 4:
           Console.WriteLine("Count {0}",fnNumbersCollection.Count);
           int firstCount=0;
           int secondCount=0;
           int thirdCount=0;
           int invalidCount=0;
           for(int i=0;i<fnNumbersCollection.Count;i++){
               int enrollYear = fnNumbersCollection[i].EnrollYear;
               if(enrollYear>=2000 && enrollYear<=2005 ){
                   firstCount++;
               }else if(enrollYear>=2006 && enrollYear<=2010 ){
                    secondCount++;
               }else if(enrollYear>=2011 && enrollYear<=2022 ){
                thirdCount++;
               }else{
                   invalidCount++;
               }
               
           }
           Console.WriteLine("2000 - 2005 {0}",firstCount);
            Console.WriteLine("2006 -2010 {0}",secondCount);
             Console.WriteLine("2011 - 2022 {0}",thirdCount);
            Console.WriteLine("Invalid {0}",invalidCount);
             Console.WriteLine("Deleted {0}",deletedFnNumbersCollection.Count);
           return;
       }
       }
    }
            
    }
}