import java.util.Scanner;

// Вычислить n-ое треугольного число (сумма чисел от 1 до n), n! (произведение чисел от 1 до n)
public class Task_01_01 {
    public static void main(String[] args) {
        int sum = 0;
        int multi = 1;
        System.out.print("Введите n:");
        Scanner scanner = new Scanner(System.in); 
        String enter = scanner.next(); 
        int n = Integer.parseInt(enter);
            for(int i = 1; i < n+1; i++) {
                sum = sum + i; 
                multi = multi * i;
            }
        System.out.println(sum);
        System.out.println(multi);
    }
}