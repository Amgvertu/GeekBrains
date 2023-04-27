//Реализуйте структуру телефонной книги с помощью HashMap, учитывая, что 1 человек может иметь несколько телефонов.
package lesson05.task01;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static Scanner scanner = new Scanner(System.in);
    public static Map<String, ArrayList<String>> phoneBook = new HashMap<>();

    public static void main(String[] args) {
        String choice = "4";

        while (!choice.equals(3)) {
            System.out.println("\n");
            System.out.println("Menu");
            System.out.println("1. Add contact");
            System.out.println("2. View contacts");
            System.out.print("Your choice : ");
            choice = scanner.nextLine();
            if (choice.equals("1")) addContact();
            if (choice.equals("2")) System.out.println("\n" + phoneBook);
        }
    }

    public static void addContact() {
        boolean flag = true;
        ArrayList<String> phoneNumbers = new ArrayList<>();
        int i = 1;
        String phoneNumberIn = " ";
        System.out.println("Contact to add...");
        System.out.print("Name: ");
        String name = scanner.nextLine();
        if (checkKey(name)) {
            System.out.print("Contact with same name is already exist, overwrite? (y/n):");
            if (scanner.nextLine().equals("n")) flag = false;
        }
        if (flag) {
            while (!phoneNumberIn.equals("")) {
                System.out.print("Phone number " + i + ":");
                phoneNumberIn = scanner.nextLine();
                if (!phoneNumberIn.equals("")) {
                    phoneNumbers.add(phoneNumberIn);
                    System.out.println("Number " + phoneNumberIn + " was added to phonebook...");
                    i++;
                }
            }
            phoneBook.put(name, phoneNumbers);
        }
    }

    public static boolean checkKey(String checkKey) {
        return phoneBook.containsKey(checkKey);
    }

}
