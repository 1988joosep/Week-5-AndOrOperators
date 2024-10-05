//Math >= 90 || Chemistry >= 90

//Math >= 90 && chemistry >= 90 || math && biology || chemistry && biology

int math, chemistry, biology;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations You got accepted!");
}
else
{
    Console.WriteLine("Your application cannot be approved");
}
