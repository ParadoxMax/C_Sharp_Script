using System;

public class Calculator {
    public static void main(string[] args) {
        int operation;
        float num1;
        float num2;
        float result;
        Console.WriteLine("Please enter your operator", operation);
        Console.WriteLine("Please enter your num1", num1);
        Console.WriteLine("Please enter your num2", num2);
        Console.ReadLine("%i", &operation);
        if (operation == 1) {
            result = num1 + num2;
            Console.WriteLine("The result = ", result);
        } else if (operation == 2) {
            result = num1 - num2;
            Console.WriteLine("The result = ", result);
        } else if (operation == 3) {
            result = num1 * num2;
            Console.WriteLine("The result = ", result);
        } else if (operation == 4) {
            result = num1 / num2;
            Console.WriteLine("The result = ", result);
        } else {
            Console.WriteLine("ERROR");
        }
    }
}
