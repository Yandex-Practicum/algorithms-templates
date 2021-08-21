import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;


public class G {

    private static String getBinaryNumber(int n) {
        // Ваше решение
    }
    public static void main(String[] args) {
        try (BufferedReader reader = new BufferedReader(new InputStreamReader(System.in))) {
            int n = readInt(reader);
            System.out.println(getBinaryNumber(n));
        }
    }

    private static int readInt(BufferedReader reader) throws IOException {
        return Integer.parseInt(reader.readLine());
    }
}
