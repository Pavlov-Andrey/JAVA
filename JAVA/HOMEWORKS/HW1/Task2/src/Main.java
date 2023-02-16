// 2. Вывести все простые числа от 1 до 1000
public class Main {
    public static void main(String[] args) {

        int i, j, num;

        for(i = 2; i <= 1000; i++) {
            num = 0;

            for(j = 2; j < i; j++) {
                if((i % j) != 0) {

                }
                else num += 1;
            }

            if(num == 0) {
                System.out.print(i + ", ");

            }
        }
    }
}