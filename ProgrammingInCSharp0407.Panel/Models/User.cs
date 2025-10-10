using ProgrammingInCSharp0407.Panel.Abstarctions;
using System.Runtime.CompilerServices;

namespace ProgrammingInCSharp0407.Panel.Models;

/// <summary>
/// noun for naming class
/// AccessModiferi class NameClass 
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
    //public DateTime BirthDate { get; set; } //ShortHand

    //readonly propety
    public int Age { get {
            if (_birthDate == DateTime.MinValue)
            {
                throw new Exception();
            }
            return DateTime.Now.Year - _birthDate.Year ;    
        } 
    }

    //Full Property
    private DateTime _birthDate;//Feild

    public DateTime BirthDate
    {
        get { return _birthDate; }
        set { _birthDate = value; }
    }

}
