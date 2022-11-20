using Microsoft.EntityFrameworkCore;

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
            BookCategory Category = (BookCategory)Gridview_Category.CurrentRow.DataBoundItem;
            if (Category != null)
            {
                LibraryDbContext.Shared.Entry(Category).Collection<Book>(e => e.Books);//(e => e.Books).Load();
            }
        }
    }
}