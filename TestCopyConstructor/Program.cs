// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Foo foo = new("test", 33);

var copiedFoo = new Foo(foo);

Console.WriteLine("Let's see the addresses of Foo");
foo.ShowAddresses();

Console.WriteLine("Let's see the addresses of copiedFoo");
copiedFoo.ShowAddresses();

var copiedOfCopiedFoo = copiedFoo;

Console.WriteLine("Let's see the addresses of copiedOfCopiedFoo");
copiedOfCopiedFoo.ShowAddresses();

Console.WriteLine(foo);
Console.WriteLine(copiedFoo);

Console.WriteLine("Changing Fee field of foo...");
foo.SetFee("changed");

Console.WriteLine(foo);
Console.WriteLine(copiedFoo);