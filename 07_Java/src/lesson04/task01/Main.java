//Пусть дан LinkedList с несколькими элементами. Реализуйте метод, который вернёет «перевёрнутый» список.

package lesson04.task01;

import java.util.LinkedList;

public class Main {

    public static void main(String[] args) {
        LinkedList<Integer> list = fillList(8);
        System.out.println(list);
        reverseList(list);
        System.out.println(list);
    }

    public static LinkedList<Integer> fillList(int n) {
        LinkedList<Integer> list = new LinkedList<>();
        for (int i = 0; i < n; i++) {
            list.add(i + 1);
        }
        return list;
    }

    public static LinkedList<Integer> reverseList(LinkedList<Integer> list) {
        for (int i = list.size() - 2; i >= 0; i--) {
            list.addLast(list.get(i));
            list.remove(i);
        }
        return list;
    }


}
