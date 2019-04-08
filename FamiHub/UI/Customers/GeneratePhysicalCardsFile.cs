#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace FamiHub.UI.Customers
{
    public partial class GeneratePhysicalCardsFile : FHFormTab
    {
        public GeneratePhysicalCardsFile()
        {
            InitializeComponent();
            lblWarning.Visible = BusinessLayer.Customers.CustomerDataPush.Becosoft.CustomerLinkActive;
            ntrLastCardCreated.Visible = false;
            pgbProcess.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bgwCreateCards.RunWorkerAsync(new Tuple<FHFormTab, int>(this, (int)nudQuantity.Value));
            ntrLastCardCreated.Visible = true;
            pgbProcess.Visible = true;

            while (bgwCreateCards.IsBusy)
            {
                ntrLastCardCreated.Invalidate();
                pgbProcess.Invalidate();
                System.Threading.Thread.Sleep(100);
            }

            Common.Interaction.DownloadFromStream(this, _bgwResult.Item2, "LoyaltyCards.txt");
        }

        private void bgwCreateCards_DoWork(object sender, DoWorkEventArgs e)
        {
            Tuple<FHFormTab, int> par = (Tuple<FHFormTab, int>)e.Argument;
            System.IO.MemoryStream file = new System.IO.MemoryStream();
            System.IO.StreamWriter writer = new System.IO.StreamWriter(file);

            for (int i = 0; i < par.Item2; i++)
            {
                string card = BusinessLayer.Loyalty.Card.GeneratePhysicalCardNumbers(1)[0];
                writer.WriteLine(card);
                (sender as BackgroundWorker).ReportProgress((i / par.Item2) * 100);
            }

            writer.Flush();
            file.Flush();

            e.Result = new Tuple<FHFormTab, byte[]>(par.Item1, file.ToArray());
        }

        private void bgwCreateCards_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbProcess.Value = e.ProgressPercentage;
            ntrLastCardCreated.Text = "Processing......" + pgbProcess.Value.ToString() + "%";
        }

        private Tuple<FHFormTab, byte[]> _bgwResult;
        private void bgwCreateCards_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _bgwResult = (Tuple<FHFormTab, byte[]>)e.Result;
            ntrLastCardCreated.Visible = false;
            pgbProcess.Visible = false;
        }
    }
}