using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace RSAproject
{
    public class BigInteger
    {
        public string x; // 0(1)
        int N = 0; // 0(1)
        KeyValuePair<StringBuilder,StringBuilder> res; // 0(1)
        StringBuilder result; // 0(1)
       const string one = "1"; // 0(1)
        StringBuilder One; // 0(1)
       const string zero = "0"; // 0(1)
        StringBuilder Zero; // 0(1)
        StringBuilder pow;

        //Description : used to Sum two strings 
        // Input : numbers in strings
        // Output : the result from summation operation in "string"
        // Complixity : O(N), N : length of the shortest string string
        public StringBuilder SUM (StringBuilder str1, StringBuilder str2)
        {
            Zero = new StringBuilder(zero);

            int sum = 0; // 0(1) 
            int carry = 0; // 0(1)

            // empty string for storing result
             result = new StringBuilder() ; // 0(1)

            // make sure str1 
            // is not the smaller in length
            if (str1.Length < str2.Length) // 0(N) + 0(N) + 0(1)
                                    // = 0 (N), N: length of the longest string
            {
                StringBuilder temp = str1; // 0(1)
                str1 = str2; // 0(1)
                str2 = temp; // 0(1)
            }

            // Calculate length of both string 
            int n1 = str1.Length; // 0(1)
            int n2 = str2.Length; // 0(1)

            // Get their difference
            int diff = n1 - n2; // 0(1)

            // Reverse both of strings 
            StringBuilder sr1 = new StringBuilder(); // 0(1)
            for (int i = n1 - 1; i >= 0; i--) // 0(N), N: length of the string
            {
                sr1.Append(str1[i]); // 0(1)
            }
            str1 = sr1; // 0(1)

            StringBuilder sr2 = new StringBuilder(); // 0(1)
            for (int i = n2 - 1; i >= 0; i--) // 0(N), N: length of the string
            {
                sr2.Append(str2[i]); // 0(1)
            }
            str2 = sr2; // 0(1)

            // Summation loop
            // Reversily loops over the shortest string "str2"
            for (int i = 0; i < n2; i++) // 0(N) + 0(1) + 0(1)
                                   // 0(N), N: n2, length of the shortest string
            {
                sum = ((int)(str1[i] - '0') + (int)(str2[i] - '0') + carry); // 0(1)

                result.Append((char)(sum % 10 + '0')); // 0(1)

                // get the carried digit
                carry = sum / 10; // 0(1)
            }

            // Add the remaining digits of the longest string
            for (int j = n2; j < n1; j++) // 0(N) + 0(1) + 0(1)
                                    // = 0(N), N: n2- n1 
                                // i.e the remaining digits of the longest string
            {
                sum = ((int)(str1[j] - '0') + carry); // 0(1)
                result.Append((char)(sum % 10 + '0')); // 0(1)
                carry = sum / 10; // 0(1)
            }

            // Add the last carry to the final result
            if (carry > 0) // 0(1)
            {
                result.Append((char)(carry + '0')); // 0(1)
            }

            // As the two input strings was reversed
            // So, we reverse the final result too
            StringBuilder sr3 = new StringBuilder(); // 0(1)
            for (int i = result.Length-1 ; i >= 0; i--) // 0(N), N: length of result string
            {
                sr3.Append(result[i]); // 0(1)
            }
             result =sr3; // 0(1)
            
            if (result.Equals(Zero)) // 0(1)
            {
                return result; // 0(1)
            }

            // .TrimStart used to remove the excess zeroes 
            //at the beginning of the string
            string r = result.ToString().TrimStart(new char[] { '0' }); // 0(N)
                result = new StringBuilder(r); // 0(1)
          
                 return result; // 0(1)
        }

        // Description : Function to check which of the two input strings  
        // is the smallest 
        // Inputs : two numbers stored in strings 
        // output : Boolean value if first number is smaller than the second or not
        // Complixity : O(N), N: length of length of a string
        static bool isSmaller (StringBuilder str1, StringBuilder str2)
        {
            // Calculate lengths of both string 
            int n1 = str1.Length; // 0(1)
            int n2 = str2.Length; // 0(1)

            // checks if str1 is the smaller in the length or not 
            if (n1 < n2) // 0(1)
                return true; // 0(1)
            else if (n2 < n1) // 0(1)
                return false; // 0(1)

            // if they are equal in the length
            else
            {
                for (int i = 0; i < n1; i++) // O(N) + 0(1) + 0(1)
                                             // = O(N) N:the length of any string 
                                             // as it's the same for both
                {
                    if (str1[i] < str2[i]) // 0(1)
                        return true;
                    else if (str1[i] > str2[i]) // 0(1)
                        return false;
                }
            }

            return false;
        }

        // Description : Subtraction function of two big integers numbers
        // Input : two numbers in strings
        // Output : the result from the subtraction operation
        // Complixity : 0(N) : length of the shortest string
        public StringBuilder SUB (StringBuilder str1, StringBuilder str2)
        {
            int sub = 0; // 0(1)
            int carry = 0; // 0(1)

            // make sure that str1 
            // is not the smaller 
            if (isSmaller(str1,str2)) // O(N) N: if the two strings are of the same 
                                       //  length therefore N is this length
            {
                StringBuilder temp = str1; // 0(1)
                str1 = str2; // 0(1)
                str2 = temp; // 0(1)
            }

            // Empty string for storing result 
             result = new StringBuilder(); // 0(1)

            // Calculate length of both strings 
            int n1 = str1.Length; // 0(1)
            int n2 = str2.Length; // 0(1)

            // Get their difference
            int diff = n1 - n2; // 0(1)

            // Reverse both of strings
            StringBuilder sr1 = new StringBuilder(); // 0(1)
            for (int i = n1-1 ; i >= 0; i--) // 0(N)
            {
                sr1.Append(str1[i]); // 0(1)
            }
            str1 = sr1; // 0(1)

            StringBuilder sr2 = new StringBuilder(); // 0(1)
            for (int i = n2-1 ; i >= 0; i--) // 0(N)
            {
                sr2.Append(str2[i]); // 0(1)
            }
            str2 = sr2; // 0(1)

            // the subtraction loop 
            //loops over the shortest string "str2"
            // and subtract digits of str1 to str2 
            for (int i = 0; i < n2; i++) // 0(N)+ 0(1) + 0(1)
                                         // = 0(N) N: n2. length of shortest string
            {
                sub = ((int)(str1[i] - '0') -
                       (int)(str2[i] - '0') - carry); // 0(1)

                // If subtraction is less then zero 
                // we add, then we add 10 into sub and 
                // take carry as 1 for calculating the next step 
                if (sub < 0) // 0(1)
                {
                    sub = sub + 10; // 0(1)
                    carry = 1; // 0(1)
                }
                else
                    carry = 0; // 0(1)

                result.Append((char)(sub + '0')); // 0(1)
            }

            // subtract the  remaining digits of the longest number 
            for (int i = n2; i < n1; i++) // 0(N)
            {
                sub = ((int)(str1[i] - '0') - carry); // 0(1)

                // if the sub value is -ve, then make it positive 
                if (sub < 0) // 0(1)
                {
                    sub = sub + 10; // 0(1)
                    carry = 1; // 0(1)
                }
                else
                    carry = 0; // 0(1)

                result.Append((char)(sub + '0')); // 0(1)
            }

            // As the two input strings was reversed
            // So, we reverse the final result too
            StringBuilder sr3 = new StringBuilder(); // 0(1)
            for (int i = result.Length-1 ; i >= 0; i--) // 0(N)
            {
                sr3.Append(result[i]); // 0(N)
            }
            result = sr3; // 0(1)

            // .TrimStart used to remove the excess zeroes 
            //at the beginning of the string    
             string r =result.ToString().TrimStart(new char[] { '0' }); // 0(N) + 0(1)
                                            // = 0(N) N: number of zeroes at the beginning of the string

            result = new StringBuilder(r); // 0(1)

            // In case of the two numbers are the same and the result
            // is zero, therefore the result will be an empty string 
            // so giveit value of zero .
            string space = ""; // 0(1)
            StringBuilder Space = new StringBuilder(space); // 0(1)
            if (result.Equals(Space)) // 0(N)
                result.Append("0"); // 0(1)

            return result; // 0(1)
        }

        // Description : Multiplication Function of two big integer numbers
        // using KARATSUBA Algorithm
        // Input : two numbers in strings
        // Output : the result from the multiplication operation
        // Complixity : 0(N)^1.58, N: length of the longest string
        public StringBuilder MUL (StringBuilder str1, StringBuilder str2)
        {
            Zero = new StringBuilder(); // 0(1)

            // .Length calculates the length of the given string
            int len1 = str1.Length; // 0(N) + 0(1) 
                                    // = 0(N) N: the length of str1
            int len2 = str2.Length; // 0(N) + 0(1) N: the length of str2
                                    // = 0(N) N: the length of str2

            //if a string is empty
            if (len1 == 0 || len2 == 0) // 0(1)
            {
                return result= new StringBuilder("0"); // 0(1)
            }

            // Find the maximum of lengths of str1 and str2  
            // and make the length of the smaller string 
            //is the same as that of the larger one
            // then put the longest in N
            if (len1 < len2) // 0(1)
            {
                
                for (int i = 0; i < len2 - len1; i++) // 0(N) + 0(1) + 0(1)
                                                      // = 0(N) N: len2-len1
                {
                    // .Append(), used to add string or char at the end of string
                    Zero.Append("0"); // 0(1)
                }

                str1= Zero.Append(str1); // 0(1)
                N = len2; // 0(1)
            }

            else if (len1 > len2) // 0(1)
            {
                for (int i = 0; i < len1 - len2; i++) // 0(N) + 0(1) + 0(1)
                                               // = 0(N) N: len2-len1
                {
                    Zero.Append("0"); // 0(1)
                }
                str2.Append(Zero); // 0(1)
                N = len1; // 0(1)
            }

            // If len1 = len2
            else
            {
                N = len1; // 0(1)
            }

            // Base case
            if (N == 0) // 0(1)
            {
                result.Equals("0"); // 0(N)
                return result; // 0(1)
            }
            if (N == 1) // 0(1)

            {
                // .Parse changes every character in the string 
                // into integer value 
                int test = int.Parse(str1.ToString()) * int.Parse(str2.ToString()); // 0(N) + 0(1) 
                                                   // = 0(N) N: length of the longest string
                                                  // .toString changes the each character 
                                                 // in the string into it's integer value
                                                //string result = test.ToString(); // 0(N) + 0(1) 
                string Test = test.ToString(); // 0(N)                                                     // = 0(N) N: length of test
                Test.TrimStart(new char[] { '0' }); // 0(N)
                result = new StringBuilder(Test);  // 0(N)

                return result; // 0(N)
            }

            // First half of string
            int fhalf = (int)Math.Ceiling((double)(N / 2)); // 0(1)
            // Second half of string 
            int shalf = (N - fhalf); // 0(1)

            // Substring used to find the first half
            //and second half of the first string
           // string a = str1.ToString(0, fhalf); // 0(N) + 0(1)
            StringBuilder A = new StringBuilder(str1.ToString(0, fhalf)); // 0(N) + 0(1)
                                                 // = 0(N) N: half the length of str1
            StringBuilder B = new StringBuilder (str1.ToString(fhalf, shalf)); // 0(N) + 0(1)
                                                     // = 0(N) N: second half of the length of str1

            // Substring used to Find the first half 
            //and second half of the second string 
            StringBuilder C = new StringBuilder(str2.ToString(0, fhalf)); // 0(N) + 0(1)
                                              // = 0(N) N: half the length of str1
            StringBuilder D = new StringBuilder(str2.ToString(fhalf, shalf)); //  0(N) + 0(1)
                                                     // = 0(N) N: second half the length of str1

            // Recursively calculate the three products of inputs of size N/2 
            StringBuilder M1 = MUL(A, C); // T(N/2) + 0(N) + 0(1) = O(N)^1.58   (1)
            StringBuilder M2 = MUL(B, D); // T(N/2) + 0(N) + 0(1) =  O(N)^1.58   (2)
           // StringBuilder AB = SUM(A, B); //  0(N), N: length of the shortest string
            //StringBuilder CD = SUM(C, D); // 0(N), N: length of the shortest string
            StringBuilder Z = MUL(SUM(A, B),SUM(C, D)); // T(N/2) + 0(N) + 0(1) = O(N)^1.58   (3)

            Z = SUB(Z, SUM(M1, M2)); // 0(N), N: length of the shortest string

            // Formulate AC*10^N 
            for (int k = 0; k < shalf * 2; k++) // 0(N) + 0(1) + 0(1)
                                                // = 0(N), N: length of the string
            {
                M1.Append("0"); // 0(1)
            }

            // Formulate Z*10^(N/2) 
            for (int k = 0; k < shalf; k++) // 0(N) + 0(1) + 0(1)
                                            // = 0(N), N: half length of the string
            {
                Z.Append("0"); // 0(1)
            }

            StringBuilder res = SUM(M1, M2); // 0(N), N: length of the shortest string
            StringBuilder final = SUM(res, Z); // 0(N), N: length of the shortest string

            // .TrimStart used to remove the excess zeroes 
            // at the beginning of the string
            // O(N), N: length of zeroes 
            // at the beginning of the string
             string f = final.ToString().TrimStart(new char[] { '0' });  // 0(N)+ 0(N)=0(N)
                                                                   
            final = new StringBuilder(f); // 0(N)
            return final; // 0(1)
        }
           
        // Description : it divides two large strings. 
        // inputs : dividant and divisors.
        // output : result of division process.
        // complixity : 0(NlogN).
        public KeyValuePair<StringBuilder,StringBuilder> DIV_AUX(StringBuilder a, StringBuilder b)
        {
             Zero = new StringBuilder(zero); // 0(1)
              One = new StringBuilder(one);  // 0(1)
            StringBuilder exception = new StringBuilder("Division Over Zero Exception"); // 0(N)
            if (b.Equals(Zero)) // 0(N)
            {
                res = new KeyValuePair<StringBuilder,StringBuilder>(exception,Zero); // 0(N)
                return res; // 0(1)
            }

            if (a.Equals(Zero)) // 0(N)
            {
                res = new KeyValuePair<StringBuilder,StringBuilder>(Zero,Zero); // 0(N)
                return res; // 0(1)
            }

            if (isSmaller(a, b)) // 0(N)
            {
                res = new KeyValuePair<StringBuilder,StringBuilder>(Zero,a); // 0(N)
                return res; // 0(1)
            }

            //StringBuilder bb = SUM(b,b);  // 0(N)
            res = DIV_AUX(a,SUM(b, b)); // 0(NlogN)
            StringBuilder q = SUM(res.Key,res.Key); // 0(N)
            
            if (isSmaller(res.Value,b)) // 0(N)
            {
               res = new KeyValuePair<StringBuilder,StringBuilder> (q,res.Value); // 0(N)
               return res; // 0(1)
            }
            else
            { 
              res = new KeyValuePair<StringBuilder,StringBuilder>(SUM(q,One),SUB(res.Value,b)); // 0(N) + 0(N) = 0(N)

                return res; // 0(1)
            }
        }


        // Description : the Function that calculate the remainder of the devision
        // then it pass it to powOfMod function.
        // inputs : dividant , power and divisor.
        // output : the result after achieving mod of power. 
        // complixity:  0(N^1.58*NlogN) + 0(NlogN) =  0(N^1.58*NlogN).
        public StringBuilder MOD_AUX (StringBuilder m, StringBuilder p, StringBuilder n)
        {       
            var reminder = DIV_AUX(m,n); // 0(NlogN)
            StringBuilder Res = PowOfMod(reminder.Value,p,n); // T(N/2) + 0(N^1.58) + 0(1)
                                                             // = 0(N^1.58*NlogN).
           //res = DIV_AUX(Res,n);
            return res.Value; // 0(1)
        }

        // Description : it applies the fast power rule,
        // where the ((a mod b)^p) mod b. 
        // Input : the remainder , the power and the mod by number .
        // Output : result of power of mod operation.
        // Complexity : T(N/2) + 0(N^1.58) + 0(1) = 0(N^1.58*NlogN).
        public StringBuilder PowOfMod (StringBuilder r , StringBuilder p , StringBuilder n)
        {
            //bool odd; // 0(1)
             One = new StringBuilder (one); // 0(1)
            Zero = new StringBuilder(zero); // 0(1)
            if (p.Equals(Zero)) // 0(N)
            {
                return One; // 0(1)
            }

            else if (p.Equals(One)) // 0(N)
            {
                return r; // 0(1)
            }

            string two = "2"; // 0(1)
            StringBuilder Two = new StringBuilder (two); // 0(1)
            var d = DIV_AUX(p,Two);  // 0(NLOGN)
            StringBuilder remainder = d.Value; // 0(1)

            // recurse over N/2 utill the d.key = 0
             pow = PowOfMod(r,d.Key,n); // T(N/2) + 0(N^1.58) + 0(1) = 0(N^1.58*NlogN).
            if (remainder.Equals(Zero)) // 0(N)
            {
                return DIV_AUX(MUL(pow, pow), n).Value; // 0(N)^1.58

            }

            else
            {
                // p = SUB(p,One); // 0(N)
                //var dd = DIV_AUX(p,Two); // T(N)
                //M = dd.Key; // 0(1) 
                return DIV_AUX(MUL(MUL(pow, pow), r), n).Value; // 0(N)^1.58

            }

        }

        public StringBuilder ENCRYPTION(StringBuilder mess, StringBuilder e, StringBuilder n)
        {
            return MOD_AUX(mess, e, n);
        }

        public StringBuilder DECRYPTION(StringBuilder emess , StringBuilder d,StringBuilder n)
        {
            return MOD_AUX(emess, d, n);
        }

    }
}
