
/*Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
Example 1:
Input: "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"
Note: In the string, each word is separated by single space and there will not be any extra space in the string.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseWordsInAStringIII
{
    public class Solution
    {
        //系统库自带方法System.Array.Reverse()
        //public string ReverseWords(string s)
        //{
        //    string[] str = s.Split(' ');
        //    s = "";
        //    int l = str.Length;
        //    for (int i = 0; i < l; i++)
        //    {
        //        char[] arr = str[i].ToCharArray();
        //        Array.Reverse(arr);

        //        str[i] = new string(arr);

        //        s += str[i] + " ";
        //    }
        //    return s.Trim();
        //}

        ////自实现字符反转,且遍历数组一半长度
        //public string ReverseWords(string s)
        //{
        //    string[] str = s.Split(' ');
        //    s = "";
        //    int l = str.Length;
        //    int l2;
        //    for (int i = 0; i < l; i++)
        //    {
        //        char[] arr = str[i].ToCharArray();
        //        l2 = arr.Length;
        //        for (int j=0; j<l2/2; j++)
        //        {
        //            char t = arr[j];
        //            arr[j] = arr[l2 - j - 1];
        //            arr[l2 - j - 1] = t;
        //        }
        //        s += new string(arr);
        //        if (i != l - 1)
        //        {
        //            s += " ";
        //        }
        //    }
        //    return s;
        //}

        ////StringBuilder代替CharArray
        //public string ReverseWords(string s)
        //{
        //    string[] str = s.Split(' ');
        //    s = "";
        //    int l = str.Length;
        //    for (int i = 0; i < l; i++)
        //    {
        //        StringBuilder sb = new StringBuilder(str[i]);
        //        for (int m = 0, n = str[i].Length-1; m <= n; m++, n--)
        //        {
        //            sb[m] = str[i][n];
        //            sb[n] = str[i][m];
        //        }
        //        s += sb;
        //        if (i != l - 1)
        //        {
        //            s += " ";
        //        }
        //    }
        //    return s;
        //}

        //public string ReverseWords(string s)
        //{
        //    string[] str = s.Split(' ');
        //    s = "";
        //    int l = str.Length;
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < l; i++)
        //    {
        //        char[] c = str[i].ToCharArray();
        //        sb.Append(string.Join("", c.Reverse()));
        //        sb.Append(" ");
        //    }
        //    return sb.ToString().Trim();
        //}

        //栈结构,开销最大
        //public string ReverseWords(string s)
        //{
        //    string[] str = s.Split(' ');
        //    s = "";
        //    int l = str.Length;
        //    for (int i = 0; i < l; i++)
        //    {

        //        Stack<char> stack = new Stack<char>();
        //        foreach (char ch in str[i])
        //        {
        //            stack.Push(ch);
        //        }
        //        char[] c = new char[str[i].Length];
        //        for (int j = 0; j < str[i].Length; j++)
        //        {
        //            c[j] = stack.Pop();
        //        }

        //        s += new string(c);
        //        if (i != l - 1)
        //        {
        //            s += " ";
        //        }
        //    }
        //    return s;
        //}

    }
}
