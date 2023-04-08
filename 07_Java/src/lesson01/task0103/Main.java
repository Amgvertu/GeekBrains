package lesson01.task0103;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        float result;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Первое число: ");
        int firstNum = scanner.nextInt();

        System.out.print("Операция ( + ; - ; * ; / ): ");
        String operation = scanner.next();

        System.out.print("Второе число: ");
        int secondNum = scanner.nextInt();

        if (operation.equals("+")) {
            result = firstNum+secondNum;
            System.out.println("Результат = " + result);
        } else if (operation.equals("-")) {
            result = firstNum - secondNum;
            System.out.println("Результат = " + result);
        } else if (operation.equals("/")) {
        result = (float) firstNum / secondNum;
        System.out.println("Результат = " + result);
        } else if (operation.equals("*")) {
            result = firstNum * secondNum;
            System.out.println("Результат = " + result);
        } else {
            throw new RuntimeException("Неподдерживаемая операция!!!");
        }
    }
}
