using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleBlog.Domain;
using SampleBlog.Service;

namespace SampleBlog.FormsApp
{
    public partial class PostForm : Form
    { 
        private PostRepository repository = new PostRepository(new SampleBlog.Data.ADONET.PostProvider());

        private MainForm parentForm;

        public PostForm(int postId, MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void PostForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newPost = new Post
            {
                AuthorId = 1,
                Text = richTextBoxPostText.Text,
                Category = textBoxCategory.Text,
            };

            repository.InsertPost(newPost);
            parentForm.Refresh();

            this.Close();
        }
    }
}
