//–еализуйте очередь с помощью LinkedList со следующими методами:
//        Х enqueue() Ч помещает элемент в конец очереди,
//        Х dequeue() Ч возвращает первый элемент из очереди и удал€ет его,
//        Х first() Ч возвращает первый элемент из очереди, не удал€€.

package lesson04.task02;

import java.util.*;

public class Main {

    //ћожно было реализовать
    // list.addLast() - помещает элемент в конец очереди
    // list.poll() - возвращает первый элемент из очереди и удал€ет его
    // list.peek() - возвращает первый элемент из очереди, не удал€€
    public static void main(String[] args) {
        LinkedList<Integer> list = fillList(8, 0, 30);
        System.out.println(list);
        Scanner in = new Scanner(System.in);
        System.out.println("Source collection   " + list);
        System.out.println("Menu");
        System.out.println("1. Add element at the end of the collection ");
        System.out.println("2. Return first element and delete it ");
        System.out.println("3. Return first element");
        System.out.println("4. Exit");
        System.out.print("Your choice : ");

        if (in.hasNextInt()) {
            int x = in.nextInt();
            if (x == 1) {
                System.out.print("Enter number for add to collection");
                if ((in.hasNextInt())) {
                    int elementAdd = in.nextInt();
                    enqueue(list, elementAdd);
                    System.out.println(list);
                } else System.out.println(" ¬ы ввели не число");
            } else if (x == 2) {
                System.out.println("First element = " + dequeue(list));
                System.out.println(list);
                ;
            } else if (x == 3) {
                System.out.println("First element = " + first(list));
            }
        } else {
            System.out.println(" ¬ы ввели не число");
        }


    }

    public static LinkedList<Integer> fillList(int n, int min, int max) {
        Random rnd = new Random();
        LinkedList<Integer> list = new LinkedList<>();
        for (int i = 0; i < n; i++) {
            list.add(rnd.nextInt((max - min + 1) + min));
        }
        return list;
    }

    public static LinkedList<Integer> enqueue(LinkedList<Integer> list, int newInt) {
        list.addLast(newInt);
        return list;
    }

    public static int dequeue(LinkedList<Integer> list) {
        int first = list.get(0);
        list.remove(0);
        return first;
    }

    public static int first(LinkedList<Integer> list) {
        return list.get(0);
    }


}
