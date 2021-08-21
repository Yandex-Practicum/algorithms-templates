import java.io.IOException;
import java.io.BufferedReader;
import java.io.InputStreamReader;

public class F {

    private static boolean isPalindrome(String text) {
        // Ваше решение
    }
    public static void main(String[] args) throws IOException{
        try (BufferedReader reader = new BufferedReader(new InputStreamReader(System.in))) {
            String text = reader.readLine();
            if (isPalindrome(text)) {
                System.out.println("True");
            } else {
                System.out.println("False");
            }
        }
    }
}
