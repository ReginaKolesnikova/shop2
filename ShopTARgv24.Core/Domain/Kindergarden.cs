using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTARgv24.Core.Domain
{
    internal class Kindergarden
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public int ChildrenCount { get; set; }
        public string KindergardenName { get; set; }
        public string TeacherName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        // Teha uus CRUD e lisamine, vaatamine, uuendamine ja andmete kustutamine.
        //Teha uus branch.
        //Teemaks on Kindergarden.
        //Muutujateks on Id, GroupName, ChildrenCount, KindergardenName, TeacherName, CreatedAt ja UpdatedAt.
        //Töö on hindeline. Töö panna githubi ja link saata emailile.

    }
}

