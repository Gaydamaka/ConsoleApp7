using System;
using System.Collections.Generic;

public class Student
{
    private string _firstName;
    private string _lastName;
    private string _middleName;
    private DateTime _dateOfBirth;
    private string _homeAddress;
    private string _phoneNumber;
    private List<int> _credits;
    private List<int> _coursework;
    private List<int> _exams;

    public Student(string firstName, string lastName, string middleName, DateTime dateOfBirth, string homeAddress, string phoneNumber)
    {
        _firstName = firstName;
        _lastName = lastName;
        _middleName = middleName;
        _dateOfBirth = dateOfBirth;
        _homeAddress = homeAddress;
        _phoneNumber = phoneNumber;
        _credits = new List<int>();
        _coursework = new List<int>();
        _exams = new List<int>();
    }

    public Student()
    {
        _credits = new List<int>();
        _coursework = new List<int>();
        _exams = new List<int>();
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string MiddleName
    {
        get { return _middleName; }
        set { _middleName = value; }
    }

    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set { _dateOfBirth = value; }
    }

    public string HomeAddress
    {
        get { return _homeAddress; }
        set { _homeAddress = value; }
    }

    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set { _phoneNumber = value; }
    }

    public List<int> Credits
    {
        get { return _credits; }
        set { _credits = value; }
    }

    public List<int> Coursework
    {
        get { return _coursework; }
        set { _coursework = value; }
    }

    public List<int> Exams
    {
        get { return _exams; }
        set { _exams = value; }
    }
  
    public void ShowDetails()
    {
        Console.WriteLine($"Имя: {_firstName}");
        Console.WriteLine($"Фамилия: {_lastName}");
        Console.WriteLine($"Отчество: {_middleName}");
        Console.WriteLine($"Дата рождения: {_dateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Домашний адрес: {_homeAddress}");
        Console.WriteLine($"Телефонный номер: {_phoneNumber}");
        Console.WriteLine($"Оценки (зачёты): {string.Join(", ", _credits)}");
        Console.WriteLine($"Оценки (курсовые работы): {string.Join(", ", _coursework)}");
        Console.WriteLine($"Оценки (экзамены): {string.Join(", ", _exams)}");
    }
  
    public override string ToString()
    {
        return $"{_lastName} {_firstName} {_middleName}, Дата рождения: {_dateOfBirth.ToShortDateString()}, Телефон: {_phoneNumber}";
    }
}
class Program
{
    static void Main(string[] args)
    {  
        Student student = new Student("Александр", "Гайдамака", "Евгениевич",
            new DateTime(2009, 07, 10), "г. Харьков, ул. Калатушкино, д. 1222", "4324532");
  
        student.Credits.Add(5);
        student.Credits.Add(4);
        student.Coursework.Add(3);
        student.Exams.Add(5);
        student.Exams.Add(4);
 
        student.ShowDetails();
        Console.WriteLine(student.ToString());
    }
}