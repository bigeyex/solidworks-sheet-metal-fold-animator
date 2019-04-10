using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWSheetAnim.Systems;
using SWSheetAnim.Components;

namespace SWSheetAnim
{
    public partial class AddForm : Form
    {
        MainForm MainForm;

        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            this.MainForm = mainForm;
        }

        private void AddForm_Shown(object sender, EventArgs e)
        {
            partListControl.DataSource = SWEngine.Instance.GetParts();
            partListControl.DisplayMember = "Name";
        }

        private void partListControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Part selectedPart = (Part)partListControl.SelectedItem;
            PartSystem ps = new PartSystem(selectedPart);
            foldListControl.DataSource = ps.GetFolds();
            foldListControl.DisplayMember = "Name";
        }

        private void addFoldBtn_Click(object sender, EventArgs e)
        {
            FoldStep fs = new FoldStep();
            fs.Fold = (Fold)foldListControl.SelectedItem;
            fs.Name = "折叠" + fs.Fold.PartName + "/" + fs.Fold.Name;
            MainForm.AddStep(fs);
        }

        private void addPreFoldBtn_Click(object sender, EventArgs e)
        {
            FoldStep fs = new FoldStep();
            fs.Fold = (Fold)foldListControl.SelectedItem;
            fs.Name = "折叠" + fs.Fold.PartName + "/" + fs.Fold.Name;
            fs.IsFoldBack = true;
            MainForm.AddStep(fs);
        }

        private void addMoveBtn_Click(object sender, EventArgs e)
        {
            TransformStep ts = new TransformStep();
            ts.Part = (Part)partListControl.SelectedItem;
            PartSystem ps = new PartSystem(ts.Part);
            ts.StartTransform = ps.GetTransform();
            ts.EndTransform = ps.GetTransform();
            ts.Name = "移动" + ts.Part.Name;
            MainForm.AddStep(ts);
        }

        private void addCameraMoveBtn_Click(object sender, EventArgs e)
        {
            CameraStep cs = new CameraStep();
            cs.StartPosition = SWEngine.Instance.GetCameraPosition();
            cs.EndPosition = SWEngine.Instance.GetCameraPosition();
            cs.Name = "运动镜头";
            MainForm.AddStep(cs);
        }
    }
}
