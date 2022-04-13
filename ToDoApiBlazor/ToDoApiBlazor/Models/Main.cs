using System;
using System.Collections.Generic;

namespace ToDoApiBlazor.Models
{
    public partial class Main
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
    }
}
