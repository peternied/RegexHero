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
using RegexHero.ScoreBoardService;

namespace RegexHero
{
    public partial class Form1 : Form
    {
        private event Action<string> UpdateRegex;
        private event Action<TextBox> BadRegexUpdate;
        private event Action<MatchCollection> UpdatePreviewPane;
        private event Action<string, MatchCollection> CalculateScore;
        private Task<GameId> ScoreboardGameId { get; set; }
        private Task<ScoreBoardVersion> ScoreBoardVersion { get; set; }
        private ScoreBoardService1Client client = new ScoreBoardService1Client();

        public Form1()
        {
            InitializeComponent();

            this.ScoreboardGameId = client.GameIdAsync("RegexHero", 1);
            this.ScoreBoardVersion = client.ServiceVersionAsync();

            this.materialsBox.Text = Resources.example1;
            this.StartUpdateHighScores(client);

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
                this.UpdateMaterialColor(0, this.materialsBox.MaxLength, Color.Black);
            };

            this.CalculateScore += (regex, matches) =>
            {
                int regexSize = regex.Length;
                int score = regexSize * matches.Count * (matches.Count != 0 ? matches[0].Groups.Count : 1);

                client.SubmitScoreAsync(this.ScoreBoardVersion.Result, this.ScoreboardGameId.Result, Environment.UserName, score);
                scoreLabel.Text = score.ToString();

                this.StartUpdateHighScores(client);
            };

            this.UpdatePreviewPane += (matches) =>
            {
                this.UpdateMaterialColor(0, this.materialsBox.MaxLength, Color.Black);
                int currentCount = 0;
                const int maxUpdates = 1000;

                foreach (Match match in matches)
                {
                    for (int i = 0; true; i++)
                    {
                        Group outerMatch = match.Groups[i];
                        if (!outerMatch.Success || currentCount++ > maxUpdates)
                        {
                            break;
                        }
                        this.UpdateMaterialColor(outerMatch.Index, outerMatch.Length, this.GetColor(currentCount));
                    }
                }
            };
        }

        private void StartUpdateHighScores(ScoreBoardService1Client client)
        {
            client.RetrieveScoresAsync(this.ScoreBoardVersion.Result, this.ScoreboardGameId.Result)
                .ContinueWith(t => highScoresTextBox.Invoke((Action)(() =>
                    highScoresTextBox.Text = string.Join(Environment.NewLine, t.Result.Select(i => string.Join(" ", i.Item1, i.Item2)))
                    )));
        }

        private Color GetColor(int seed)
        {
            switch (seed % 9)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.Green;
                case 2:
                    return Color.HotPink;
                case 3:
                    return Color.Firebrick;
                case 4:
                    return Color.Blue;
                case 5:
                    return Color.Crimson;
                case 6:
                    return Color.DarkOliveGreen;
                case 7:
                    return Color.Chocolate;
                case 8:
                    return Color.DarkOrange;
                case 9:
                    return Color.Aquamarine;
                default:
                    return Color.White;
            }
        }

        private void UpdateMaterialColor(int start, int end, Color color)
        {
            this.materialsBox.Select(start, end);
            this.materialsBox.SelectionColor = color;
        }

        private void CheatSheetClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheatSheetWindow window = new CheatSheetWindow();
            window.Show(this);
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
