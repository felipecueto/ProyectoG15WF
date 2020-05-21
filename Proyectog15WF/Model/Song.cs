using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Song
    {
         string namesong;
         string genre;
         string composer;
         string discography;
         string studio;
         DateTime publicationyear;
         string lyrics;
         int duration;
         string category;
         int qualification;
         int reproduction;
         string sexo;
         string age;

        public Song(string namesong, string genre, string composer, string discography, string studio, DateTime publicationyear, string lyrics, int duration, string category, int qualification, int reproduction, string sexo, string age)
        {
            this.Namesong = namesong;
            this.Genre = genre;
            this.Composer = composer;
            this.Discography = discography;
            this.Studio = studio;
            this.Publicationyear = publicationyear;
            this.Lyrics = lyrics;
            this.Duration = duration;
            this.Category = category;
            this.Qualification = qualification;
            this.Reproduction = reproduction;
            this.Sexo = sexo;
            this.Age = age;
        }

        public string Namesong { get => namesong; set => namesong = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Composer { get => composer; set => composer = value; }
        public string Discography { get => discography; set => discography = value; }
        public string Studio { get => studio; set => studio = value; }
        public DateTime Publicationyear { get => publicationyear; set => publicationyear = value; }
        public string Lyrics { get => lyrics; set => lyrics = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Category { get => category; set => category = value; }
        public int Qualification { get => qualification; set => qualification = value; }
        public int Reproduction { get => reproduction; set => reproduction = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Age { get => age; set => age = value; }

        public override string ToString()
        {
            return "\n Nombre cancion: " +Namesong+ "\n Genero: " +Genre+ "\n Compositor: " +Composer+ "\n Discografia: " +Discography+ "\n Estudio: " +Studio+ "\n Año publicacion: " +Publicationyear+ "\n Lirica: " +Lyrics+ "\n Duracion: " +Duration+ "\n Categoria: {8}" + Category+ "\n Calificacion: "+Qualification+"\n Reproducciones: " +Reproduction+ "\n Sexo: " +Sexo+ "\n Edad: "+Age;
        }
    }
}
