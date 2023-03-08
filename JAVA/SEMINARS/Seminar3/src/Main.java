// 1. Заполнить список десятью случайными числами.
//    Отсортировать список методом sort() и вывести его на экран.

//
//import java.util.*;
//
//public class Main {
//    public static void main(String[] args) {
//
//        ArrayList<Integer> list = new ArrayList<Integer>();
//        Random rand = new Random();
////        list.add(rand.nextInt(10, 20));
//
//        int min = 20;
//        int max = 40;
//        for(int i = 0; i < 10; i++) {
//            list.add(rand.nextInt(max - min + 1) + min);
//        }
//        System.out.println(list);
//
//        Collections.sort(list);
//        System.out.println(list);
//
//        ArrayList<Integer> list1 = new ArrayList<Integer>();
//        Random random = new Random();
//        int min1 = 10;
//        int max2 = 20;
//        for(int i = 0; i < 10; i++) {
//            list.add(rand.nextInt(max2 - min1 + 1) + min1);
//        }
//        System.out.println(list1);
//
//        list1.sort(Comparator.reverseOrder());
//        System.out.println(list1);
//
//    }
//}


// 2.Заполнить список названиями планет Солнечной системы в произвольном порядке с повторениями.
//   Вывести название каждой планеты и количество его повторений в списке.

//Пройти по списку из предыдущего задания и удалить повторяющиеся элементы.
//
//import java.lang.reflect.Array;
//import java.util.ArrayList;
//import java.util.Arrays;
//import java.util.Random;
//
//public class Main {
//    public static void main(String[] args) {
//
//        ArrayList<String> planets = new ArrayList<String>(Arrays.asList("Нептун", "Марс", "Плутон", "Марс", "Земля", "Марс", "Сатурн", "Юпитер", "Юпитер",""));
//
//        System.out.println(planets);
//
//        int total = 1;
//        for(int i = 0; i < planets.size()-1; i++) {
//            for(int j = i+1; j < planets.size()-1; j++) {
//                if (planets.get(i).equals(planets.get(j))) {
//                    total += 1;
//                    planets.remove(planets.get(j));
//
//                }
//            }
//            System.out.printf("Планета %s повторяется %d раз. \n", planets.get(i), total);
//            total = 1;
//        }
//
//    }
//}

