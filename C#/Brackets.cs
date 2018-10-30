A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:

S is empty;
S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
S has the form "VW" where V and W are properly nested strings.
For example, the string "{[()()]}" is properly nested but "([)()]" is not.

Write a function:

class Solution { public int solution(String S); }

that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.

For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..200,000];
string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
Copyright 2009–2018 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.

using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        char[] SArray = S.Where(charItemin => charItemin == '(' ||charItemin == '{' || charItemin == '[' ||charItemin == ')' ||charItemin == '}' || charItemin == ']').ToArray();

        if(SArray == null || SArray.Length == 0)
            return 1;
        if(SArray[0] == ')' || SArray[0] == '}' || SArray[0] == ']')
            return 0;
        
        Stack<char> stringStack = new Stack<char>();
        foreach(char charItemin in SArray)
        {
           if(charItemin == '(' ||charItemin == '{' || charItemin == '[')
                stringStack.Push(charItemin);
           if(charItemin == ')' ||charItemin == '}' || charItemin == ']')
           {
               if(stringStack.Count() == 0)
                   return 0;
               char popItem = stringStack.Pop();
               if(charItemin == ')' && popItem != '(')
                    return 0;
               if(charItemin == '}' && popItem != '{')
                    return 0;
               if(charItemin == ']' && popItem != '[')
                    return 0;
           }
                
        }
        return stringStack.Count() != 0 ? 0:1;
    }
}