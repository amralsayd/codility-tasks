This is a demo task.

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
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
        int iterNumber = 1;
        if(A != null && A.Length > 0)
        {
            if(A.Max() < 0)
                return iterNumber;
            A = A.Where(x=> x > 0).ToArray();
            if(A != null && A.Length > 0)
            {
                A = A.Distinct().ToArray();
                Array.Sort(A);
                iterNumber = 1;//A.Where(x=> x >= 0).First();
                //Console.WriteLine("A.Length " + A.Length);
                for(int i=0 ; i < A.Length ;i++)
                {
                    if(iterNumber != A[i])
                        return iterNumber;
                    iterNumber++;
                }
            }
        }
        return iterNumber;
        
    }
}