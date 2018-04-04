using CeMaiFaci.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeMaiFaci
{
    public partial class MainForm : Form
    {
        private string RootDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);// Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private readonly string LogFileName = "log.json";
        private readonly string FeelingFileName = "feelings.json";
        private readonly string DateStringFormat = "yyyy-MMM-dd";
        private readonly string TimeStringFormat = "hh:mm tt";
        private string LogFile;
        private string FeelingFile;
        private DateTime TheDate;
        private bool TooltipShown = false;
        private DateTime NextAppearanceDateTime;

        public MainForm()
        {
            InitializeComponent();
            LogFile = Path.Combine(RootDir, LogFileName);
            FeelingFile = Path.Combine(RootDir, FeelingFileName);

            InitializeFeelings()
                .ConfigureAwait(false);

            lblTime.Text = $"Este ora {(TheDate = DateTime.Now).ToString("HH:mm")}";
        }

        private async Task InitializeFeelings()
        {
            lvFeelings.Groups.Clear();
            lvFeelings.Items.Clear();

            using (StreamReader sr = new StreamReader(FeelingFile))
            {
                var content = await sr.ReadToEndAsync();
                var feelingGroups = JsonConvert.DeserializeObject<List<FeelingsGroup>>(content);
                foreach (var feelingGroup in feelingGroups)
                {
                    var group = new ListViewGroup
                    {
                        Header = feelingGroup.Name
                    };
                    lvFeelings.Groups.Add(group);
                    foreach (var feeling in feelingGroup.Items)
                    {
                        var color = Color.FromArgb(
                                feelingGroup.Color[0],
                                feelingGroup.Color[1],
                                feelingGroup.Color[2]);
                        lvFeelings.Items.Add(new ListViewItem
                        {
                            Text = feeling,
                            Group = group,
                            BackColor = color
                        });
                    }
                }
            }
        }

        private void InitialiseTimer()
        {
            var interval = 1000 * 60 * 30;
            tmrTimer.Enabled = true;
            tmrTimer.Interval = interval;
            NextAppearanceDateTime = DateTime.Now.AddMilliseconds(interval);
        }

        private void Save()
        {
            var doContent = txtDo.Text;
            txtDo.Text = string.Empty;
            var doFeel = txtFeel.Text;
            txtFeel.Text = string.Empty;
            var doFeelTicks = new List<string>();
            for (var i = lvFeelings.CheckedItems.Count - 1; i >= 0; i--)
            {
                var item = lvFeelings.CheckedItems[i];
                doFeelTicks.Add(item.Text);
                item.Checked = false;
            }

            var logEntry = new LogEntry
            {
                Doing = doContent,
                Feelings = doFeelTicks.ToArray(),
                MyOwnFeelings = doFeel,
                TheDate = TheDate
            };

            List<LogEntry> logEntries = null;

            if (File.Exists(LogFile))
            {
                using (StreamReader sr = new StreamReader(LogFile))
                {
                    var content = sr.ReadToEnd();
                    logEntries = JsonConvert.DeserializeObject<List<LogEntry>>(content);
                }
            }

            if (logEntries == null)
            {
                logEntries = new List<LogEntry>();
            }
            logEntries.Add(logEntry);

            using (StreamWriter sw = new StreamWriter(LogFile))
            {
                var content = JsonConvert.SerializeObject(logEntries.OrderByDescending(e => e.TheDate));
                sw.Write(content);
            }
        }

        private void TheForm_Resize(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                HideIt();
            }
        }
        
        private void notifyIcon_DoubleClick(object sender, System.EventArgs e)
        {
            ShowIt();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowIt();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            HideIt();
        }

        private void btnLater_Click(object sender, EventArgs e)
        {
            HideIt();
        }

        private void tsmiShow_Click(object sender, EventArgs e)
        {
            ShowIt();
        }

        private void tmsiQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLog_Click(object sender, EventArgs e)
        {
            await ShowLog();
        }

        private async Task ShowLog()
        {
            var form = new LogForm();
            string content = null;
            using (StreamReader sr = new StreamReader(LogFile))
            {
                content = await sr.ReadToEndAsync();
            }

            var log = JsonConvert.DeserializeObject<List<LogEntry>>(content);
            var entryGroups = log.GroupBy(w => w.TheDate.Date)
                //.OrderByDescending(w => w.Key);
                .OrderBy(w => w.Key);
            var listView = form.LogItemsListView;
            listView.Clear();
            var richTextBox = form.LogItemsRichTextBox;
            richTextBox.Clear();
            var first = true;

            foreach (var entryGroup in entryGroups)
            {
                var header = entryGroup.Key.ToString(DateStringFormat);
                var group = new ListViewGroup
                {
                    Header = header
                };
                if (first)
                {
                    first = false;
                    richTextBox.AppendText($"{header}");
                } else
                {
                    richTextBox.AppendText($"\n\n{header}");
                }
                //listView.Groups.Add(group);

                var items = entryGroup
                    //.OrderByDescending(w => w.TheDate);
                    .OrderBy(w => w.TheDate);

                foreach (var entry in items)
                {
                    var time = entry.TheDate.ToString(TimeStringFormat);
                    richTextBox.AppendText($"\n    {time}:");
                    if (!string.IsNullOrEmpty(entry.Doing))
                    {
                        richTextBox.AppendText($"\n        Do: {entry.Doing}");
                    }
                    if (entry.Feelings.Any())
                    {
                        richTextBox.AppendText($"\n        Feel: {string.Join(", ", entry.Feelings)}");
                    }
                    if (!string.IsNullOrEmpty(entry.MyOwnFeelings)) {
                        richTextBox.AppendText($"\n        Comment: {entry.MyOwnFeelings}");
                    }
                    //listView.Items.Add(new ListViewItem
                    //{
                    //    Text = text,
                    //    Group = group
                    //});
                }
            }

            form.Show();
        }

        private void ShowIt()
        {
            lblTime.Text = $"Este ora {(TheDate = DateTime.Now).ToString("HH:mm")}";
            tmrTimer.Enabled = false;
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void HideIt()
        {
            notifyIcon.Visible = true;
            if (!TooltipShown)
            {
                notifyIcon.ShowBalloonTip(1000);
                TooltipShown = true;
            }            
            Hide();
            InitialiseTimer();
        }

        private async void tmsiShowLog_Click(object sender, EventArgs e)
        {
            await ShowLog();
        }

        private void notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            var unit = "minute";
            var remaining = (int)((NextAppearanceDateTime - DateTime.Now).TotalMinutes);
            if (remaining == 0)
            {
                remaining = (int)((NextAppearanceDateTime - DateTime.Now).TotalSeconds);
                unit = "secunde";
            }
            notifyIcon.Text = $"Inca { remaining } { unit }";
        }
    }
}
