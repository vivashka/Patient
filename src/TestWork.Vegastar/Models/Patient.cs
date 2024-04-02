using System.Collections.Generic;
using System;

namespace TestWork.Vegastar.Models
{
    public class Patient
    {
        public int Name { get; set; }
        public int SurName { get; set; }
        public int Patronymic { get; set; }
        public int Age { get; set; }
        public int Snils { get; set; }

        public List<Patient> Desserelize<Patient>(string json)
        {

            
        }
    }
}
