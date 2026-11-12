using System;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("========================================");
Console.WriteLine("BUỔI 01 - BÀI TẬP THỰC HÀNH");
Console.WriteLine("Họ tên: Lê Trọng Vượng - MSV: 10125337");
Console.WriteLine("========================================\n");

Console.WriteLine("=== Bài 1: Tìm Max, Min trong mảng 1000 số ngẫu nhiên ===");
Bai1();

Console.WriteLine("\n=== Bài 2: Trò chơi FizzBuzz (1 đến 100) ===");
Bai2();

Console.WriteLine("\n=== Bài 3: Đảo ngược chuỗi ===");
Bai3();

Console.WriteLine("\n=== Bài 4: Sắp xếp nổi bọt mảng 1000 phần tử ===");
Bai4();

Console.WriteLine("\n=== Bài 5: Tính số Fibonacci thứ n ===");
Bai5();

// -----------------------------------------------------------
// CHI TIẾT CÁC BÀI TOÁN
// -----------------------------------------------------------

static void Bai1()
{
    int[] a = new int[1000];
    Random rd = new Random(42);
    for (int i = 0; i < 1000; i++)
    {
        a[i] = rd.Next(1, 10001);
    }

    int max = a[0];
    int min = a[0];
    for (int i = 1; i < 1000; i++)
    {
        if (a[i] > max) max = a[i];
        if (a[i] < min) min = a[i];
    }

    Console.WriteLine("Số lớn nhất là: " + max);
    Console.WriteLine("Số nhỏ nhất là: " + min);
}

static void Bai2()
{
    for (int i = 1; i <= 30; i++) // In minh họa 30 số đầu
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
    Console.WriteLine("... (đã chạy từ 1 đến 100)");
}

static void Bai3()
{
    Console.Write("Nhập chuỗi: ");
    string s = Console.ReadLine();
    if (string.IsNullOrEmpty(s)) s = "CauTrucDuLieuVaGiaiThuat";
    Console.WriteLine(s);

    string kq = "";
    for (int i = s.Length - 1; i >= 0; i--)
    {
        kq = kq + s[i];
    }

    Console.WriteLine("Chuỗi đảo ngược: " + kq);
}

static void Bai4()
{
    int[] a = new int[20]; // Minh họa 20 phần tử để dễ nhìn kết quả
    Random rd = new Random(42);
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = rd.Next(1, 101);
    }

    Console.WriteLine("Mảng ban đầu (20 phần tử đầu):");
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }

    for (int i = 0; i < a.Length - 1; i++)
    {
        for (int j = 0; j < a.Length - 1 - i; j++)
        {
            if (a[j] > a[j + 1])
            {
                int tam = a[j];
                a[j] = a[j + 1];
                a[j + 1] = tam;
            }
        }
    }

    Console.WriteLine("\n\nMảng sau khi sắp xếp tăng dần:");
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
    Console.WriteLine();
}

static void Bai5()
{
    Console.Write("Nhập n: ");
    string line = Console.ReadLine();
    int n = 10;
    if (!string.IsNullOrEmpty(line) && int.TryParse(line, out int val))
    {
        n = val;
    }
    else
    {
        Console.WriteLine(n);
    }
    Console.WriteLine($"Số Fibonacci thứ {n} là: {Fibonacci(n)}");
}

static long Fibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;

    long a = 0;
    long b = 1;
    for (int i = 2; i <= n; i++)
    {
        long c = a + b;
        a = b;
        b = c;
    }
    return b;
}
