using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp0407.Panel.Helpers;

internal static class PhoneNumberHelper
{
    public static bool IsValidPhoneNumber(string phoneNumber)
    {
        if (!string.IsNullOrEmpty(phoneNumber))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static string FormatToValidPhoneNumber(string phoneNumber)
    {
        return phoneNumber;
    }
}
