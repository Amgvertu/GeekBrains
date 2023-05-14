//1. Подумать над структурой класса Ноутбук для магазина техники — выделить поля и методы. Реализовать в Java.
//2. Создать множество ноутбуков.
//    - Написать метод, который будет запрашивать у пользователя критерий (или критерии) фильтрации и выведет ноутбуки, отвечающие фильтру. Критерии фильтрации можно хранить в Map. Например:
//        “Введите цифру, соответствующую необходимому критерию:
//        1 - бренд
//        2 -цвет
//    - Далее нужно запросить минимальные значения для указанных критериев — сохранить параметры фильтрации можно также в Map.
//    - Отфильтровать ноутбуки их первоначального множества и вывести проходящие по условиям.

package lesson06;

import lesson06.model.Laptop;

import java.util.*;
import java.util.stream.Stream;

public class Main {

    public static void main(String[] args) {
        Set <Laptop> laptopsSet = new HashSet<>();
        Set <Laptop> laptopsResultFind = new HashSet<>();
        Laptop laptopFindCriteries = new Laptop();
        laptopsSet.add(new Laptop("HP", "black"));
        laptopsSet.add(new Laptop("Samsung", "grey"));
        laptopsSet.add(new Laptop("Lenovo", "grey"));
        laptopsSet.add(new Laptop("Acer", "black"));
        laptopsSet.add(new Laptop("Sony", "white"));
        laptopsSet.add(new Laptop("MacBook", "black"));
        laptopsSet.add(new Laptop("MSI", "grey"));
        laptopsSet.add(new Laptop("Dexp", "grey"));
       // System.out.println(notebooks);
        Map<Integer, Laptop> laptopMap = new HashMap<>();
        int i = 0;
        for(Laptop l:laptopsSet) {
            laptopMap.put(i,l);
            i++;
        }
        //System.out.println(laptopMap);
        Scanner in = new Scanner(System.in);
        System.out.print("Menu: \n" +
                            "1. View all laptop\n" +
                            "2. View laptop by brand\n" +
                            "3. View laptop by color\n" +
                            "4. View laptop by brand and color\n" +
                            "Your choice: ");
        int choice = in.nextInt();
        in.nextLine();
        if (choice == 1) System.out.println("\n" + laptopsSet);
        if (choice == 2) {
            System.out.print("Brand:");
            laptopFindCriteries.setBrand(in.nextLine());
            for (Map.Entry<Integer, Laptop> entry : laptopMap.entrySet()) {
                if (entry.getValue().equalsBrand(laptopFindCriteries)) laptopsResultFind.add(entry.getValue());
            }
        }
        if (choice == 3) {
            System.out.print("Color:");
            laptopFindCriteries.setColor(in.nextLine());
            for (Map.Entry<Integer, Laptop> entry : laptopMap.entrySet()) {
                if (entry.getValue().equalsColor(laptopFindCriteries)) laptopsResultFind.add(entry.getValue());
            }
        }
        if (choice == 4) {
            System.out.print("Brand:");
            laptopFindCriteries.setBrand(in.nextLine());
            System.out.print("Color:");
            laptopFindCriteries.setColor(in.nextLine());
            for (Map.Entry<Integer, Laptop> entry : laptopMap.entrySet()) {
                if (entry.getValue().equals(laptopFindCriteries)) laptopsResultFind.add(entry.getValue());
            }
        }
        System.out.println(laptopsResultFind);

    }
}
