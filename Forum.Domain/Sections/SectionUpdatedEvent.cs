﻿using System;
using ENode.Eventing;

namespace Forum.Domain.Sections
{
    [Serializable]
    public class SectionUpdatedEvent : DomainEvent<string>
    {
        public string Name { get; private set; }

        public SectionUpdatedEvent(string sectionId, string name)
            : base(sectionId)
        {
            Name = name;
        }
    }
}