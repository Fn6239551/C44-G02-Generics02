using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solv_Task_in_session__Assignment_02___Advanced_C_
{
    internal class Notification
    {
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public Notification(string message)
        {
            Message = message;
            CreatedAt = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{CreatedAt}: {Message}";
        }
    }
}
