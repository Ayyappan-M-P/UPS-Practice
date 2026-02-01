// // // using System;
// // // using System.Collections.Generic;
// // // class Ienumerable
// // // {
// // //     public static void Main(String[] args)
// // //     {
// // //         IEnumerable<string> arr = new List<string> { "apple", "banana", "mango" };
// // //         foreach (var n in arr)
// // //         {
// // //             Console.WriteLine(n);
// // //         }   

// // //         var enumerator = arr.GetEnumerator();
// // //         while (enumerator.MoveNext())
// // //         {
// // //             Console.WriteLine(enumerator.Current);
// // //         }
// // //     }
// // // }


// // using System;
// // using System.Collections;

// // class Student
// // {
// //     public int Id{get; set;}
// //     public string Name{get; set;}

// //     public Student(int id,string name){
// //         this.Id=id;
// //         this.Name=name;
// //     }

// // }

// // class College
// // {
// //     private List<Student> students=new List<Student>();

// //     public void Addstudent(Student student)
// //     {
// //         students.Add(student);
// //     }
// //     public IEnumerable<Student> GetAllStudents()
// //     {
// //         return students;
// //     }
// // }
// // class Ienumerable
// // {
// //     public static void Main(string[] args)
// //     {
// //         College college=new College();
// //         // college.Addstudent(new Student{Id=1,Name="Ayyappan"});
// //         // college.Addstudent(new Student{Id=2,Name="karan"});
// //         // college.Addstudent(new Student{Id=3,Name="rahul"});
// //         college.Addstudent(new Student(4,"error"));

// //         IEnumerable<Student> allstudents=college.GetAllStudents();
// //         foreach(var student in allstudents)
// //         {
// //             Console.WriteLine("Id: "+student.Id+" Name: "+student.Name);
// //         }
// //     }
// // }

// using Microsoft.VisualBasic;

// class Account{
//     public int Accno{get; set;}
//     public string Name{get; set;}
//     public double Balance{get; set;}

//     public Account(int accno,string name,double balance){
//         this.Accno=accno;
//         this.Name=name;
//         this.Balance=balance;
//     }
// }

// class Bank
// {
//     private List<Account> accounts=new List<Account>();

//     public void Add(Account account){
//         accounts.Add(account);
//     }

//     public void Deposit(int accno,double amount){
//         foreach(var acc in accounts){
//             if(acc.Accno==accno){
//                 acc.Balance+=amount;
//                 Console.WriteLine("Deposited "+amount+" to account "+accno);
//                 return;
//             }
//         }
//         Console.WriteLine("Account not found");
//     }

//     public void Withdraw(int accno,double amount){
//         foreach(var acc in accounts){
//             if(acc.Accno==accno){
//                 if(acc.Balance>=amount){
//                     acc.Balance-=amount;
//                     Console.WriteLine("Withdrew "+amount+" from account "+accno);
//                 }else{
//                     Console.WriteLine("Insufficient balance");
//                 }
//                 return;
//             }
//         }
//         Console.WriteLine("Account not found");
//     }

//     public void CheckBalance(int accno){
//         foreach(var acc in accounts){
//             if(acc.Accno==accno){
//                 Console.WriteLine("Balance for account "+accno+" is "+acc.Balance);
//                 return;
//             }
//         }
//         Console.WriteLine("Account not found");
//     }

//     public IEnumerable<Account> GetAllAccounts(){
//         return accounts;
//     }
// }
// class Ienumerable
// {
//     public static void Main(string[] args)
//     {
//         Bank bank=new Bank();
//         bank.Add(new Account(101,"Alice",5000));
//         bank.Add(new Account(102,"Bob",3000));
//         bank.Add(new Account(103,"Charlie",7000));

//         bank.Deposit(101,2000);
//         bank.Withdraw(102,1000);
//         bank.CheckBalance(103);

//         IEnumerable<Account> allAccounts=bank.GetAllAccounts();
//         foreach(var acc in allAccounts){
//             Console.WriteLine("Account No: "+acc.Accno+" Name: "+acc.Name+" Balance: "+acc.Balance);
//         }
//     }
// }