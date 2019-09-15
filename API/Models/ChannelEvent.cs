using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ChannelEvent
    {
        /// <summary>
        /// The name of the event
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the channel the event is associated with
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// The date/time that the event was created
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The data associated with the event
        /// </summary>
        public object Data
        {
            get { return _data; }
            set
            {
                _data = value;
                this.Json = JsonConvert.SerializeObject(_data);
            }
        }
        private object _data;

        /// <summary>
        /// A JSON representation of the event data. This is set automatically
        /// when the Data property is assigned.
        /// </summary>
        public string Json { get; private set; }

        public ChannelEvent()
        {
            Timestamp = DateTimeOffset.Now;
        }
    }

}