﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVP_TodoList.Model
{
    
    public class TodoItem
    {
        [Key]
        public int TaskID { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreateDate { get; private set; }


        public TodoItem()
        {
            CreateDate = DateTime.Now;
        }
    }
}
