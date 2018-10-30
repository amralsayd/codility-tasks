A non-empty array A consisting of N integers is given.

A permutation is a sequence containing each element from 1 to N once, and only once.

For example, array A such that:

    A[0] = 4
    A[1] = 1
    A[2] = 3
    A[3] = 2
is a permutation, but array A such that:

    A[0] = 4
    A[1] = 1
    A[2] = 3
is not a permutation, because value 2 is missing.

The goal is to check whether array A is a permutation.

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A, returns 1 if array A is a permutation and 0 if it is not.

For example, given array A such that:

    A[0] = 4
    A[1] = 1
    A[2] = 3
    A[3] = 2
the function should return 1.

Given array A such that:

    A[0] = 4
    A[1] = 1
    A[2] = 3
the function should return 0.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [1..1,000,000,000].
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
        if(A != null && A.Length > 0)
        {
            //Console.WriteLine("missingNumber(A) " + missingNumber(A));
            return missingNumber(A) > 0 ? 0:1;
            return A.GroupBy(x => x)
               .Select(x => new {Number=x.Key,Times=x.Count()})
               .Where(x => x.Times % 2 == 1).FirstOrDefault().Number;
        }
        return 0;
    }
    
    public int missingNumber(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int currentNumber = 1;
        if(A != null && A.Length > 0)
        {
            Array.Sort(A);
            //currentNumber = A[0];
            //currentNumber++;
            for(int i=0 ; i < A.Length ;i++)
            {
                if(i+1 != A[i])
                    return i+1;
                currentNumber++;
            }
        }
        return 0;
    }
    
}