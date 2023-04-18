//Задан целочисленный список ArrayList. Найти минимальное, максимальное и среднее арифметическое этого списка

package lesson03.task03;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Введите размер списка:");
        int n = in.nextInt();
        ArrayList<Integer> array = fillList(n, 0, 100);
        System.out.println(array.toString());
        double[] maxMinMid = maxMinMid(array);
        System.out.println("Max = " + (int) maxMinMid[0]);
        System.out.println("Min = " + (int) maxMinMid[1]);
        System.out.println("mid = " + maxMinMid[2]);
    }

    public static ArrayList<Integer> fillList(int n, int min, int max) {
        Random rnd = new Random();
        ArrayList<Integer> list = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            list.add(rnd.nextInt((max - min + 1) + min));
        }
        return list;
    }

    public static double[] maxMinMid(ArrayList<Integer> list) {
        int max = list.get(0);
        int min = list.get(0);
        int sum = 0;
        for (int i = 0; i < list.size(); i++) {
            if (max < list.get(i)) max = list.get(i);
            if (min > list.get(i)) min = list.get(i);
            sum = sum + list.get(i);
        }
//        System.out.println(sum);
//        System.out.println(list.size());
        return new double[]{max, min, (double) sum / list.size()};
    }
}
