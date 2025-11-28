// // using System;
// // using System.Linq;

// // class Employee{
// //     public string Name{get; set;}
// //     public double salary{get; set;}
// // }
// // class Program{
// //     public static void Main()
// //     {
// //         List<Employee> employees=new List<Employee>();
// //         employees.Add(new Employee(){Name="Karan",salary=50000});
// //         employees.Add(new Employee(){Name="Ayyappan",salary=60000});    
// //         employees.Add(new Employee(){Name="Rahul",salary=55000});

// //         var ans=employees.Where(employees=>employees.salary>50000).OrderBy(employees=>employees.Name).ToList();

// //         foreach(var emp in ans)
// //         {
// //             Console.WriteLine($"Name:{emp.Name}, Salary:{emp.salary}");
// //         }
// //     }
// // }

// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         string filePath = "config.txt";
//         string defaultContent = "Ayyappan M P, Test-3, Problem Statement = 2";

//         try
//         {
            
//             if (!File.Exists(filePath))
//             {
//                 Console.WriteLine("config.txt not found. Creating default configuration...");

//                 File.WriteAllText(filePath, defaultContent);

//                 Console.WriteLine("Default config file created successfully.\n");
//             }


//             Console.WriteLine("Reading configuration file:\n");
//             string content = File.ReadAllText(filePath);
//             Console.WriteLine(content);
//         }
//         catch (FileNotFoundException ex)
//         {
//             Console.WriteLine("Error: The configuration file not found.");
//             Console.WriteLine(ex.Message);
//         }
//         catch (IOException ex)
//         {
//             Console.WriteLine("An I/O error occurred while accessing the file.");
//             Console.WriteLine(ex.Message);
//         }
//     }
// }


using System;
using System.Threading;
using System.Threading.Tasks;
class Program{
    static async Task Main(){
        Console.WriteLine("Payment started");
        Console.WriteLine("cancel payment in 10 seconds");

        CancellationTokenSource cts=new CancellationTokenSource();
        CancellationToken token=cts.Token;

        Task payment=PaymentProcess(token);
        Task cancel = Task.Run(() =>
        {
            Console.ReadLine();
            cts.Cancel();
        });

        try
        {
            await payment;
            Console.WriteLine("Payment completed");
        }
        catch(OperationCanceledException){
            Console.WriteLine("Payment cancelled");
        }
    }
    static async Task PaymentProcess(CancellationToken token)
    {
        for(int i = 1; i <= 10; i++)
        {
            token.ThrowIfCancellationRequested();
            Console.WriteLine($"Processing payment...{i} sec");
            await Task.Delay(1000, token);
        }
    }
}