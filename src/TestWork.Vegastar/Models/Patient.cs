using System.Collections.Generic;
<<<<<<< HEAD
using System.Text.Json;
=======
using System;
using System.Text.Json;
using static TestWork.Vegastar.Models.Patient;
>>>>>>> 6522f9ae6ecc6426a9bd0bb0a38473a2c280c55b
using System.Text.Json.Serialization;

namespace TestWork.Vegastar.Models
{
    public class Patient
    {
<<<<<<< HEAD
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
=======
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
>>>>>>> 6522f9ae6ecc6426a9bd0bb0a38473a2c280c55b
    }
}
