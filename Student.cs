using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    [MessagePack.MessagePackObject]
    public class Student
    {
       
        [MessagePack.Key(0)]
        public int Id { get; set; }
        [MessagePack.Key(1)]
        public string FirstName { get; set; }
        [MessagePack.Key(2)]
        public string LastName { get; set; }
        [MessagePack.Key(3)]
        public int Hours { get; set; }

    }
}
