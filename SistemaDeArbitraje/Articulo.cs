//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaDeArbitraje
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class Articulo
    {
        public int IdArticulo { get; set; }
        public string Titulo { get; set; }
        public string Estado { get; set; }
        public string FechaCreacion { get; set; }
        public string Autor { get; set; }
        public string FechaLiberacion { get; set; }
        public Nullable<int> estructura { get; set; }
        public Nullable<int> introduccion { get; set; }
        public Nullable<int> metodo { get; set; }
        public Nullable<int> resultados { get; set; }
        public Nullable<int> citaciones { get; set; }
        public Nullable<bool> dictamen { get; set; }
        public Nullable<float> calificacion { get; set; }
    }
}
