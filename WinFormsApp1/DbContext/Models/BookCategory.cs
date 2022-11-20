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
        public string ID { get; set; }
        public string Name { get; set; }

        public virtual ObservableCollectionListSource<Book> Books { get; } = new();
    }
}
