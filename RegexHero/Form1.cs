using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegexHero.Properties;

namespace RegexHero
{
    public partial class Form1 : Form
    {
        private event Action<string> UpdateRegex;
        private event Action<TextBox> BadRegexUpdate;
        private event Action<Regex, MatchCollection> CalculateScore;

        public Form1()
        {
            InitializeComponent();

            this.materialsBox.Text = Resources.example1;

            this.UpdateRegex += (pattern) =>
            {
                Regex r = null;
                MatchCollection mc = null;
                try
                {
                    r = new Regex(pattern);
                    mc = r.Matches(this.materialsBox.Text);
                    
                } catch(Exception)
                {
                    this.BadRegexUpdate(this.textBox1);
                }
                
                this.CalculateScore(r, mc);
            };

            this.BadRegexUpdate += (textBox) =>
            {
                textBox.ForeColor = Color.Red;
            };

            CalculateScore += (regex, matches) =>
            {
                scoreLabel.Text = DateTime.Now.ToLongTimeString();
            };
        }

        private void NoCheating(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("No Cheating!");
        }

        private void RegexSourceTextChanged(object sender, EventArgs e)
        {
            TextBox source = sender as TextBox;
            if (source == null)
            {
                return;
            }
            source.ForeColor = Color.Black;
            this.UpdateRegex(source.Text);
        }
    }
}
