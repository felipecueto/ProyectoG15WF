using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable()]
    public class VideoQueue
    {
        List<Video> queue;

        public VideoQueue()
        {
            this.queue = new List<Video>();
        }


        public bool CheckSongsInQueue()
        {
            if (0 < queue.Count())
            {
                return true; // Hay canciones en Queue
            }
            return false;
        }

        public bool AddToQueue(Video video)
        {
            queue.Add(video);
            return true; // Se agrega cancion a la queue
        }

        public bool RemoveFromQueue(string videoName)
        {
            if (0 < queue.Count())
            {
                foreach (Video value in queue)
                {
                    if (value.VideoName == videoName)
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
