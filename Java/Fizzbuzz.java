public class Fizzbuzz {
    public static void main(String[] args){
        // Fizzbuzz strings and multiples
        String[] fizzBuzz = {"Fizz","Buzz"};
        int[] multiples = {3,5};

        // Loop from 1 to 100
        for (int i = 1; i <=100; i++){
            // Empty string
            StringBuilder output = new StringBuilder();
           // Check if multiple
           for(int j = 0; j < multiples.length; j++){
               if (i % multiples[j] == 0){
                   // Add the relevant string
                   output.append(fizzBuzz[j]);
               }
           }
           // If the string is empty
           if (output.toString().equals("")){
               System.out.println(i);
           }
           else{
               System.out.println(output);
           }
        }
    }
}
