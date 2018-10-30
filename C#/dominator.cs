An array A consisting of N integers is given. The dominator of array A is the value that occurs in more than half of the elements of A.

For example, consider array A such that

 A[0] = 3    A[1] = 4    A[2] =  3
 A[3] = 2    A[4] = 3    A[5] = -1
 A[6] = 3    A[7] = 3
The dominator of A is 3 because it occurs in 5 out of 8 elements of A (namely in those with indices 0, 2, 4, 6 and 7) and 5 is more than a half of 8.

Write a function

class Solution { public int solution(int[] A); }

that, given an array A consisting of N integers, returns index of any element of array A in which the dominator of A occurs. The function should return −1 if array A does not have a dominator.

For example, given array A such that

 A[0] = 3    A[1] = 4    A[2] =  3
 A[3] = 2    A[4] = 3    A[5] = -1
 A[6] = 3    A[7] = 3
the function may return 0, 2, 4, 6 or 7, as explained above.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..100,000];
each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].
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
        if(A != null && A.Length > 0)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int freqNumber = A.GroupBy(x => x)
                   .Select(x => new {Number=x.Key,Times=x.Count()})
                   .OrderByDescending(x=>x.Times).FirstOrDefault().Number;
                   
            int freqCount = A.GroupBy(x => x)
                   .Select(x => new {Number=x.Key,Times=x.Count()})
                   .OrderByDescending(x=>x.Times).FirstOrDefault().Times;
                   
            return freqCount >= (A.Length/2)+1 ? Array.FindIndex(A, x => x == freqNumber) : -1;
        }
        return -1;
    }
}