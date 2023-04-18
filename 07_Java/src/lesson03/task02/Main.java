//ѕусть дан произвольный список целых чисел, удалить из него чЄтные числа

package lesson03.task02;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("¬ведите размер списка:");
        int n = in.nextInt();
        ArrayList<Integer> array = fillList(n,0,100);
        System.out.println(array.toString());
        deleteEven(array);
        System.out.println(array.toString());
    }

    public static ArrayList<Integer> fillList(int n, int min, int max) {
        Random rnd = new Random();
        ArrayList<Integer> list = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            list.add(rnd.nextInt((max - min + 1) + min));
        }
        return list;
    }

    public static void deleteEven(ArrayList<Integer> listIn) {
        for (int i = 0; i < listIn.size(); i++) {
            if (listIn.get(i) % 2 == 0) {
                listIn.remove(i);
                i--;
            }
        }
    }
}
