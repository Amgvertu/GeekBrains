package lesson01.task0101;

import java.util.Scanner;

public class Main {
     // ��������� n-�� ������������ ����� (����� ����� �� 1 �� n), n! (������������ ����� �� 1 �� n)
        public static void main(String[] args) {
            int sum = 0;
            int multi = 1;
            System.out.print("������� n:");
            Scanner scanner = new Scanner(System.in);
            int n = scanner.nextInt();
            scanner.close();
            for(int i = 1; i <= n; i++) {
                sum = sum + i;
                multi = multi * i;
            }
            System.out.println(n+"-�� ����������� ����� = "+sum);
            System.out.println(n+"! = "+multi);
    }
}
