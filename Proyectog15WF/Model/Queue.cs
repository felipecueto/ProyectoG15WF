using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Queue
    {
        List<string> queue; // Quizas hacer la lista de objetos Song

        public Queue()
        {
            this.queue = new List<string>();
        }


        public bool CheckSongsInQueue()
        {
            if (0 < queue.Count())
            {
                return true; // Hay canciones en Queue
            }
            return false;
        }

        public bool AddToQueue(string songName)
        {
            queue.Add(songName);
            return true; // Se agrega cancion a la queue
        }

        public bool RemoveFromQueue(string songName)
        {
            if (0 < queue.Count())
            {
                foreach (string value in queue)
                {
                    if (value == songName)
                    {
                        queue.Remove(songName);
                        return true; // Cancion agregada
                    }
                }
            }
            return false; // No se elimino la cancion o no hay canciones en queue
        }
    }
}
