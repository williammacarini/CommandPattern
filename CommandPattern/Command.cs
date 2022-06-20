using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Command : ICommand
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Command(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Execute()
        {
            Console.WriteLine($"Comando Executado {this.Id} - {this.Name}!");
        }
    }
}
