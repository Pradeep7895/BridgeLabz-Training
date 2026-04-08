using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class OtpGenerator
    {
        //generate a 6-digit random OTP
        static int GenerateOTP()
        {
        
            Random random = new Random();

            
            return random.Next(100000, 1000000);
        }

        // Method to check otp's are unique
        static bool Unique(int[] otps)
        {
            for (int i = 0; i < otps.Length; i++)
                for (int j = i + 1; j < otps.Length; j++)
                    if (otps[i] == otps[j])
                        return false;

            return true;
        }

        static void Main()
        {
            // Array 
            int[] otps = new int[10];

            //display 10 OTPs
            for (int i = 0; i < 10; i++)
            {
                otps[i] = GenerateOTP();
                Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
            }

            //display whether all OTPs are unique
            Console.WriteLine(Unique(otps)
                ? "All OTPs are unique"
                : "Duplicate OTPs found");
        }

    }
}

        