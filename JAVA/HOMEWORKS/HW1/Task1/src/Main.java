
// 1. Вычислить n-ое треугольного число(сумма чисел от 1 до n), n!
//    (произведение чисел от 1 до n)

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner iScanner = new Scanner(System.in);
        System.out.printf("Введите число n: ");
        boolean flag = iScanner.hasNextInt();
        int n = iScanner.nextInt();
        iScanner.close();
        double n_sum = 0.5 * n * (n + 1);

        int y = (int)n_sum;
        int x = 1;
        int fact = 1;
        while (x <= n){
            fact *= x;
            x += 1;
        }
        System.out.printf("При n = %d: n-ое треугольное число = %d,  факториал n = %d. \n", n, y, fact);
    }
}