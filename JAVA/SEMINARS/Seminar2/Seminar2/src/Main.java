// 1.Дано четное число N (>0) и символы c1 и c2.
//        Написать метод, который вернет строку длины N, которая состоит из чередующихся символов c1 и c2, начиная с c1.


//Напишите метод, который сжимает строку.
//        Пример: вход aaaabbbcdd.


//public class Main {
//    public static void main(String[] args) {
//        String s1 = "c1";
//        String s2 = "c2";
//        StringBuilder s3 = new StringBuilder();
//        int n = 10;
//
//        while (s3.length() <= n/2) {
//            s3.append(s1);
//            s3.append(s2);
//        }
//        if (s3.length() < n) {
//            s3.append(s1);
//        }
//        System.out.println(s3);
//    }
//}

//public class Main {
//    public static void main(String[] args) {
//        String s1 = "aaaabbbcdd";
//        StringBuilder s2 = new StringBuilder();
//        int count = 1;
//
//        for (int i = 1; i < s1.length(); i++) {
//            var temp = s1.charAt(i - 1);
//            if (temp == s1.charAt(i)) {
//                count++;
//            }
//            else {
//                s2.append(count);
//                s2.append(temp);
//                count = 1;
//            }
//            if(i == s1.length() - 1) {
//                s2.append(count);
//                s2.append(s1.charAt(i));
//            }
//        }
//        System.out.println(s2);
//    }
//}


// 3.Напишите метод, который принимает на вход строку (String) и определяет является ли строка палиндромом (возвращает boolean значение).

import java.io.FileWriter;
import java.util.Scanner;

//public class Main {
//    public static void main(String[] args) {
//        Scanner sc = new Scanner(System.in);
//        System.out.print("Введите строку: ");
//        String stroka = sc.nextLine();
//        sc.close();
//        boolean flag = false;
//
//        StringBuilder new_stroka = new StringBuilder(stroka);
//        new_stroka.reverse();
//        String str = new String(stroka);
//
//
//        System.out.println(new_stroka);
//
//        if (str.equals(stroka)) {
//            flag = true;
//        }
//        System.out.println(flag);
//
//    }
//
//}



// 4. Напишите метод, который составит строку, состоящую из 100 повторений слова TEST и метод,
// который запишет эту строку в простой текстовый файл, обработайте исключения.
//
//
//import java.io.File;
//import java.io.FileWriter;
//
//public class Main {
//    private static Object our_writer;
//
//    public static void main(String[] args) {
//        StringBuilder s = create_str();
//        create_file(s);
//    }
//
//    public static StringBuilder create_str() {
//        StringBuilder s = new StringBuilder();
//        for (int i = 0; i < 100; i++) {
//            s.append("TE-ST");
//        }
//        System.out.println(s);
//        return s;
//    }
//
//    public static void create_file(StringBuilder s) {
//        try (FileWriter our_writer = new FileWriter("f1")) {
//            our_writer.write(String.valueOf(s));
//        } catch (Exception error) {
//            System.out.println("Ошибка!");
//        } finally {
//            System.out.println("Конец работы с файлом!");
//        }
//    }
//}



















