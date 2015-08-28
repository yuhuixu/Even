﻿using System;

namespace Even
{
    public interface IStreamPredicate
    {
        bool EventMatches(IStreamEvent persistedEvent);
        object GetDeterministicHashSource();
    }

    public class StreamQuery : IStreamPredicate
    {
        public string StreamID { get; set; }

        public bool EventMatches(IStreamEvent persistedEvent)
        {
            return String.Equals(persistedEvent.StreamID, StreamID, StringComparison.OrdinalIgnoreCase);
        }

        public object GetDeterministicHashSource()
        {
            return StreamID;
        }
    }

    //public class TypedEventQuery : IStreamPredicate
    //{

    //}

    //public class EventNameQuery : IStreamPredicate
    //{
    //    public string Category { get; set; }
    //    public string EventName { get; set; }

    //    public object GetDeterministicHashSource()
    //    {
    //        return new string[] { Category, EventName };
    //    }
    //}
}
