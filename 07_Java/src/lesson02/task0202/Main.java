//2. Дана строка json:
//        [{"фамилия":"Иванов","оценка":"5","предмет":"Математика"}, {"фамилия":"Петрова","оценка":"4","предмет":"Информатика"}, {"фамилия":"Краснов","оценка":"5","предмет":"Физика"}]
//        Написать метод, который распарсит этот текст и, используя StringBuilder, создаст строки вида:
//        Студент [фамилия] получил [оценка] по предмету [предмет]. Например:
//        Студент Иванов получил 5 по предмету Математика.
//        Студент Петрова получил 4 по предмету Информатика.
//        Студент Краснов получил 5 по предмету Физика.

package lesson02.task0202;

public class Main {

    public static final String JSON = "[{\"фамилия\":\"Иванов\",\"оценка\":\"5\",\"предмет\":\"Математика\"}, {\"фамилия\":\"Петрова\",\"оценка\":\"4\",\"предмет\":\"Информатика\"}, {\"фамилия\":\"Краснов\",\"оценка\":\"5\",\"предмет\":\"Физика\"}]";
    public static final String[] CONST = {"Студент ", " получил ", " по предмету "};
    public static void main(String[] args) {
        String temp = JSON.substring(2, JSON.length() - 2);
        temp = temp.replaceAll("}, \\{", ":");
        temp = temp.replaceAll("\"", "");
        temp = temp.replaceAll(",", ":");
        String[] tempArray = temp.split(":");
        StringBuilder strBu = new StringBuilder();
        int inInd = 0;
        for (int i = 1;i<tempArray.length;i+=2) {
            strBu.append(CONST[inInd]);
            strBu.append(tempArray[i]);
            if (inInd<2) inInd++;
            else {
                strBu.append(".\n");
                inInd = 0;
            }
        }
        String result = strBu.toString();
        System.out.println(result);
    }


}
