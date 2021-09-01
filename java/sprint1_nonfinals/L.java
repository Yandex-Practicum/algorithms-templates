import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class L {

    private static char getExcessiveLetter(String s, String t) {
        // Ваше решение
    }

    public static void main(String[] args) throws IOException {
        try (BufferedReader reader = new BufferedReader(new InputStreamReader(System.in))) {
            String s = reader.readLine();
            String t = reader.readLine();
            System.out.println(getExcessiveLetter(s, t));

        }
    }
}
