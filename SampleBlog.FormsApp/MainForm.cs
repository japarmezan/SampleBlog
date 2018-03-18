using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleBlog.Data;
using SampleBlog.Domain;
using SampleBlog.Service;

namespace SampleBlog.FormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Post> posts;
        PostRepository repository = new PostRepository(new SampleBlog.Data.ADONET.PostProvider());

        public void Refresh()
        {
            posts = repository.GetAllPostsByAuthor(new Author()
            {
                Id = 1
            });

            listBoxPosts.Items.Clear();
            foreach (var post in posts)
            {
                listBoxPosts.Items.Add(post.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var posts = repository.InsertPost(new Post()
            //{
            //    AuthorId = 1,
            //    Text = "My second post",
            //    Category = "Lifestyle"
            //});
            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPost = posts[listBoxPosts.SelectedIndex];

            labelPostText.Text = selectedPost.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var postForm = new PostForm(-1, this);

            postForm.Show();
        }
    }
}
