using System;
using System.Text.Json;

namespace TestWork.Vegastar.Models
{
    public class Patient
    {

        public string Firstname { get; set; } = "Отсутствует";

        public string Surname { get; set; } = "Отсутствует";
        public string Patronymic { get; set; } = "Отсутствует";

        public string BirthDate { get; set; } = "Отсутствует";

        public int Gender { get; set; } = -1;

        public Insurance Snils { get; set; } = new Insurance();

        public Insurance Polis { get; set; } = new Insurance();

        public Adress Adress { get; set; } = new Adress();
    }
    public class Insurance
    {
        public int DocumentType { get; set; } = -1;
        public string DocumentNumber { get; set; } = "Отсутствует";
    }

    public class Adress
    {
        public string City { get; set; } = "Отсутствует";
        public string Region { get; set; } = "Отсутствует";
        public string Street { get; set; } = "Отсутствует";
        public int House { get; set; } = -1;
        public int Flat { get; set; } = -1;
        public int Floor { get; set; } = -1;
    }
}
