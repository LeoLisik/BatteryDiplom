using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tuningAtelier.Class
{
    internal class RcaCryptDecrypt
    {
        private static string key = "<RSAKeyValue><Modulus>6OrtLEfdbH8DYpS1zVd0QE6Nz0H8ULD5hx/y2f83IOhJHVL6oqvCl5ZQ82PBBwDbvjKxuvEJBrhx5pFNXVrPLCGkLlfITzYNOM1i/piMrFky314TCsQRXnQosQUU720Ol54V8NMvOJNPeo9GH5Z+HQTWtF8N1I+EgbGHFbX1ZsU=</Modulus><Exponent>AQAB</Exponent><P>+HpEbRC6j657wUPuxqheASFTj0ESyDW6xWlEf2CO3z24At6s05pNmBTJEnp4Ki2wBqsD1IEoyKdRSPqu1ojRGw==</P><Q>7/gRWrdzvvFMFT9qScejx07FX58X210wYMvqShfUu5ah6aLjUDNwbcGer0RtgaqY6jTEBaMGpOyLTQ71tRIFnw==</Q><DP>wa8k2VM56TfcFYkrfcTOCdl9deQGjPN809a7YwLUO2WzouEKHKNhqpNBLNs0AcS9OmVhxeqr7MSnkth9IpNhUw==</DP><DQ>YphrEPnVLbvYxdYjZqMHMMm1oL8uPyw/x1WhMsYt2tFePy909CveYsot19dmouMkJv59F8/O2A50gbnGzJnWAw==</DQ><InverseQ>63pC8T/kjvoTT+ifoCDqcbSQwOtuJvhr2+5BSGAI7+HOa++Dn3BlRG5cFG9G+Ysuu5LBuGaCy1eAO3IwyRvUbg==</InverseQ><D>xm/YTuCPQi9YF/XwihiXH26NnOVv7ONKRBgxFA8+zZd5KzWV+V9ycymKoEH9o1TU4k9YYpeWhBZCXBixG/cRBr0hvYq5wU7KS/LYibPUEHEysFLuukqU0PG5o9vbvLgIDKWtb04cM4gyfZWDPxGt5Gh59/opARpQZqpsDizyaUU=</D></RSAKeyValue>";
        internal static string Crypt(string str)
        {
            byte[] cryptContent;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            cryptContent = rsa.Encrypt(Encoding.UTF8.GetBytes(str), true);
            return Convert.ToBase64String(cryptContent);
        }

        internal static string DeCrypt(string str)
        {
            byte[] decrContent;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            decrContent = rsa.Decrypt(Convert.FromBase64String(str), true);
            return Encoding.UTF8.GetString(decrContent);
        }
    }
}
