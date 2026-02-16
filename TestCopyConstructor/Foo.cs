using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Foo
{
    private string Fee;

    private int Long;

    private List<double> Sums = new List<double>(5);

    public Foo()
    {
        Fee = string.Empty;
        Long = -1;
        GenerateSums();
    }

    public Foo(string fee, int longValue)
    {
        Fee = fee;
        Long = longValue;
        GenerateSums();
    }

    public Foo(Foo anotherFoo)
    {
        Fee = anotherFoo.Fee;
        Long = anotherFoo.Long;
        Sums = anotherFoo.Sums;
    }

    public unsafe void ShowAddresses()
    {
        ref string feeRef = ref Fee;
        void* ptr = Unsafe.AsPointer(ref feeRef);
        ulong address = (ulong)ptr;
        Console.WriteLine($"Address of Fee field: 0x{address:X}");

        ref int longRef = ref Long;
        ptr = Unsafe.AsPointer(ref longRef);
        address = (ulong)ptr;
        Console.WriteLine($"Address of Long field: 0x{address:X}");

        ref List<double> sumsRef = ref Sums;
        ptr = Unsafe.AsPointer(ref sumsRef);
        address = (ulong)ptr;
        Console.WriteLine($"Address of Sums field: 0x{address:X}");
    }

    public void SetFee(string fee)
    {
        Fee = fee;
    }

    public override string ToString()
    {
        return $"Fee: {Fee}, Long: {Long}, Sums: [{string.Join(", ", Sums)}]";
    }

    private void GenerateSums()
    {
        for (int i = 0; i < 5; i++)
        {
            Sums.Add(i * 1.1);
        }
    }
}