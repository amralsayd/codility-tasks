An array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, and the last element of the array is moved to the first place. For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7] (elements are shifted right by one index and 6 is moved to the first place).

The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.

Write a function:

class Solution { public int[] solution(int[] A, int K); }

that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.

For example, given

    A = [3, 8, 9, 7, 6]
    K = 3
the function should return [9, 7, 6, 3, 8]. Three rotations were made:

    [3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
    [6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
    [7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
For another example, given

    A = [0, 0, 0]
    K = 1
the function should return [0, 0, 0]

Given

    A = [1, 2, 3, 4]
    K = 4
the function should return [1, 2, 3, 4]

Assume that:

N and K are integers within the range [0..100];
each element of array A is an integer within the range [−1,000..1,000].
In your solution, focus on correctness. The performance of your solution will not be the focus of the assessment.

Copyright 2009–2018 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.


using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        for (int i = 0; i < K; i++)
            A = shiftArray(A);
        return A;
    }
    
    public int[] shiftArray(int[] arr) 
    {
		if(arr != null && arr.Length > 0)
		{
			int[] currentArray = new int[arr.Length];
			for (int i = 1; i < arr.Length; i++) 
				currentArray[i] = arr[i - 1];
			currentArray[0] = arr[currentArray.Length - 1];
			return currentArray;
		}
		return arr;
    }

}


extreme_empty 
empty array ✘RUNTIME ERROR 
tested program terminated with exit code 1
1. 0.020 s OK
2. 0.020 s RUNTIME ERROR,  tested program terminated with exit code 1
stderr:
Unhandled Exception:
System.IndexOutOfRangeException: Array index is out of range.
  at Solution.shiftArray (System.Int32[] arr) [0x00000] in <filename unknown>:0 
  at Solution.solution (System.Int32[] A, Int32 K) [0x00000] in <filename unknown>:0 
  at SolutionWrapper.run (System.String input, System.String output) [0x00000] in <filename unknown>:0 
  at SolutionWrapper.Main (System.String[] args) [0x00000] in <filename unknown>:0 
[ERROR] FATAL UNHANDLED EXCEPTION: System.IndexOutOfRangeException: Array index is out of range.
  at Solution.shiftArray (System.Int32[] arr) [0x00000] in <filename unknown>:0 
  at Solution.solution (System.Int32[] A, Int32 K) [0x00000] in <filename unknown>:0 
  at SolutionWrapper.run (System.String input, System.String output) [0x00000] in <filename unknown>:0 
  at SolutionWrapper.Main (System.String[] args) [0x00000] in <filename unknown>:0 