import java.util.Scanner;

public class A {

    private static int evaluateFunction(int a, int b, int c, int x) {
        // Ваше решение
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int a = scanner.nextInt();
        int x = scanner.nextInt();
        int b = scanner.nextInt();
        int c = scanner.nextInt();
        System.out.println(evaluateFunction(a, b, c, x));
        scanner.close();
    }
}