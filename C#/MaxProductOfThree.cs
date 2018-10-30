A non-empty array A consisting of N integers is given. The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R] (0 ≤ P < Q < R < N).

For example, array A such that:

  A[0] = -3
  A[1] = 1
  A[2] = 2
  A[3] = -2
  A[4] = 5
  A[5] = 6
contains the following example triplets:

(0, 1, 2), product is −3 * 1 * 2 = −6
(1, 2, 4), product is 1 * 2 * 5 = 10
(2, 4, 5), product is 2 * 5 * 6 = 60
Your goal is to find the maximal product of any triplet.

Write a function:

class Solution { public int solution(int[] A); }

that, given a non-empty array A, returns the value of the maximal product of any triplet.

For example, given array A such that:

  A[0] = -3
  A[1] = 1
  A[2] = 2
  A[3] = -2
  A[4] = 5
  A[5] = 6
the function should return 60, as the product of triplet (2, 4, 5) is maximal.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [3..100,000];
each element of array A is an integer within the range [−1,000..1,000].
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
        
        Array.Sort(A);
        Array.Reverse(A);
        //Console.WriteLine("this is a debug message "+ A[0]+" "+A[A.Length-2]+" "+A[A.Length-1]);
        bool isMinusList = A.Where(x=> x > 0).Count() == 0;
        if(A.Length == 3 || isMinusList)
            return A[0]*A[1]*A[2];
        else //if(A.Length = 4)
        {

                return A[0]*A[1]*A[2] > A[0]*A[A.Length-2]*A[A.Length-1] ? A[0]*A[1]*A[2] : A[0]*A[A.Length-2]*A[A.Length-1];
            //if(A[0]*A[1] > A[A.Length-2]*A[A.Length-1])
            //    return A[0]*A[1]*A[2];
            //else
            //    return A[0]*A[A.Length-2]*A[A.Length-1];
        }
        
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
        
        Array.Sort(A);
        Array.Reverse(A);
        bool isMinusList = A.Where(x=> x > 0).Count() == 0;
        if(A.Length == 3 || isMinusList)
            return A[0]*A[1]*A[2];
        else //if(A.Length = 4)
        {
            if(A[0]*A[1] > A[A.Length-2]*A[A.Length-1])
                return A[0]*A[1]*A[2];
            else
                return A[0]*A[A.Length-2]*A[A.Length-1];
        }
        
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
        Array.Sort(A);
        Array.Reverse(A);
        A = A.Take(3).ToArray();
        int maxProduct = 1;
        foreach(int x in A)
            maxProduct = maxProduct * x;
        return maxProduct;
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
        int maxNumberMinus = 1;
        int maxNumberPositive = 1;

        int[] minusArray = A.Where(x => x < 0).ToArray();
        if(minusArray != null && minusArray.Length > 0)
        {
            Array.Sort(minusArray);
            if(minusArray.Length > 1)
                maxNumberMinus = minusArray[0] * minusArray[1];
        }
        
        int[] postiveArray = A.Where(x=> x > 0).ToArray();
        if(postiveArray != null && postiveArray.Where(x=> x > 0).Count() > 0)   
        {
            Array.Sort(postiveArray);
            Array.Reverse(postiveArray);
            if(postiveArray.Length > 1)
                maxNumberPositive = postiveArray[0] * postiveArray[1];
        }
        
        int lastNumber =  postiveArray != null && postiveArray.Where(x=> x > 0).Count() > 0 ?    
        Console.WriteLine("maxNumberMinus "+ maxNumberMinus);
        Console.WriteLine("maxNumberPositive "+ maxNumberPositive);
        
        if(maxNumberPositive > maxNumberMinus)
        {
            if()
            maxNumberPositive = maxNumberPositive * postiveArray[2];
        }
        if(maxNumberPositive < maxNumberMinus)
        {
            maxNumberPositive = maxNumberMinus * postiveArray[0];
        }
        
        return maxNumberPositive;   
            
        //Array.Sort(A);
        //Array.Reverse(A);
        //A = A.Take(3).ToArray();
        //int maxProduct = 1;
        //foreach(int x in A)
        //    maxProduct = maxProduct * x;
        //return maxProduct;
    }
}