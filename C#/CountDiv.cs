Write a function:

class Solution { public int solution(int A, int B, int K); }

that, given three integers A, B and K, returns the number of integers within the range [A..B] that are divisible by K, i.e.:

{ i : A ≤ i ≤ B, i mod K = 0 }

For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range [6..11], namely 6, 8 and 10.

Write an efficient algorithm for the following assumptions:

A and B are integers within the range [0..2,000,000,000];
K is an integer within the range [1..2,000,000,000];
A ≤ B.
Copyright 2009–2018 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.

A = 11, B = 345, K = 17

A = B in {0,1}, K = 11

A = 10, B = 10, K in {5,7,20}

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int iterMinNumber = A + (A%K);
        int iterMaxNumber = B - (B%K);
        //Console.WriteLine("iterMinNumber " + iterMinNumber);
        //Console.WriteLine("iterMaxNumber " + iterMaxNumber);
        int times = (iterMaxNumber - iterMinNumber) / K;
        return times+1;
        //int i = 0;
        //for(i = 0;iterNumber <= B;i++)
        //    iterNumber = iterNumber + K;
        //return i;
    }
}

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        int iterMinNumber = A%K > 0 ? A + (K-(A%K)) : A;
        int iterMaxNumber = B - (B%K);
        
        //Console.WriteLine("iterMinNumber " + iterMinNumber);
        //Console.WriteLine("iterMaxNumber " + iterMaxNumber);
        
        if(iterMinNumber > iterMaxNumber)
            return 0;


        //Console.WriteLine("iterMinNumber " + iterMinNumber);
        //Console.WriteLine("iterMaxNumber " + iterMaxNumber);
        int times = (iterMaxNumber - iterMinNumber) / K;
        return times+1;
    }
}