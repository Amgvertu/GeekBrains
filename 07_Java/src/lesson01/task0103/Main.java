package lesson01.task0103;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        float result;
        Scanner scanner = new Scanner(System.in);

        System.out.print("������ �����: ");
        int firstNum = scanner.nextInt();

        System.out.print("�������� ( + ; - ; * ; / ): ");
        String operation = scanner.next();

        System.out.print("������ �����: ");
        int secondNum = scanner.nextInt();

        if (operation.equals("+")) {
            result = firstNum+secondNum;
            System.out.println("��������� = " + result);
        } else if (operation.equals("-")) {
            result = firstNum - secondNum;
            System.out.println("��������� = " + result);
        } else if (operation.equals("/")) {
        result = (float) firstNum / secondNum;
        System.out.println("��������� = " + result);
        } else if (operation.equals("*")) {
            result = firstNum * secondNum;
            System.out.println("��������� = " + result);
        } else {
            throw new RuntimeException("���������������� ��������!!!");
        }
    }
}
