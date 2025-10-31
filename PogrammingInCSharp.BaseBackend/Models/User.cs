
using PogrammingInCSharp.BaseBackend.Abstarctions;

namespace PogrammingInCSharp.BaseBackend.Models;

/// <summary>
/// noun for naming class
/// AccessModiferi class NameClass 
/// </summary>
public class User : BaseEntity //Entity
{
    public User() : base()
    {
    }

    public User(string nationalCode,string phoneNumber): this()
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

    public User(string nationalCode, string phoneNumber, string firstName, string lastName,DateTime birthDate) : this(nationalCode, phoneNumber,firstName,lastName)
    {
        _birthDate = birthDate;
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
