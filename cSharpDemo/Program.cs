// See https://aka.ms/new-console-template for more information

using cSharpDemo;

A a = (A)30;
double b = new A(1.2);
Console.WriteLine("浮点数{0},{1}", a.P, b);

Student c = new Student("a");
Student d = new Student("a");
Console.WriteLine(c == d);

//异或
Console.WriteLine(true ^ false);

//左移与右移
Console.WriteLine(2 << 1);

Dictionary<string, string> dic = null;
Console.WriteLine(dic?["123"] == null);

//类型 obj.GetType(),typeof(ClassName),obj is ClassName

//nameof()

//==  值类型（除了string）判断是否是同一个应用，值类型判断值是否相等

//getHashCode  快|均匀分布|相同值hashCode一致

String str1 = new String("c");

String str2 = new String("c");

Object stra = str1;

Object strb = str2;

Console.WriteLine(stra == strb);

Console.WriteLine(strb.Equals(stra));

//数组
bool[] boolArr = Enumerable.Repeat(true, 2).ToArray();
int [] intArr = Enumerable.Range(0, 2).ToArray();
var cloneArr = (bool[])boolArr.Clone();
var desArr = new bool[5];
boolArr.CopyTo(desArr, 2);
Console.WriteLine(boolArr.Length == 2);
//交叉数组
int[,] arr = new int[1, 2]{{1,2}};
Console.WriteLine(arr[0, 1]);
//枚举
var day = (int)Day.Friday;
Console.WriteLine(day.GetType());
Console.WriteLine((Day)day);
Console.WriteLine(Enum.GetUnderlyingType(typeof(Day)));
var types = Day.Monday | Day.Tuesday;
Console.WriteLine(types.HasFlag(Day.Sunday));
Console.WriteLine((Day)Enum.Parse(typeof(Day), Day.Friday.ToString()));
foreach (Day ds in Enum.GetValues(typeof(Day)))
{
    Console.WriteLine(ds);
}

//hashSet list contains
HashSet<int> setValues = new() { 1, 2, 3, 2 };
Console.WriteLine(setValues.Contains(2));//O(1)

//栈
Stack<int> stacks = new Stack<int>();
stacks.Push(1);
stacks.Push(2);
stacks.Push(3);

Console.WriteLine(string.Join(",", stacks));
Console.WriteLine(stacks.Pop());
Console.WriteLine(stacks.Pop());
Console.WriteLine(string.Join(",", stacks));

//LinkList
LinkedList<int> linkedList = new LinkedList<int>();
linkedList.AddFirst(0);
linkedList.AddFirst(2);

Console.WriteLine(string.Join(",", linkedList));


//queue
var queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());

//var animal = new Animal();
//var animal2 = new Animal();
var animal = SingletonClass.Animal;


var kid = new Kid(20, "111", DateTime.MinValue);
Console.WriteLine(kid.Birthday);
Console.WriteLine(kid.Age);