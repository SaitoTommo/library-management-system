using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //using (LibraryDbContext dbContext = )
            LibraryDbContext.Shared.Categories.Load();
            this.bookCategoryBindingSource.DataSource = LibraryDbContext.Shared.Categories.Local.ToBindingList();

            //LibraryDbContext.Shared.Categories.Load();

        }

        private void Gridview_Category_SelectionChanged(object sender, EventArgs e)
        {
            if (Gridview_Category.Rows.Count<=0) return;
            BookCategory Category = (BookCategory)Gridview_Category.CurrentRow.DataBoundItem;
            if (Category != null && Category.CategoryID != null && Category.Name != null)
            {
                LibraryDbContext.Shared.Entry(Category).Collection<Book>(e => e.Books).Load();//(e => e.Books).Load();
            }
        }

        private void ±£¥ÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibraryDbContext.Shared.SaveChanges();

            Gridview_Book.Refresh();
            Gridview_Category.Refresh();
        }

        private void Gridview_Category_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Gridview_Category_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //BookCategory Category = (BookCategory)Gridview_Category.CurrentRow.DataBoundItem;
            //if (Category != null)
            //{
            //    LibraryDbContext.Shared.Entry(Category).Collection<Book>(e => e.Books).Load();//(e => e.Books).Load();
            //}
        }
    }
}