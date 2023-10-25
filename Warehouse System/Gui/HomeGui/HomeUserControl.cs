﻿using SMSystem.Code;
using SMSystem.Core;
using SMSystem.Data;
using SMSystem.Gui.IncomeGui;
using SMSystem.Gui.MaterailsGui;
using SMSystem.Gui.OutComeGui;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SMSystem.Gui.Home
{
    public partial class HomeUserControl : UserControl
    {
        private readonly IDataHelper<Income> _dataHelper;
        private readonly IDataHelper<Materails> _dataHelperForMaterial;
        private static HomeUserControl _HomeUserControl;
        public HomeUserControl()
        {
            InitializeComponent();
            _dataHelper = (IDataHelper<Income>)ContainerConfig.ObjectType("Income");
            _dataHelperForMaterial = (IDataHelper<Materails>)ContainerConfig.ObjectType("Materails");
        }

        private OtherGui.NotificaitonPanel notificaitonPanel;
        public static HomeUserControl Instance()
        {
            return _HomeUserControl ?? (new HomeUserControl());
        }

        private void buttonAddMaterial_Click(object sender, System.EventArgs e)
        {
            MaterailsAddForm storeAdd = new MaterailsAddForm(0, new MaterailsUserControl());
            storeAdd.Show();
        }

        private void buttonAddIncome_Click(object sender, System.EventArgs e)
        {
            IncomeAddForm IncomeAdd = new IncomeAddForm(0, new IncomeUserControl(), new MaterailsGui.MaterailsUserControl());
            IncomeAdd.Show();
        }

        private void buttonAddOutCome_Click(object sender, System.EventArgs e)
        {
            OutComeAddForm OutComeAdd = new OutComeAddForm(0, new OutComeUserControl(), new MaterailsGui.MaterailsUserControl());
            OutComeAdd.Show();
        }

        private void HomeUserControl_Load(object sender, System.EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToShortTimeString();
            labelDate.Text = DateTime.Now.Date.ToShortDateString();
            labelWellcom.Text = "اهلا وسهلا بك " + Properties.Settings.Default.User;

            LoadSettings();

            SetDamagMaterialNotifications();
        }

        private void LoadSettings()
        {
            try
            {
                // Get And Set Excit Settings
                labelCompanyName.Text = Properties.Settings.Default.CompanyName;
                var Logo = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);
                if (Logo != null)
                {
                    using (MemoryStream ma = new MemoryStream(Logo))
                    {

                    }
                }
            }
            catch
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToShortTimeString();

        }

        private void SetDamagMaterialNotifications()
        {
            int duration = Properties.Settings.Default.NotificationDamagDuration;

            // Materials near to damage depend on duration above
            var currentData = DateTime.Now.Date;
            var IncomeDamageSoonExp = _dataHelper.GetData().Where(x => x.State == "متوفر" && x.ExpDate != x.AddedDate
              && Convert.ToDateTime(x.ExpDate.AddDays(-1 * duration)) < currentData).ToList();
            // Loop into Incom Need To Update
            foreach (var IncomeTable in IncomeDamageSoonExp)
            {
                notificaitonPanel = new OtherGui.NotificaitonPanel();
                notificaitonPanel.LabelNote.Text = " المادة " + IncomeTable.Name + " ستنتهي صلاحيتها في تاريخ " + IncomeTable.ExpDate.ToShortDateString() + "";

            }

            // Materials are Expired
            var IncomeExp = _dataHelper.GetData().Where(x => x.State == "منتهي الصلاحية").ToList();
            // Loop into Incom Need To Update
            foreach (var IncomeTable in IncomeExp)
            {
                notificaitonPanel = new OtherGui.NotificaitonPanel();
                notificaitonPanel.LabelNote.Text = "المادة  " + IncomeTable.Name + " انتهت صلاحيتها في تاريخ " + IncomeTable.ExpDate.ToShortDateString() + "";

            }

            var MaterialData = _dataHelperForMaterial.GetData().Where(x => x.Quantity > 0 && x.Quantity < 5).ToList();
            // Loop into Incom Need To Update
            foreach (var IncomeTable in MaterialData)
            {
                notificaitonPanel = new OtherGui.NotificaitonPanel();
                notificaitonPanel.LabelNote.Text = "المادة  " + IncomeTable.Name + "  الكمية المتبقة منها   " + "هي " + IncomeTable.Quantity.ToString() + "";

            }

        }
    }
}
