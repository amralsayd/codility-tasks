A non-empty array A consisting of N integers is given. A pair of integers (P, Q), such that 0 ≤ P ≤ Q < N, is called a slice of array A. The sum of a slice (P, Q) is the total of A[P] + A[P+1] + ... + A[Q].

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A consisting of N integers, returns the maximum sum of any slice of A.

For example, given array A such that:

A[0] = 3  A[1] = 2  A[2] = -6
A[3] = 4  A[4] = 0
the function should return 5 because:

(3, 4) is a slice of A that has sum 4,
(2, 2) is a slice of A that has sum −6,
(0, 1) is a slice of A that has sum 5,
no other slice of A has sum greater than (0, 1).
Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..1,000,000];
each element of array A is an integer within the range [−1,000,000..1,000,000];
the result will be an integer within the range [−2,147,483,648..2,147,483,647].
Copyright 2009–2018 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.


using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int maxNumber = 0;
        if(A != null && A.Length > 0)
        {
            maxNumber = A[0];
            int arrayMod = A.Length % 2;
            int arrMiddle = A.Length / 2;
            for(int i = 0;i<A.Length;i=i+2)
            {
                int currentSum = A.Skip(i).Take(arrayMod == 1 && arrMiddle == i ? 1:2).Sum();
                //Console.WriteLine("currentSum "+currentSum);
                if(currentSum > maxNumber)
                    maxNumber = currentSum;
                    
                if(arrayMod == 1 && arrMiddle == i)
                    i = i-1;
            }
        }
        return maxNumber;
        
    }
}



using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int maxNumber = 0;
        if(A != null && A.Length > 0)
        {
            if(A.Length == 2)
                return A[0] > A[1] ? A[0]:A[1];
            if(A.Length == 3)
                return A[0] > A[1] && A[0] > A[2] ?  A[0] : A[1] > A[2] ? A[1]:A[0];

                
            maxNumber = A[0];
            int arrayMod = A.Length % 2;
            int arrMiddle = A.Length / 2;
            for(int i = 0;i<A.Length;i=i+2)
            {
                int currentSum = A.Skip(i).Take(arrayMod == 1 && arrMiddle == i ? 1:2).Sum();
                //Console.WriteLine("currentSum "+currentSum);
                if(currentSum > maxNumber)
                    maxNumber = currentSum;
                    
                if(arrayMod == 1 && arrMiddle == i)
                    i = i-1;
            }
        }
        return maxNumber;
        
    }
}