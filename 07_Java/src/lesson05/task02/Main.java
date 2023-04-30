//Пусть дан список сотрудников: Иван Иванов,Светлана Петрова,Кристина Белова,Анна Мусина,Анна Крутова,
//        Иван Юрин,Петр Лыков,Павел Чернов,Иван Иванов,Петр Чернышов,Мария Федорова,Марина Светлова,
//        Мария Савина,Иван Иванов,Мария Рыкова,Анна Крутова,Марина Лугова,Анна Владимирова,Петр Лыков,
//        Иван Мечников,Петр Петин,Петр Лыков,Иван Ежов
//
//        Написать программу, которая найдёт и выведет повторяющиеся имена с количеством повторений. Отсортировать по убыванию популярности.

package lesson05.task02;

import java.util.*;

public class Main {
    public static ArrayList<String> list = new ArrayList<>(Arrays.asList("Иван Иванов", "Светлана Петрова", "Кристина Белова", "Анна Мусина", "Анна Крутова",
            "Иван Юрин", "Петр Лыков", "Павел Чернов", "Иван Иванов", "Петр Чернышов", "Мария Федорова", "Марина Светлова",
            "Мария Савина", "Иван Иванов", "Мария Рыкова", "Анна Крутова", "Марина Лугова", "Анна Владимирова", "Петр Лыков",
            "Иван Мечников", "Петр Петин", "Петр Лыков", "Иван Ежов"));
    public static ArrayList<String> listOptimized = new ArrayList<>();
    public static HashMap<String, Integer> mapNames = new HashMap<>();

    public static void main(String[] args) {
        listOptimized = fioToName((list));
        fillMap();
        System.out.println(mapSort(mapNames));
    }

    public static String getName(String fio) {
        String[] name = fio.split(" ");
        return name[0];
    }

    public static ArrayList<String> fioToName(ArrayList<String> arrayIn) {
        ArrayList<String> arrayOut = new ArrayList<>();
        for(int i  = 0;i<list.size();i++) arrayOut.add(getName(arrayIn.get(i)));
        return arrayOut;
    }

    public static void fillMap( ) {
       for(String value:listOptimized)
           if (Collections.frequency(listOptimized,value)>1)
               mapNames.put(value, Collections.frequency(listOptimized,(value)));
    }

    public static LinkedHashMap<String, Integer> mapSort(HashMap<String, Integer> hashMapIn) {
        LinkedHashMap<String, Integer> sortedMap = new LinkedHashMap<>();
        ArrayList<Integer> list = new ArrayList<>();
        for (Map.Entry<String, Integer> entry : hashMapIn.entrySet()) {
            list.add(entry.getValue());
        }
        Collections.sort(list, Collections.reverseOrder());
        for (int num : list) {
            for (Map.Entry<String, Integer> entry : hashMapIn.entrySet()) {
                if (entry.getValue().equals(num)) {
                    sortedMap.put(entry.getKey(), num);
                }
            }
        }
        return sortedMap;
    }

//    public static void countName() {
//        for(String value:list) {
//            if (mapNames.containsKey(getName(value))) mapNames.put(getName(value),mapNames.get(getName(value))+1);
//
//        }
//    }

}

