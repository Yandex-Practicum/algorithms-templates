import java.util.List;

public class E {

    // Если ответ существует, верните список из двух элементов
    // Если нет - то верните пустой список 
    private static List<Integer> solveTwoSum(List<Integer> arr, int k) {
        // Ваше решение
    }
    public static void main(String[] args) {
        try (BufferedReader reader = new BufferedReader(new InputStreamReader(System.in))) {
            int n = readInt(reader);
            List<Integer> a = readList(reader);
            int k = readInt(reader);
            List<Integer> result = solveTwoSum(a, k);
            if (result.isEmpty()) {
                System.out.println("None");
            } else {
                System.out.println(result.get(0) + " " + result.get(1));
            }
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