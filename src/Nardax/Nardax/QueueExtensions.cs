using System.Collections.Generic;

namespace Nardax
{
    public static class QueueExtensions
    {

        /// <summary>
        /// Lägg in item i en kö
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queue"></param>
        /// <param name="items"></param>
        public static void EnqueueRange<T>(this Queue<T> queue, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                queue.Enqueue(item);
            }
        }
    }
}