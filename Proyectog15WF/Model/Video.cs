using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable()]
    public class Video
    {
         string videoName;
         string genre;
         string category;
         string actor;
         string director;
         string studio;
         DateTime uploadDate;
         string description;
         int duration;
         int qualification;
         int reproduction;
         string sexo;
         string age;
         string resolution;

        public Video(string videoName, string genre, string category, string actor, string director, string studio, DateTime uploadDate, string description, int duration, int qualification, int reproduction, string sexo, string age, string resolution)
        {
            this.VideoName = videoName;
            this.Genre = genre;
            this.Category = category;
            this.Actor = actor;
            this.Director = director;
            this.Studio = studio;
            this.UploadDate = uploadDate;
            this.Description = description;
            this.Duration = duration;
            this.Qualification = qualification;
            this.Reproduction = reproduction;
            this.Sexo = sexo;
            this.Age = age;
            this.Resolution = resolution;
        }

        public string VideoName { get => videoName; set => videoName = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Category { get => category; set => category = value; }
        public string Actor { get => actor; set => actor = value; }
        public string Director { get => director; set => director = value; }
        public string Studio { get => studio; set => studio = value; }
        public DateTime UploadDate { get => uploadDate; set => uploadDate = value; }
        public string Description { get => description; set => description = value; }
        public int Duration { get => duration; set => duration = value; }
        public int Qualification { get => qualification; set => qualification = value; }
        public int Reproduction { get => reproduction; set => reproduction = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Age { get => age; set => age = value; }
        public string Resolution { get => resolution; set => resolution = value; }

        public override string ToString()
        {
            return "\n Nombre cancion: " + VideoName + "\n Genero: " + Genre + "\n Compositor: " + Category + "\n Actor: " + Actor + "\n Director: " + Director + "\n Estudio: " + Studio + "\n Fecha de subida: " + UploadDate + "\n Descripcion: " + Description + "\n Duracion: " + Duration + "\n Calificacion: " + Qualification + "\n Reproducciones: " + Reproduction + "\n Sexo: " + Sexo + "\n Edad: " + Age+ "\n Calidad: "+Resolution;
        }
    }
}
