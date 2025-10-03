using ProgrammingInCSharp0407.Panel.Abstarctions;

namespace ProgrammingInCSharp0407.Panel.Models;

/// <summary>
/// noun for naming class
/// </summary>
internal class User : BaseEntity //Entity
{
    

    public User(string nationalCode,string phoneNumber)
    {
        if (string.IsNullOrEmpty(nationalCode) || string.IsNullOrEmpty(phoneNumber))
        {
            throw new Exception();
        }

        NationalCode = nationalCode;
        PhoneNumber = phoneNumber;
    }

    public User(string nationalCode, string phoneNumber, string firstName, string lastName) : this(nationalCode, phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    //access_modifier datatype name { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string NationalCode { get; set; }
}
