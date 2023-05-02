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

import java.util.HashSet;
import java.util.Set;
import java.util.stream.Stream;

public class Main {

    public static void main(String[] args) {
        Set <Laptop> notebooks = new HashSet<>();
        notebooks.add(new Laptop("HP", "black"));
        notebooks.add(new Laptop("Samsung", "grey"));
        notebooks.add(new Laptop("Lenovo", "grey"));
        notebooks.add(new Laptop("Acer", "black"));
        notebooks.add(new Laptop("Sony", "white"));
        notebooks.add(new Laptop("MacBook", "black"));
        notebooks.add(new Laptop("MSI", "grey"));
        notebooks.add(new Laptop("Dexp", "grey"));
        System.out.println(notebooks);

    }
}
