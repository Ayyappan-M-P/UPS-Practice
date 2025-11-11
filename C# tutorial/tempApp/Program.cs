// // // using System;
// // // //1
// // // // class A{
// // // //     public static int count = 0;
// // // //     static A() {
// // // //         count++;
// // // //         Console.WriteLine("Static");
// // // //     }
// // // //     public A()
// // // //     {
// // // //         count++;
// // // //         Console.WriteLine("Instance");
// // // //     }
// // // // }

// // // // class Program
// // // // {
// // // //     static void Main()
// // // //     {
// // // //         Console.WriteLine("Start");
// // // //         A a1 = new A();
// // // //         A a2 = new A();
// // // //         Console.WriteLine($"Count = {A.count}");
// // // //     }
// // // // }

// // // //2

// // // // class Program
// // // // {
// // // //     static void Compute(int x, ref int y, out int z)
// // // //     {
// // // //         z = x + y;
// // // //         y = z * 2;
// // // //         System.Console.WriteLine($"x:{x},y:{y},z:{z}");
// // // //     }
// // // //     static void Main()
// // // //     {
// // // //         int a = 3, b = 4, c;
// // // //         Compute(a, ref b, out c);
// // // //         System.Console.WriteLine($"a:{a},b:{b},c:{c}");
// // // //     }
// // // // }


// // // //3
// // // class Base
// // // {
// // //     protected int x;
// // //     public Base(int a)
// // //     {
// // //         x = a;
// // //         Console.WriteLine($"Base a={x}");
// // //     }

// // // }
// // // class Derived : Base
// // // {

// // //     public Derived(int a, int b) : base(b)
// // //     {
// // //         int sum = a+b;
// // //         Console.WriteLine($"Derived sum={sum}");
// // //     }
// // // }

// // // class Program
// // // {
// // //     static void Main()
// // //     {
// // //         Derived d = new Derived(2, 3);
// // //     }
// // // }

// // using System;

// // class Demo
// // {
// //     static int count = Print("static init", 1);
// //     int value = Print("instance init", 2);

// //     static int Print(string msg, int x)
// //     {
// //         Console.WriteLine(msg);
// //         return x;
// //     }

// //     public Demo() => Console.WriteLine("ctor");
// // }

// // class Program
// // {
// //     static void Main()
// //     {
// //         Demo d1 = new Demo();
// //         Demo d2 = new Demo();
// //     }
// // }

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         var actions = new List<Action>();
//         foreach (var i in new[] {1,2,3})
//             actions.Add(() => Console.Write(i));
//         foreach (var act in actions) act();
//     }
// }