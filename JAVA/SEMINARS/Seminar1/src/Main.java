// Дан массив двоичных чисел, например [1,1,0,1,1,1], вывести максимальное количество подряд идущих 1.

//public class Main {
//    public static void main(String[] args) {
//        int[] arr = new int[]{1,1, 0, 0, 0, 0, 1,1,1, 0,0, 1, 1};
//        int count = 0;
//        int temp = 0;
//        for (int i = 0; i < arr.length; i++){
//            if (arr[i] == 1){
//                count += 1;
//            } else {
//                if (temp < count){
//                    temp = count;
//                }
//                count = 0;
//            }
//            if (temp < count){
//                temp = count;
//            }
//        }
//        System.out.println(temp);
//    }
//}


//Дан массив nums = [3,2,2,3] и число val = 3.
//Если в массиве есть числа, равные заданному, нужно перенести эти элементы в конец массива.
//Таким образом, первые несколько (или все) элементов массива должны быть отличны от заданного, а остальные - равны ему.

//public class Main {
//    public static void main(String[] args) {
//        int[] arr = new int[]{3,3, 3, 3, 2,2,3};
//        int temp = 0;
//        for (int i = 0; i < arr.length-1; i++){
//            if (arr[i] == 3){
//                temp = arr[i];
//                for (int j = i+1; j < arr.length; j++) {
//                    if (arr[j] != 3){
//                        arr[i] = arr[j];
//                        arr[j] = temp;
//                        break;
//                    }
//                }
//            }
//        }
//        for (int i = 0; i < arr.length; i++) {
//            System.out.println(arr[i]);
//        }
//    }
//}


// Напишите метод, который находит самую длинную строку общего префикса среди массива строк. Если общего префикса нет, вернуть пустую строку ' '

//public class Main {
//    public static void main(String[] args) {
//        String[] arr = new String[]{"abc", "abcde", "abcdefg", "acvbd", "abcdf", "vbabckfl", "lkjadldjabck"};
//        String temp = "";
//        String pref_x = "abc";
//        for (int i = 0; i < arr.length; i++){
//            if (arr[i].contains(pref_x)){
//                if (temp.length() < arr[i].length()){
//                    temp = arr[i];
//                }
//            }
//        }
//        System.out.println(temp);
//    }
//}

//public class Main {
//    public static void main(String[] args) {
//        String my_str = "Добро пожаловать на курс по Java";
//        String[] arr = my_str.split(" ");
//        String temp = "";
//        for (int i = 0; i < arr.length/2; i++) {
//            temp = arr[i];
//            arr[i] = arr[arr.length - 1 - i];
//            arr[arr.length - 1 - i] = temp;
//        }
//        my_str = String.join(" ", arr);
//        System.out.println(my_str);
//    }
//}