using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');
        Dictionary<string, int> ransomWordsDictionary = new Dictionary<string, int>) { };
        int result = 0;
        for (int i = 0; i < n; i++)
            {
                if (!ransomWordsDictionary.ContainsKey(ransom[i]))
                ransomWordsDictionary.Add(ransom[i], 1);
                else
                ransomWordsDictionary[ransom[i]]++;
            }
         for (int i = 0; i < m; i++)
            {
                if (ransomWordsDictionary.ContainsKey(magazine[i]))
                ransomWordsDictionary[magazine[i]]--;            
            }
        
        foreach (var pair in ransomWordsDictionary)
            {
                if (pair.Value<=0)
                    result++;
            }
            
        Console.WriteLine(result == n ?"Yes": "No");
    }
}