//1. �������� ��� ���������� ������ ������� ��� �������� ������� � �������� ���� � ������. ����������� � Java.
//2. ������� ��������� ���������.
//    - �������� �����, ������� ����� ����������� � ������������ �������� (��� ��������) ���������� � ������� ��������, ���������� �������. �������� ���������� ����� ������� � Map. ��������:
//        �������� �����, ��������������� ������������ ��������:
//        1 - �����
//        2 -����
//    - ����� ����� ��������� ����������� �������� ��� ��������� ��������� � ��������� ��������� ���������� ����� ����� � Map.
//    - ������������� �������� �� ��������������� ��������� � ������� ���������� �� ��������.

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
