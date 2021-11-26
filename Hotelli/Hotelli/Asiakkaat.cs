using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotelli
{
    public partial class Asiakkaat : Form
    {
        public Asiakkaat()
        {
            InitializeComponent();
        }

        Asiakas ASIAKAS = new Asiakas();
        private void Asiakkaat_Load(object sender, EventArgs e)
        {
            AsiakkaatDG.DataSource = ASIAKAS.getAsiakkaat();
        }

        private void TyhjAsBT_Click(object sender, EventArgs e)
        {
            KayttajaTB.Text = "";
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            OsoiteTB.Text = "";
            PnumTB.Text = "";
            PtPaikkaTB.Text = "";
            SalasanaTB.Text = "";
        }

        // JÄIN TÄHÄN!!!!!!!!!!!!!!!!!!!!
        // JATKA TALLENNUSNAPIN TEOSTA 




        private void TallAsBT_Click(object sender, EventArgs e)
        {
            String bok = bookTB.Text;
            String author = authorTB.Text;
            int noc = Int32.Parse(nocTB.Text);

            if (bok.Trim().Equals("") || author.Trim().Equals("") || noc.Equals(""))
            {
                MessageBox.Show("Error, All fields must be filled", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean addNewBook = book.addBook(bok, author, noc);
                if (addNewBook)
                {
                    MessageBox.Show("New book added to library", "Add new book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Could not add new book", "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            bookDG.DataSource = book.getBooks();
        }

        private void updateBT_Click(object sender, EventArgs e)
        {
            String bok = bookTB.Text;
            String author = authorTB.Text;
            int noc = Int32.Parse(nocTB.Text);
            int id = Int32.Parse(bid.Text);

            if (bid.Equals("") || bok.Trim().Equals("") || author.Trim().Equals("") || noc.Equals(""))
            {
                MessageBox.Show("Error, All fields must be filled", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean addNewBook = book.editBook(id, bok, author, noc);
                if (addNewBook)
                {
                    MessageBox.Show("Book updated succesfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Could not update book", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            bookDG.DataSource = book.getBooks();
        }

        private void bookDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bid.Text = bookDG.CurrentRow.Cells[0].Value.ToString();
            bookTB.Text = bookDG.CurrentRow.Cells[1].Value.ToString();
            authorTB.Text = bookDG.CurrentRow.Cells[2].Value.ToString();
            nocTB.Text = bookDG.CurrentRow.Cells[3].Value.ToString();
        }
        private void deleteBT_Click(object sender, EventArgs e)
        {
            String username = bid.Text;
            if (book.deleteBook(username))
            {
                bookDG.DataSource = book.getBooks();
                MessageBox.Show("Book deleted succesfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Could not delete book", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearBT.PerformClick();

        }
    }
}
    }
}
