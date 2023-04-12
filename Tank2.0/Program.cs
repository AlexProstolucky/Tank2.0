using System.Collections;
using System.Collections.Generic;
class mass_sort : IComparer
{
    public int Compare(object x, object y)
    {
        Tank x1 = x as Tank;
        Tank y1 = y as Tank;
        if (x1.mass > y1.mass)
        {
            return 1;
        }
        if (x1.mass == y1.mass)
        {
            return 0;
        }
        if (x1.mass < y1.mass)
        {
            return -1;
        }
        throw new NotImplementedException();
    }
}

class maxp_sort : IComparer
{
    public int Compare(object x, object y)
    {
        Tank x1 = x as Tank;
        Tank y1 = y as Tank;
        if (x1.max_p > y1.max_p)
        {
            return 1;
        }
        if (x1.max_p == y1.max_p)
        {
            return 0;
        }
        if (x1.max_p < y1.max_p)
        {
            return -1;
        }
        throw new NotImplementedException();
    }
}

class range_sort : IComparer
{
    public int Compare(object x, object y)
    {
        Tank x1 = x as Tank;
        Tank y1 = y as Tank;
        if (x1.max_range > y1.max_range)
        {
            return 1;
        }
        if (x1.max_range == y1.max_range)
        {
            return 0;
        }
        if (x1.max_range < y1.max_range)
        {
            return -1;
        }
        throw new NotImplementedException();
    }
}

class max_V_sort : IComparer
{
    public int Compare(object x, object y)
    {
        Tank x1 = x as Tank;
        Tank y1 = y as Tank;
        if (x1.max_V > y1.max_V)
        {
            return 1;
        }
        if (x1.max_V == y1.max_V)
        {
            return 0;
        }
        if (x1.max_V < y1.max_V)
        {
            return -1;
        }
        throw new NotImplementedException();
    }
}
class max_S_sort : IComparer
{
    public int Compare(object x, object y)
    {
        Tank x1 = x as Tank;
        Tank y1 = y as Tank;
        if (x1.max_S > y1.max_S)
        {
            return 1;
        }
        if (x1.max_S == y1.max_S)
        {
            return 0;
        }
        if (x1.max_S < y1.max_S)
        {
            return -1;
        }
        throw new NotImplementedException();
    }
}
class Tank : ICloneable
{
    public string name { get; set; }
    public int mass { get; set; }
    public int max_p { get; set; }
    public int max_range { get; set; }
    public int max_V { get; set; }
    public int max_S { get; set; }

    public Tank(string name, int mas, int max_p, int max_range, int max_V, int max_S)
    {
        this.name = name;
        this.mass = mas;
        this.max_p = max_p;
        this.max_range = max_range;
        this.max_V = max_V;
        this.max_S = max_S;
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Tank: Name -> {name}\n Weight -> {mass} \n Number of seats -> {max_p} \n Range -> {max_range} \n Speed -> {max_V} \n Maximum mileage on a full tank -> {max_S}";
    }

}
internal class Program
{
    private static void Main(string[] args)
    {
        Tank t1 = new Tank("T62", 38, 4, 500, 50, 580);
        Tank t2 = (Tank)t1.Clone();
        t2.name = "T64";
        t2.mass = 39;
        t2.max_V = 45;
        t2.max_range = 770;
        t2.max_S = 550;
        Tank t3 = new Tank("T54", 40, 3, 350, 35, 385);
        Tank[] arr = new Tank[] {t1, t3, t2};
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i].ToString());
            Console.WriteLine();
        }

        Console.WriteLine("\nChoose the characteristic by which we will sort:");
        int n;
        Console.WriteLine("1) - Weight \n2) - Number of seats \n3) - Range \n4) - Speed \n5) - Maximum mileage on a full tank ");
        Console.Write("Sort by -> ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        switch (n)
        {
            case 1:
                Array.Sort(arr, new mass_sort()); break;
            case 2:
                Array.Sort(arr, new maxp_sort()); break;
            case 3:
                Array.Sort(arr, new range_sort()); break;
            case 4:
                Array.Sort(arr, new max_V_sort()); break;
            case 5:
                Array.Sort(arr, new max_S_sort()); break;
            default:
                Console.WriteLine("Wrong choice");
                return;
        }


        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i].ToString());
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}