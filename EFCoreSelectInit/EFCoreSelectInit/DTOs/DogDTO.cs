using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSelectInit.DTOs
{
    public class DogDTO
    {
        public int ID { get; set; }

        public string  Name { get; set; }

        public IDCard IDCard { get; set; }
    }

    public class IDCard
    {
        public int ID { get; set; }

        public string Number { get; set; }
    }
}
