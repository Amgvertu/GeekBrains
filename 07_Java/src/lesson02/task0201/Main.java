package lesson02.task0201;

import java.io.IOException;
import java.util.Arrays;
import java.util.logging.*;

public class Main {
    public static Logger logger = Logger.getLogger(Main.class.getName());

    public static void main(String[] args) {
        int n = (int) ((Math.random() * (10 - 5)) + 5);
        int[] array = new int[n];
        for (int i = 0; i < n; i++) {
            array[i] = (int) ((Math.random() * (20 - 0)) + 0);
        }
        System.out.println(Arrays.toString(array));
        try {
            System.out.println(Arrays.toString(bubbleSort(array)));
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static int[] bubbleSort(int[] arr) throws IOException {
        int tmp;
        int n = 1;
        FileHandler fh = new FileHandler("src//lesson02//task0201//log.txt", true);
        SimpleFormatter sFormat = new SimpleFormatter();
        fh.setFormatter(sFormat);
        logger.addHandler(fh);
        for (int i = arr.length - 1; i >= 1; i--) {
            for (int j = 0; j < i; j++) {
                n++;
                logger.log(Level.INFO, n + "   " + Arrays.toString(arr));
                if (arr[j] > arr[j + 1]) {
                    tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tmp;
                }
            }
        }
        logger.log(Level.INFO, "Сортирвка массива закончена за " +n+" действий \n");
        return arr;
    }

}










