using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWSheetAnim.Components;
using SWSheetAnim.Systems;

namespace SWSheetAnim
{
    public partial class MainForm : Form
    {
        BindingList<IStep> StepList;
        

        public MainForm()
        {
            InitializeComponent();
            StepList = new BindingList<IStep>();
            stepListBox.DataSource = StepList;
            stepListBox.DisplayMember = "Name";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void newStepBtn_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.Show();
        }

        private void delStepBtn_Click(object sender, EventArgs e)
        {
            StepList.Remove((IStep)stepListBox.SelectedItem);
        }

        private void upStepBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = stepListBox.SelectedIndex;
            if (selectedIndex - 1 >= 0)
            {
                IStep selectedItem = StepList[selectedIndex];
                StepList.Remove(selectedItem);
                StepList.Insert(selectedIndex - 1, selectedItem);
                stepListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        private void downStepBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = stepListBox.SelectedIndex;
            if(selectedIndex + 1 < StepList.Count)
            {
                IStep selectedItem = StepList[selectedIndex];
                StepList.Remove(selectedItem);
                StepList.Insert(selectedIndex + 1, selectedItem);
                stepListBox.SelectedIndex = selectedIndex + 1;
            }
        }

        public void AddStep(IStep step)
        {
            int selectedIndex = stepListBox.SelectedIndex;
            StepList.Insert(selectedIndex + 1, step);
            stepListBox.SelectedIndex = selectedIndex + 1;
        }

        private void BindControl(System.Windows.Forms.Control control, string attribute, object target, string targetAttr)
        {
            control.DataBindings.Clear();
            control.DataBindings.Add(attribute, target, targetAttr, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ShowTab(GroupBox tab)
        {
            foldTab.Visible = false;
            moveTab.Visible = false;
            tab.Visible = true;
        }

        private void stepListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IStep currentStep = (IStep)stepListBox.SelectedItem;
            if(currentStep is FoldStep)
            {
                ShowTab(foldTab);
                BindControl(foldDurationTxt, "Text", currentStep, "Duration");
                BindControl(foldStartTxt, "Text", currentStep, "StartValue");
                BindControl(foldEndTxt, "Text", currentStep, "EndValue");
                BindControl(foldWaitTxt, "Text", currentStep, "WaitTime");
                BindControl(foldRepeatChk, "Checked", currentStep, "IsFoldBack");
            }
            else if(currentStep is TransformStep)
            {
                ShowTab(moveTab);
                TransformStep step = (TransformStep)currentStep;
                BindControl(moveDurationTxt, "Text", currentStep, "Duration");
                BindControl(moveWaitTxt, "Text", currentStep, "WaitTime");
                BindStepControls(step);
            }
        }

        private void BindStepControls(TransformStep step)
        {
            BindControl(moveStartXTxt, "Text", step.StartTransform, "x");
            BindControl(moveStartYTxt, "Text", step.StartTransform, "y");
            BindControl(moveStartZTxt, "Text", step.StartTransform, "z");
            BindControl(moveStartPitchTxt, "Text", step.StartTransform, "pitch");
            BindControl(moveStartYawTxt, "Text", step.StartTransform, "yaw");
            BindControl(moveStartRollTxt, "Text", step.StartTransform, "roll");
            BindControl(moveEndXTxt, "Text", step.EndTransform, "x");
            BindControl(moveEndYTxt, "Text", step.EndTransform, "y");
            BindControl(moveEndZTxt, "Text", step.EndTransform, "z");
            BindControl(moveEndPitchTxt, "Text", step.EndTransform, "pitch");
            BindControl(moveEndYawTxt, "Text", step.EndTransform, "yaw");
            BindControl(moveEndRollTxt, "Text", step.EndTransform, "roll");
        }

        private void foldSetStartBtn_Click(object sender, EventArgs e)
        {
            FoldStep step = (FoldStep)stepListBox.SelectedItem;
            FoldSystem fs = new FoldSystem(step.Fold);
            fs.SetValue(Convert.ToDouble(foldStartTxt.Text));
            fs.RefreshScene();
        }

        private void foldSetEndBtn_Click(object sender, EventArgs e)
        {
            FoldStep step = (FoldStep)stepListBox.SelectedItem;
            FoldSystem fs = new FoldSystem(step.Fold);
            fs.SetValue(Convert.ToDouble(foldEndTxt.Text));
            fs.RefreshScene();
        }

        private void videoOutputBtn_Click(object sender, EventArgs e)
        {
            if(stepListBox.SelectedIndex == -1)
            {
                return;
            }
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "MPEG4视频|*.mp4";
            saveFileDialog1.Title = "保存视频";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                videoOutputProgress.Visible = true;
                videoOutputProgress.Value = 0;
                int stepCount = StepList.Count;
                int stepIndex = 0;
                VideoMaker maker = new VideoMaker(saveFileDialog1.FileName);
                foreach(IStep step in StepList)
                {
                    maker.AddStep(step);
                    stepIndex++;
                    videoOutputProgress.Value = (int)(100.0 * stepIndex / stepCount);
                }
                maker.Close();
                videoOutputProgress.Visible = false;
            }
        }

        private void moveStartLoadBtn_Click(object sender, EventArgs e)
        {
            TransformStep step = (TransformStep)stepListBox.SelectedItem;
            PartSystem ps = new PartSystem(step.Part);
            step.StartTransform = ps.GetTransform();
            BindStepControls(step);
        }

        private void moveStartSetBtn_Click(object sender, EventArgs e)
        {
            TransformStep step = (TransformStep)stepListBox.SelectedItem;
            PartSystem ps = new PartSystem(step.Part);
            ps.SetTransform(step.StartTransform);
            ps.RefreshScene();
        }

        private void moveEndLoadBtn_Click(object sender, EventArgs e)
        {
            TransformStep step = (TransformStep)stepListBox.SelectedItem;
            PartSystem ps = new PartSystem(step.Part);
            step.EndTransform = ps.GetTransform();
            BindStepControls(step);
        }

        private void moveEndSetBtn_Click(object sender, EventArgs e)
        {
            TransformStep step = (TransformStep)stepListBox.SelectedItem;
            PartSystem ps = new PartSystem(step.Part);
            ps.SetTransform(step.EndTransform);
            ps.RefreshScene();
        }
    }
}
