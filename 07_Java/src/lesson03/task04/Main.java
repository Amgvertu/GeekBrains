//Реализовать разность массивов и симметрическую разность.

package lesson03.task04;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Введите размер списка 1:");
        ArrayList<Integer> arrayFirst = fillList(in.nextInt(), 0, 15);
        System.out.print("Введите размер списка 2:");
        ArrayList<Integer> arraySecond = fillList(in.nextInt(), 0, 15);
        System.out.println("Массив А: " + arrayFirst.toString());
        System.out.println("Массив В: " + arraySecond.toString());
        System.out.println("Разность массивов А и В: " + diff(arrayFirst,arraySecond).toString());
        System.out.println("Симметрическая разность массивов А и В: " + simDiff(arrayFirst,arraySecond).toString());

    }

    public static ArrayList<Integer> fillList(int n, int min, int max) {
        Random rnd = new Random();
        ArrayList<Integer> list = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            list.add(rnd.nextInt((max - min + 1) + min));
        }
        return list;
    }

    public static ArrayList<Integer> diff(ArrayList<Integer> arrayA, ArrayList<Integer> arrayB) {
        ArrayList<Integer> resultDiff = new ArrayList<>();
        for (int i = 0; i < arrayA.size(); i++) {
            if (!arrayB.contains(arrayA.get(i))&&(!resultDiff.contains(arrayA.get(i)))) {
                resultDiff.add(arrayA.get(i));
            }
        }
        return resultDiff;
    }

    public static ArrayList<Integer> simDiff(ArrayList<Integer> arrayA, ArrayList<Integer> arrayB) {
        ArrayList<Integer> resultSimDiff = new ArrayList<>();
        for (int i = 0; i < arrayA.size(); i++) {
            if (!arrayB.contains(arrayA.get(i))&&(!resultSimDiff.contains(arrayA.get(i)))) {
                resultSimDiff.add(arrayA.get(i));
            }
        }
        for (int i = 0; i < arrayB.size(); i++) {
            if (!arrayA.contains(arrayB.get(i))&&(!resultSimDiff.contains(arrayB.get(i)))) {
                resultSimDiff.add(arrayB.get(i));

            }
        }
        return resultSimDiff;
    }

}
