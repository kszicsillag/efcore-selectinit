using EFCoreSelectInit.DTOs;
using System;
using System.Linq;

namespace EFCoreSelectInit
{
    class Program
    {
        static void Main(string[] args)
        {            
            using (MyDbContext ctx = new MyDbContext())
            {
                ctx.Database.EnsureCreated();
                var dogDTOList = ctx.Dogs.Select(d => new DogDTO { ID = d.Id, Name = d.Name, IDCard = new IDCard() }).ToList();
                Console.WriteLine("Expecting different hash codes below");
                foreach (DogDTO dto in dogDTOList)
                {
                    Console.WriteLine(dto.IDCard.GetHashCode());
                }
            }
            Console.ReadLine();
        }     
    }
}
