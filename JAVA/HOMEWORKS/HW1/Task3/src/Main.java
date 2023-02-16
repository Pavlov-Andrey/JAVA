//3. Реализовать простой калькулятор

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double num1, num2, result = 0;
        char operator;

        System.out.print("Введите число: ");
        num1 = scanner.nextDouble();
        System.out.print("Введите оператор (+, -, *, /): ");
        operator = scanner.next().charAt(0);
        System.out.print("Введите число: ");
        num2 = scanner.nextDouble();

        switch (operator) {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0) {
                    System.out.println("На ноль делить нельзя");
                    return;
                } else {
                    result = num1 / num2;
                    break;
                }
            default:
                System.out.println("Ошибка");
                return;
        }

        System.out.println("Result: " + result);
    }
}

