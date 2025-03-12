import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        System.out.println("================================");
        for(int i=1;i<=3;i++){
            String s1=sc.next();
            int x=sc.nextInt();

            if (s1.length() <= 10) {
                if(x>=0 && x<=999){
                    System.out.println(String.format("%-15s",s1)+String.format("%03d",x));
                }else {
                    System.out.println("Değer Aralığını aştınız.");
                }
            }else{
                System.out.println("String değer adedini aştınız");
            }
        }
        System.out.println("================================");


    }
}