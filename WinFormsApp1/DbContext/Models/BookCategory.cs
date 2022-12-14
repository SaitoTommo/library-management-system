using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class BookCategory
    {
        [Key]
        public int Id { get; set; }
        
        public string CategoryID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{CategoryID} | {Name}";
        }

        public virtual ObservableCollectionListSource<Book> Books { get; } = new();
    }
}
