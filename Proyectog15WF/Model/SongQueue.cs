using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SongQueue
    {
        List<Song> queue;

        public SongQueue()
        {
            this.queue = new List<Song>();
        }


        public bool CheckSongsInQueue()
        {
            if (0 < queue.Count())
            {
                return true; // Hay canciones en Queue
            }
            return false;
        }

        public bool AddToQueue(Song song)
        {
            queue.Add(song);
            return true; // Se agrega cancion a la queue
        }

        public bool RemoveFromQueue(string songName)
        {
            if (0 < queue.Count())
            {
                foreach (Song value in queue)
                {
                    if (value.Namesong == songName)
                    {
                        queue.Remove(value);
                        return true; // Cancion agregada
                    }
                }
            }
            return false; // No se elimino la cancion o no hay canciones en queue
        }
        public bool ClearQueue()
        {
            queue.Clear();
            return true; // Queue Cleared
        }
    }
}
