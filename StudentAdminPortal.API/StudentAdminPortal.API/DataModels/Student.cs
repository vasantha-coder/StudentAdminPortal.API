﻿using System;

namespace StudentAdminPortal.API.DataModels
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set;}
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageUrl { get; set; }
        public Guid GenderId { get; set; }

        //Navigation properties
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }
}
