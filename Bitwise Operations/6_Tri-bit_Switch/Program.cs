﻿int number = int.Parse(Console.ReadLine());
int posiotion = int.Parse(Console.ReadLine());

/*
 6. * Tri-bit Switch

Write a program that inverts the 3 bits from position p to the left with their XOR opposites (e.g., 111 -> 000, 101 -> 010) in a 32-bit number. Print the resulting integer on the console.

Examples

Input  Output  Comments
1234   1874    00000000000000000000010011010010 --> 00000000000000000000011101010010
7 
44444  44524   00000000000000001010110110011100 --> 00000000000000001010110111101100
4 

Hints

1. Shift the number 7 (the number 7 has the bits 111, which we use to get 3 consecutive values), p times to the left (where p is the position) by using the << operator. In that way, the 3 bits we want to invert will be at position p. Save the resulting value in the mask.

2. Use the ^ mask operator expression to invert the values of the three bits starting from position p. By using the following formulae (n ^ mask), you copy all the bits of the number, and you invert the bits at position p, p+1, and p+2.

3. Save the result in result.
 */