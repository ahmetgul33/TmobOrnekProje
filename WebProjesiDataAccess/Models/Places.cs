using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebProjesiDataAccess.Abstract;

namespace WebProjesiDataAccess.Models
{
    public class Place : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Categories { get; set; }

        public string Name { get; set; }

        public string PluralName { get; set; }

        public string ShortName { get; set; }
    }
}
