//2. ���� ������ json:
//        [{"�������":"������","������":"5","�������":"����������"}, {"�������":"�������","������":"4","�������":"�����������"}, {"�������":"�������","������":"5","�������":"������"}]
//        �������� �����, ������� ��������� ���� ����� �, ��������� StringBuilder, ������� ������ ����:
//        ������� [�������] ������� [������] �� �������� [�������]. ��������:
//        ������� ������ ������� 5 �� �������� ����������.
//        ������� ������� ������� 4 �� �������� �����������.
//        ������� ������� ������� 5 �� �������� ������.

package lesson02.task0202;

public class Main {

    public static final String JSON = "[{\"�������\":\"������\",\"������\":\"5\",\"�������\":\"����������\"}, {\"�������\":\"�������\",\"������\":\"4\",\"�������\":\"�����������\"}, {\"�������\":\"�������\",\"������\":\"5\",\"�������\":\"������\"}]";
    public static final String[] CONST = {"������� ", " ������� ", " �� �������� "};
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
