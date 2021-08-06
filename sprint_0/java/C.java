import java.io.BufferedReader;
import java.io.IOException;

public class C {

    private static double movingAverage(int n, ArrayList<Integer> arr, int k) {
        // ваше решение
    }

    public static void main(String[] args) {
        try (BufferedReader reader = new BufferedReader(new InputStreamReader(System.in))) {
            int n = readInt(reader);
            List<Integer> a = readList(reader);
            int k = readInt(reader);
            System.out.println(movingAverage(n, a, k));
        }
    }


    private static int readInt(BufferedReader reader) throws IOException {
        return Integer.parseInt(reader.readLine());
    }

    private static List<Integer> readList(BufferedReader reader) throws IOException {
        return  Arrays.asList(reader.readLine().split(" "))
                        .stream()
                        .map(elem -> Integer.parseInt(elem))
                        .collect(Collectors.toList());
    }
}