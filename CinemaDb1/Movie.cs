using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaDb1
{
    public partial class Movie
    {
        public Movie()
        {
            Casts = new HashSet<Cast>();
            // posso fare questo perchè HashSet implementa ICollection
            // l'inizializzazione nel costruttore serve perchè si abbia una struttura dati vuota e non nulla
            Programmaziones = new HashSet<Programmazione>();
        }

        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Genere { get; set; }
        public int? Durata { get; set; }
        // int? dice che la proprietà può non essere messa (=sono accettati i null)

        public virtual ICollection<Cast> Casts { get; set; }
        public virtual ICollection<Programmazione> Programmaziones { get; set; }
        // queste due proprità tengono conto delle relazioni 
    }
}
