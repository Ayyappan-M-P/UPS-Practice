// class Property{
//     public static void Main()
//     {
//         List<int> list=new List<int>();
//         list.Add(1);
//         list.AddRange(new int[]{2,3,4,5});
//         list.Insert(0,0);
//         list.Remove(5);
//         list.RemoveAt(0);
//         list.RemoveAll(x=>x%2==0);
//         Console.WriteLine(list.Count());
//         Console.WriteLine(list.Contains(1));
//         Console.WriteLine(list.IndexOf(3));
//         list.Reverse();
//         foreach(int i in list){
//             Console.Write(i+" ");
//         }

//         Console.WriteLine("Dictionary");
//         Dictionary<int,string> map=new Dictionary<int, string>();
//         map.Add(1,"one");
//         map.Add(2,"two");
//         map.Add(3,"three");
//         map[4]="four";
//         map[5]="five";
//         map.Remove(5);
//         Console.WriteLine(map.ContainsKey(2));
//         Console.WriteLine(map.ContainsValue("three"));
//         if(map.TryGetValue(6,out string name))
//         {
//             Console.WriteLine(name);
//         }
//         else
//         {
//             Console.WriteLine("Key not found");
//         }
//         Console.WriteLine(map.Count);
//         Console.WriteLine("keys:" + map.Keys);
//         Console.WriteLine("values:" + map.Values);
//         foreach(KeyValuePair<int,string> i in map)
//         {
//             Console.WriteLine($"Key : {i.Key}, Value : {i.Value}");
//         }

//         Console.WriteLine("HashSet");
//         HashSet<int> set=new HashSet<int>();
//         set.Add(1);
//         set.Add(2);
//         set.Add(2);
//         set.Add(3);
//         set.Remove(2);
//         Console.WriteLine(set.Contains(2));
//         Console.WriteLine(set.Count);
//         HashSet<int> set2=new HashSet<int>(){3,4,5};
//         set.ExceptWith(set2);
//         foreach(int i in set)
//         {
//             Console.Write(i+" ");
//         }
//         Console.WriteLine();
//         Console.WriteLine("LinkerdList");
//         LinkedList<int> llist=new LinkedList<int>();
//         llist.AddFirst(1);
//         llist.AddFirst(2);
//         llist.AddFirst(3);
//         llist.AddLast(4);
//         llist.AddLast(5);
//         var node=llist.Find(4);
//         llist.AddBefore(node,0);
//         Console.WriteLine(llist.Count);
//         Console.WriteLine(llist.First());
//         Console.WriteLine(llist.Last());
//         foreach(int i in llist)
//         {
//             Console.Write(i+" ");
//         }


//     }
// }