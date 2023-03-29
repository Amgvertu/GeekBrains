// 2. Вывести все простые числа от 1 до 1000
//    Простые числа - числа которые деляться только на 1 и на само себя без остатка(кроме 1).

public class Task_01_02 {
    public static void main(String[] args) {
        boolean flag1,flag2;
        int[] x = new int[] {2,3,5,7};
        for (int i = 2;i<=40;i++) {
            flag1 = true;
            flag2 = false;
            for (int j = 0;j<x.length;j++) {
                if ((i%x[j] == 0)&&(i>7)) flag1 = false;
                if (((double)i/x[j] == 1)&&(i<=7)) flag2 =true;
            }
            if ((flag1)&&(i>7)) System.out.println(i);
            if ((flag2)&&(i<=7)) System.out.println(i);
        }
    }
}
