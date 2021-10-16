using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Representa a una persona especifica
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id from Sql
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// Nombre de la persona
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// Ya te imaginas
        /// </summary>
        public string LastName { get; set; } = "";
    }
}