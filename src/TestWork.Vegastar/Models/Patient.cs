using System;
using System.Text.Json;

namespace TestWork.Vegastar.Models
{
    public class Patient
    {

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime BirthDate { get; set; }

        public GenderType Gender { get; set; }

        public Insurance Snils { get; set; } = new Insurance();

        public Insurance Polis { get; set; } = new Insurance();

        public Address Address { get; set; } = new Address();
    }
    public enum GenderType
    {
        Мужской = 1,
        Женский = 2
    }

    public enum DocumentType
    {
        СНИЛС = 1,
        Полис = 2
    }

    public class Insurance
    {
        public DocumentType DocumentType { get; set; }
        public string DocumentNumber { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public int? House { get; set; }
        public int? Flat { get; set; }
        public int? Floor { get; set; }
    }
}
