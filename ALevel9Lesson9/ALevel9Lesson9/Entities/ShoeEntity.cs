﻿using ALevel9Lesson9.Common;

namespace ALevel9Lesson9.Entities
{
    public class ShoeEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Size { get; set; }
        public StyleType Style { get; set; }
    }
}
