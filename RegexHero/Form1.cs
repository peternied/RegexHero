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
        private event Action<MatchCollection> UpdatePreviewPane;
        private event Action<string, MatchCollection> CalculateScore;

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
                }
                catch(Exception)
                {
                }

                if (r == null || mc == null)
                {
                    this.BadRegexUpdate(this.textBox1);
                    return;
                }

                this.CalculateScore(pattern, mc);
                this.UpdatePreviewPane(mc);
            };

            this.BadRegexUpdate += (textBox) =>
            {
                textBox.ForeColor = Color.Red;
            };

            this.CalculateScore += (regex, matches) =>
            {
                int regexSize = regex.Length;
                int score = regexSize * matches.Count * (matches.Count != 0 ? matches[0].Groups.Count : 1);

                scoreLabel.Text = score.ToString();
            };

            this.UpdatePreviewPane += (matches) =>
            {
                foreach (Match match in matches)
                {
                    foreach (object groups in match.Groups)
                    {
                        GroupCollection innerGroup = groups as GroupCollection;
                        if (innerGroup != null)
                        {
                            foreach (Match innerMatch in innerGroup)
                            {
                                this.materialsBox.Select(innerMatch.Index, innerMatch.Length);
                                this.materialsBox.SelectionColor = Color.Green;
                            }
                            continue;
                        }

                        Match outerMatch = groups as Match;
                        if (outerMatch != null)
                        {
                            this.materialsBox.Select(outerMatch.Index, outerMatch.Length);
                            this.materialsBox.SelectionColor = Color.Green;
                        }
                    }
                }
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
