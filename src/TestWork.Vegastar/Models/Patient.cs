using System.Collections.Generic;
using System;
using System.Text.Json;
using static TestWork.Vegastar.Models.Patient;
using System.Text.Json.Serialization;

namespace TestWork.Vegastar.Models
{
    public class Patient
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string BirthDate { get; set; }
        public int Gender { get; set; }

        public Insurance Snils { get; set; }
        public Insurance Polis { get; set; }
        public Adress Adress { get; set; }
    }
    public class Insurance
    {
        public int DocumentType { get; set; }
        public string DocumentNumber { get; set; }
    }

    public class Adress
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Flat { get; set; }
        public int Floor { get; set; }
    }
}
