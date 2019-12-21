using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatToDo.Models.Enums;

namespace WhatToDo.Models
{
    public class ToDo
    {   
        [Key]
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime Date { get; set; } = DateTime.Now;
        public string Duration { get; set; }
        public Status Status { get; set; }
        public Kind KindOfToDo { get; set; }
        public ICollection<ToDo> List { get; set; } = new List<ToDo>();

        public ToDo()
        {
        }

        public ToDo(string name, DateTime date, string duration, Status status, Kind kindOfToDo)
        {
           
            Name = name;
            Date = date;
            Duration = duration;
            Status = status;
            KindOfToDo = kindOfToDo;
        }



        public void AddToDo(ToDo item)
        {
            List.Add(item);
        }

        public void RemoveToDo(ToDo item)
        {
            List.Add(item);
        }


        ICollection<ToDo> DoneList = new List<ToDo>();
        double totalDone = 0.00;
        public string PercentageDone(ToDo item)
        {
            if (item.Status == Status.Done)
            {
                DoneList.Add(item);
            }

            totalDone = ((DoneList.Count()) / List.Count()) * 100;


            return ("You've completed " + totalDone.ToString() + "% of your To Do List so far");

        }
               
        
    }




}


