namespace SWSheetAnim
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.stepListBox = new System.Windows.Forms.ListBox();
            this.newStepBtn = new System.Windows.Forms.Button();
            this.foldTab = new System.Windows.Forms.GroupBox();
            this.foldWaitTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.foldRepeatChk = new System.Windows.Forms.CheckBox();
            this.foldSetEndBtn = new System.Windows.Forms.Button();
            this.foldSetStartBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foldEndTxt = new System.Windows.Forms.TextBox();
            this.foldStartTxt = new System.Windows.Forms.TextBox();
            this.foldDurationTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.videoOutputBtn = new System.Windows.Forms.Button();
            this.videoOutputProgress = new System.Windows.Forms.ProgressBar();
            this.delStepBtn = new System.Windows.Forms.Button();
            this.upStepBtn = new System.Windows.Forms.Button();
            this.downStepBtn = new System.Windows.Forms.Button();
            this.moveTab = new System.Windows.Forms.GroupBox();
            this.moveEndSetBtn = new System.Windows.Forms.Button();
            this.moveStartSetBtn = new System.Windows.Forms.Button();
            this.moveEndLoadBtn = new System.Windows.Forms.Button();
            this.moveStartLoadBtn = new System.Windows.Forms.Button();
            this.moveWaitTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.moveEndZTxt = new System.Windows.Forms.TextBox();
            this.moveStartZTxt = new System.Windows.Forms.TextBox();
            this.moveEndRollTxt = new System.Windows.Forms.TextBox();
            this.moveStartRollTxt = new System.Windows.Forms.TextBox();
            this.moveEndYTxt = new System.Windows.Forms.TextBox();
            this.moveStartYTxt = new System.Windows.Forms.TextBox();
            this.moveEndYawTxt = new System.Windows.Forms.TextBox();
            this.moveStartYawTxt = new System.Windows.Forms.TextBox();
            this.moveEndXTxt = new System.Windows.Forms.TextBox();
            this.moveStartXTxt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.moveEndPitchTxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.moveStartPitchTxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.moveDurationTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cameraTab = new System.Windows.Forms.GroupBox();
            this.cameraWaitTxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cameraEndLoadBtn = new System.Windows.Forms.Button();
            this.cameraStartLoadBtn = new System.Windows.Forms.Button();
            this.cameraEndSetBtn = new System.Windows.Forms.Button();
            this.cameraStartSetBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cameraDurationTxt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.saveProjectBtn = new System.Windows.Forms.Button();
            this.loadProjectBtn = new System.Windows.Forms.Button();
            this.foldTab.SuspendLayout();
            this.moveTab.SuspendLayout();
            this.cameraTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steps";
            // 
            // stepListBox
            // 
            this.stepListBox.FormattingEnabled = true;
            this.stepListBox.ItemHeight = 24;
            this.stepListBox.Location = new System.Drawing.Point(37, 136);
            this.stepListBox.Name = "stepListBox";
            this.stepListBox.Size = new System.Drawing.Size(350, 388);
            this.stepListBox.TabIndex = 1;
            this.stepListBox.SelectedIndexChanged += new System.EventHandler(this.stepListBox_SelectedIndexChanged);
            // 
            // newStepBtn
            // 
            this.newStepBtn.Location = new System.Drawing.Point(37, 531);
            this.newStepBtn.Name = "newStepBtn";
            this.newStepBtn.Size = new System.Drawing.Size(83, 43);
            this.newStepBtn.TabIndex = 2;
            this.newStepBtn.Text = "Add";
            this.newStepBtn.UseVisualStyleBackColor = true;
            this.newStepBtn.Click += new System.EventHandler(this.newStepBtn_Click);
            // 
            // foldTab
            // 
            this.foldTab.Controls.Add(this.foldWaitTxt);
            this.foldTab.Controls.Add(this.label5);
            this.foldTab.Controls.Add(this.foldRepeatChk);
            this.foldTab.Controls.Add(this.foldSetEndBtn);
            this.foldTab.Controls.Add(this.foldSetStartBtn);
            this.foldTab.Controls.Add(this.label4);
            this.foldTab.Controls.Add(this.label3);
            this.foldTab.Controls.Add(this.foldEndTxt);
            this.foldTab.Controls.Add(this.foldStartTxt);
            this.foldTab.Controls.Add(this.foldDurationTxt);
            this.foldTab.Controls.Add(this.label2);
            this.foldTab.Location = new System.Drawing.Point(419, 98);
            this.foldTab.Name = "foldTab";
            this.foldTab.Size = new System.Drawing.Size(478, 426);
            this.foldTab.TabIndex = 3;
            this.foldTab.TabStop = false;
            this.foldTab.Text = "Fold";
            // 
            // foldWaitTxt
            // 
            this.foldWaitTxt.Location = new System.Drawing.Point(178, 90);
            this.foldWaitTxt.Name = "foldWaitTxt";
            this.foldWaitTxt.Size = new System.Drawing.Size(168, 35);
            this.foldWaitTxt.TabIndex = 6;
            this.foldWaitTxt.Text = "0.3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wait(s)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // foldRepeatChk
            // 
            this.foldRepeatChk.AutoSize = true;
            this.foldRepeatChk.Location = new System.Drawing.Point(141, 255);
            this.foldRepeatChk.Name = "foldRepeatChk";
            this.foldRepeatChk.Size = new System.Drawing.Size(114, 28);
            this.foldRepeatChk.TabIndex = 4;
            this.foldRepeatChk.Text = "Crease";
            this.foldRepeatChk.UseVisualStyleBackColor = true;
            // 
            // foldSetEndBtn
            // 
            this.foldSetEndBtn.Location = new System.Drawing.Point(349, 202);
            this.foldSetEndBtn.Name = "foldSetEndBtn";
            this.foldSetEndBtn.Size = new System.Drawing.Size(68, 34);
            this.foldSetEndBtn.TabIndex = 3;
            this.foldSetEndBtn.Text = "Set";
            this.foldSetEndBtn.UseVisualStyleBackColor = true;
            this.foldSetEndBtn.Click += new System.EventHandler(this.foldSetEndBtn_Click);
            // 
            // foldSetStartBtn
            // 
            this.foldSetStartBtn.Location = new System.Drawing.Point(349, 158);
            this.foldSetStartBtn.Name = "foldSetStartBtn";
            this.foldSetStartBtn.Size = new System.Drawing.Size(68, 34);
            this.foldSetStartBtn.TabIndex = 3;
            this.foldSetStartBtn.Text = "Set";
            this.foldSetStartBtn.UseVisualStyleBackColor = true;
            this.foldSetStartBtn.Click += new System.EventHandler(this.foldSetStartBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "End Angle";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Angle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // foldEndTxt
            // 
            this.foldEndTxt.Location = new System.Drawing.Point(166, 201);
            this.foldEndTxt.Name = "foldEndTxt";
            this.foldEndTxt.Size = new System.Drawing.Size(168, 35);
            this.foldEndTxt.TabIndex = 1;
            this.foldEndTxt.Text = "90";
            // 
            // foldStartTxt
            // 
            this.foldStartTxt.Location = new System.Drawing.Point(166, 158);
            this.foldStartTxt.Name = "foldStartTxt";
            this.foldStartTxt.Size = new System.Drawing.Size(168, 35);
            this.foldStartTxt.TabIndex = 1;
            this.foldStartTxt.Text = "0";
            // 
            // foldDurationTxt
            // 
            this.foldDurationTxt.Location = new System.Drawing.Point(178, 49);
            this.foldDurationTxt.Name = "foldDurationTxt";
            this.foldDurationTxt.Size = new System.Drawing.Size(168, 35);
            this.foldDurationTxt.TabIndex = 1;
            this.foldDurationTxt.Text = "0.3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Duration(s)";
            // 
            // videoOutputBtn
            // 
            this.videoOutputBtn.Location = new System.Drawing.Point(688, 531);
            this.videoOutputBtn.Name = "videoOutputBtn";
            this.videoOutputBtn.Size = new System.Drawing.Size(209, 43);
            this.videoOutputBtn.TabIndex = 2;
            this.videoOutputBtn.Text = "Export Video";
            this.videoOutputBtn.UseVisualStyleBackColor = true;
            this.videoOutputBtn.Click += new System.EventHandler(this.videoOutputBtn_Click);
            // 
            // videoOutputProgress
            // 
            this.videoOutputProgress.Location = new System.Drawing.Point(525, 530);
            this.videoOutputProgress.Name = "videoOutputProgress";
            this.videoOutputProgress.Size = new System.Drawing.Size(157, 43);
            this.videoOutputProgress.TabIndex = 4;
            this.videoOutputProgress.Visible = false;
            // 
            // delStepBtn
            // 
            this.delStepBtn.Location = new System.Drawing.Point(126, 530);
            this.delStepBtn.Name = "delStepBtn";
            this.delStepBtn.Size = new System.Drawing.Size(83, 43);
            this.delStepBtn.TabIndex = 2;
            this.delStepBtn.Text = "Del";
            this.delStepBtn.UseVisualStyleBackColor = true;
            this.delStepBtn.Click += new System.EventHandler(this.delStepBtn_Click);
            // 
            // upStepBtn
            // 
            this.upStepBtn.Location = new System.Drawing.Point(215, 530);
            this.upStepBtn.Name = "upStepBtn";
            this.upStepBtn.Size = new System.Drawing.Size(83, 43);
            this.upStepBtn.TabIndex = 2;
            this.upStepBtn.Text = "Up";
            this.upStepBtn.UseVisualStyleBackColor = true;
            this.upStepBtn.Click += new System.EventHandler(this.upStepBtn_Click);
            // 
            // downStepBtn
            // 
            this.downStepBtn.Location = new System.Drawing.Point(304, 531);
            this.downStepBtn.Name = "downStepBtn";
            this.downStepBtn.Size = new System.Drawing.Size(83, 43);
            this.downStepBtn.TabIndex = 2;
            this.downStepBtn.Text = "Down";
            this.downStepBtn.UseVisualStyleBackColor = true;
            this.downStepBtn.Click += new System.EventHandler(this.downStepBtn_Click);
            // 
            // moveTab
            // 
            this.moveTab.Controls.Add(this.moveEndSetBtn);
            this.moveTab.Controls.Add(this.moveStartSetBtn);
            this.moveTab.Controls.Add(this.moveEndLoadBtn);
            this.moveTab.Controls.Add(this.moveStartLoadBtn);
            this.moveTab.Controls.Add(this.moveWaitTxt);
            this.moveTab.Controls.Add(this.label6);
            this.moveTab.Controls.Add(this.moveEndZTxt);
            this.moveTab.Controls.Add(this.moveStartZTxt);
            this.moveTab.Controls.Add(this.moveEndRollTxt);
            this.moveTab.Controls.Add(this.moveStartRollTxt);
            this.moveTab.Controls.Add(this.moveEndYTxt);
            this.moveTab.Controls.Add(this.moveStartYTxt);
            this.moveTab.Controls.Add(this.moveEndYawTxt);
            this.moveTab.Controls.Add(this.moveStartYawTxt);
            this.moveTab.Controls.Add(this.moveEndXTxt);
            this.moveTab.Controls.Add(this.moveStartXTxt);
            this.moveTab.Controls.Add(this.label20);
            this.moveTab.Controls.Add(this.label14);
            this.moveTab.Controls.Add(this.moveEndPitchTxt);
            this.moveTab.Controls.Add(this.label19);
            this.moveTab.Controls.Add(this.moveStartPitchTxt);
            this.moveTab.Controls.Add(this.label18);
            this.moveTab.Controls.Add(this.label13);
            this.moveTab.Controls.Add(this.label11);
            this.moveTab.Controls.Add(this.label17);
            this.moveTab.Controls.Add(this.moveDurationTxt);
            this.moveTab.Controls.Add(this.label16);
            this.moveTab.Controls.Add(this.label12);
            this.moveTab.Controls.Add(this.label15);
            this.moveTab.Controls.Add(this.label7);
            this.moveTab.Controls.Add(this.label8);
            this.moveTab.Controls.Add(this.labelStart);
            this.moveTab.Controls.Add(this.label10);
            this.moveTab.Controls.Add(this.label9);
            this.moveTab.Location = new System.Drawing.Point(419, 98);
            this.moveTab.Name = "moveTab";
            this.moveTab.Size = new System.Drawing.Size(478, 426);
            this.moveTab.TabIndex = 5;
            this.moveTab.TabStop = false;
            this.moveTab.Text = "Move Part";
            // 
            // moveEndSetBtn
            // 
            this.moveEndSetBtn.Location = new System.Drawing.Point(174, 281);
            this.moveEndSetBtn.Name = "moveEndSetBtn";
            this.moveEndSetBtn.Size = new System.Drawing.Size(74, 41);
            this.moveEndSetBtn.TabIndex = 7;
            this.moveEndSetBtn.Text = "Set";
            this.moveEndSetBtn.UseVisualStyleBackColor = true;
            this.moveEndSetBtn.Click += new System.EventHandler(this.moveEndSetBtn_Click);
            // 
            // moveStartSetBtn
            // 
            this.moveStartSetBtn.Location = new System.Drawing.Point(174, 137);
            this.moveStartSetBtn.Name = "moveStartSetBtn";
            this.moveStartSetBtn.Size = new System.Drawing.Size(74, 41);
            this.moveStartSetBtn.TabIndex = 7;
            this.moveStartSetBtn.Text = "Set";
            this.moveStartSetBtn.UseVisualStyleBackColor = true;
            this.moveStartSetBtn.Click += new System.EventHandler(this.moveStartSetBtn_Click);
            // 
            // moveEndLoadBtn
            // 
            this.moveEndLoadBtn.Location = new System.Drawing.Point(94, 281);
            this.moveEndLoadBtn.Name = "moveEndLoadBtn";
            this.moveEndLoadBtn.Size = new System.Drawing.Size(74, 41);
            this.moveEndLoadBtn.TabIndex = 7;
            this.moveEndLoadBtn.Text = "Load";
            this.moveEndLoadBtn.UseVisualStyleBackColor = true;
            this.moveEndLoadBtn.Click += new System.EventHandler(this.moveEndLoadBtn_Click);
            // 
            // moveStartLoadBtn
            // 
            this.moveStartLoadBtn.Location = new System.Drawing.Point(94, 137);
            this.moveStartLoadBtn.Name = "moveStartLoadBtn";
            this.moveStartLoadBtn.Size = new System.Drawing.Size(74, 41);
            this.moveStartLoadBtn.TabIndex = 7;
            this.moveStartLoadBtn.Text = "Load";
            this.moveStartLoadBtn.UseVisualStyleBackColor = true;
            this.moveStartLoadBtn.Click += new System.EventHandler(this.moveStartLoadBtn_Click);
            // 
            // moveWaitTxt
            // 
            this.moveWaitTxt.Location = new System.Drawing.Point(141, 90);
            this.moveWaitTxt.Name = "moveWaitTxt";
            this.moveWaitTxt.Size = new System.Drawing.Size(168, 35);
            this.moveWaitTxt.TabIndex = 6;
            this.moveWaitTxt.Text = "0.3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wait(s)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // moveEndZTxt
            // 
            this.moveEndZTxt.Location = new System.Drawing.Point(388, 332);
            this.moveEndZTxt.Name = "moveEndZTxt";
            this.moveEndZTxt.Size = new System.Drawing.Size(90, 35);
            this.moveEndZTxt.TabIndex = 1;
            this.moveEndZTxt.Text = "0.3";
            // 
            // moveStartZTxt
            // 
            this.moveStartZTxt.Location = new System.Drawing.Point(388, 188);
            this.moveStartZTxt.Name = "moveStartZTxt";
            this.moveStartZTxt.Size = new System.Drawing.Size(90, 35);
            this.moveStartZTxt.TabIndex = 1;
            this.moveStartZTxt.Text = "0.3";
            // 
            // moveEndRollTxt
            // 
            this.moveEndRollTxt.Location = new System.Drawing.Point(388, 373);
            this.moveEndRollTxt.Name = "moveEndRollTxt";
            this.moveEndRollTxt.Size = new System.Drawing.Size(90, 35);
            this.moveEndRollTxt.TabIndex = 1;
            this.moveEndRollTxt.Text = "0.3";
            // 
            // moveStartRollTxt
            // 
            this.moveStartRollTxt.Location = new System.Drawing.Point(388, 229);
            this.moveStartRollTxt.Name = "moveStartRollTxt";
            this.moveStartRollTxt.Size = new System.Drawing.Size(90, 35);
            this.moveStartRollTxt.TabIndex = 1;
            this.moveStartRollTxt.Text = "0.3";
            // 
            // moveEndYTxt
            // 
            this.moveEndYTxt.Location = new System.Drawing.Point(228, 332);
            this.moveEndYTxt.Name = "moveEndYTxt";
            this.moveEndYTxt.Size = new System.Drawing.Size(90, 35);
            this.moveEndYTxt.TabIndex = 1;
            this.moveEndYTxt.Text = "0.3";
            // 
            // moveStartYTxt
            // 
            this.moveStartYTxt.Location = new System.Drawing.Point(228, 188);
            this.moveStartYTxt.Name = "moveStartYTxt";
            this.moveStartYTxt.Size = new System.Drawing.Size(90, 35);
            this.moveStartYTxt.TabIndex = 1;
            this.moveStartYTxt.Text = "0.3";
            // 
            // moveEndYawTxt
            // 
            this.moveEndYawTxt.Location = new System.Drawing.Point(228, 373);
            this.moveEndYawTxt.Name = "moveEndYawTxt";
            this.moveEndYawTxt.Size = new System.Drawing.Size(90, 35);
            this.moveEndYawTxt.TabIndex = 1;
            this.moveEndYawTxt.Text = "0.3";
            // 
            // moveStartYawTxt
            // 
            this.moveStartYawTxt.Location = new System.Drawing.Point(228, 229);
            this.moveStartYawTxt.Name = "moveStartYawTxt";
            this.moveStartYawTxt.Size = new System.Drawing.Size(90, 35);
            this.moveStartYawTxt.TabIndex = 1;
            this.moveStartYawTxt.Text = "0.3";
            // 
            // moveEndXTxt
            // 
            this.moveEndXTxt.Location = new System.Drawing.Point(70, 332);
            this.moveEndXTxt.Name = "moveEndXTxt";
            this.moveEndXTxt.Size = new System.Drawing.Size(90, 35);
            this.moveEndXTxt.TabIndex = 1;
            this.moveEndXTxt.Text = "0.3";
            // 
            // moveStartXTxt
            // 
            this.moveStartXTxt.Location = new System.Drawing.Point(70, 188);
            this.moveStartXTxt.Name = "moveStartXTxt";
            this.moveStartXTxt.Size = new System.Drawing.Size(90, 35);
            this.moveStartXTxt.TabIndex = 1;
            this.moveStartXTxt.Text = "0.3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(324, 335);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "z";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(324, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "z";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moveEndPitchTxt
            // 
            this.moveEndPitchTxt.Location = new System.Drawing.Point(70, 373);
            this.moveEndPitchTxt.Name = "moveEndPitchTxt";
            this.moveEndPitchTxt.Size = new System.Drawing.Size(90, 35);
            this.moveEndPitchTxt.TabIndex = 1;
            this.moveEndPitchTxt.Text = "0.3";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(324, 376);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "Roll";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moveStartPitchTxt
            // 
            this.moveStartPitchTxt.Location = new System.Drawing.Point(70, 229);
            this.moveStartPitchTxt.Name = "moveStartPitchTxt";
            this.moveStartPitchTxt.Size = new System.Drawing.Size(90, 35);
            this.moveStartPitchTxt.TabIndex = 1;
            this.moveStartPitchTxt.Text = "0.3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(164, 335);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "y";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Roll";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "y";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(164, 376);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "Yaw";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moveDurationTxt
            // 
            this.moveDurationTxt.Location = new System.Drawing.Point(141, 49);
            this.moveDurationTxt.Name = "moveDurationTxt";
            this.moveDurationTxt.Size = new System.Drawing.Size(168, 35);
            this.moveDurationTxt.TabIndex = 1;
            this.moveDurationTxt.Text = "0.3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "x";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Yaw";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "End:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "x";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pan";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(6, 145);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(82, 24);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Start:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pan";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Duration(s)";
            // 
            // cameraTab
            // 
            this.cameraTab.Controls.Add(this.cameraWaitTxt);
            this.cameraTab.Controls.Add(this.label21);
            this.cameraTab.Controls.Add(this.cameraEndLoadBtn);
            this.cameraTab.Controls.Add(this.cameraStartLoadBtn);
            this.cameraTab.Controls.Add(this.cameraEndSetBtn);
            this.cameraTab.Controls.Add(this.cameraStartSetBtn);
            this.cameraTab.Controls.Add(this.label22);
            this.cameraTab.Controls.Add(this.label23);
            this.cameraTab.Controls.Add(this.cameraDurationTxt);
            this.cameraTab.Controls.Add(this.label24);
            this.cameraTab.Location = new System.Drawing.Point(419, 98);
            this.cameraTab.Name = "cameraTab";
            this.cameraTab.Size = new System.Drawing.Size(478, 426);
            this.cameraTab.TabIndex = 7;
            this.cameraTab.TabStop = false;
            this.cameraTab.Text = "Camera Movement";
            // 
            // cameraWaitTxt
            // 
            this.cameraWaitTxt.Location = new System.Drawing.Point(141, 90);
            this.cameraWaitTxt.Name = "cameraWaitTxt";
            this.cameraWaitTxt.Size = new System.Drawing.Size(168, 35);
            this.cameraWaitTxt.TabIndex = 6;
            this.cameraWaitTxt.Text = "0.3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(54, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 24);
            this.label21.TabIndex = 5;
            this.label21.Text = "Wait(s)";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cameraEndLoadBtn
            // 
            this.cameraEndLoadBtn.Location = new System.Drawing.Point(192, 199);
            this.cameraEndLoadBtn.Name = "cameraEndLoadBtn";
            this.cameraEndLoadBtn.Size = new System.Drawing.Size(104, 34);
            this.cameraEndLoadBtn.TabIndex = 3;
            this.cameraEndLoadBtn.Text = "Load";
            this.cameraEndLoadBtn.UseVisualStyleBackColor = true;
            this.cameraEndLoadBtn.Click += new System.EventHandler(this.cameraEndLoadBtn_Click);
            // 
            // cameraStartLoadBtn
            // 
            this.cameraStartLoadBtn.Location = new System.Drawing.Point(192, 156);
            this.cameraStartLoadBtn.Name = "cameraStartLoadBtn";
            this.cameraStartLoadBtn.Size = new System.Drawing.Size(104, 34);
            this.cameraStartLoadBtn.TabIndex = 3;
            this.cameraStartLoadBtn.Text = "Load";
            this.cameraStartLoadBtn.UseVisualStyleBackColor = true;
            this.cameraStartLoadBtn.Click += new System.EventHandler(this.cameraStartLoadBtn_Click);
            // 
            // cameraEndSetBtn
            // 
            this.cameraEndSetBtn.Location = new System.Drawing.Point(302, 198);
            this.cameraEndSetBtn.Name = "cameraEndSetBtn";
            this.cameraEndSetBtn.Size = new System.Drawing.Size(104, 34);
            this.cameraEndSetBtn.TabIndex = 3;
            this.cameraEndSetBtn.Text = "Set";
            this.cameraEndSetBtn.UseVisualStyleBackColor = true;
            this.cameraEndSetBtn.Click += new System.EventHandler(this.cameraEndSetBtn_Click);
            // 
            // cameraStartSetBtn
            // 
            this.cameraStartSetBtn.Location = new System.Drawing.Point(302, 155);
            this.cameraStartSetBtn.Name = "cameraStartSetBtn";
            this.cameraStartSetBtn.Size = new System.Drawing.Size(104, 34);
            this.cameraStartSetBtn.TabIndex = 3;
            this.cameraStartSetBtn.Text = "Set";
            this.cameraStartSetBtn.UseVisualStyleBackColor = true;
            this.cameraStartSetBtn.Click += new System.EventHandler(this.cameraStartSetBtn_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(32, 202);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(154, 24);
            this.label22.TabIndex = 2;
            this.label22.Text = "End Location";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 161);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(178, 24);
            this.label23.TabIndex = 2;
            this.label23.Text = "Start Location";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cameraDurationTxt
            // 
            this.cameraDurationTxt.Location = new System.Drawing.Point(141, 49);
            this.cameraDurationTxt.Name = "cameraDurationTxt";
            this.cameraDurationTxt.Size = new System.Drawing.Size(168, 35);
            this.cameraDurationTxt.TabIndex = 1;
            this.cameraDurationTxt.Text = "0.3";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(142, 24);
            this.label24.TabIndex = 0;
            this.label24.Text = "Duration(s)";
            // 
            // saveProjectBtn
            // 
            this.saveProjectBtn.Location = new System.Drawing.Point(37, 25);
            this.saveProjectBtn.Name = "saveProjectBtn";
            this.saveProjectBtn.Size = new System.Drawing.Size(194, 43);
            this.saveProjectBtn.TabIndex = 2;
            this.saveProjectBtn.Text = "Save Project";
            this.saveProjectBtn.UseVisualStyleBackColor = true;
            this.saveProjectBtn.Click += new System.EventHandler(this.saveProjectBtn_Click);
            // 
            // loadProjectBtn
            // 
            this.loadProjectBtn.Location = new System.Drawing.Point(237, 25);
            this.loadProjectBtn.Name = "loadProjectBtn";
            this.loadProjectBtn.Size = new System.Drawing.Size(210, 43);
            this.loadProjectBtn.TabIndex = 2;
            this.loadProjectBtn.Text = "Load Project";
            this.loadProjectBtn.UseVisualStyleBackColor = true;
            this.loadProjectBtn.Click += new System.EventHandler(this.loadProjectBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 615);
            this.Controls.Add(this.foldTab);
            this.Controls.Add(this.moveTab);
            this.Controls.Add(this.cameraTab);
            this.Controls.Add(this.videoOutputProgress);
            this.Controls.Add(this.loadProjectBtn);
            this.Controls.Add(this.saveProjectBtn);
            this.Controls.Add(this.videoOutputBtn);
            this.Controls.Add(this.downStepBtn);
            this.Controls.Add(this.upStepBtn);
            this.Controls.Add(this.delStepBtn);
            this.Controls.Add(this.newStepBtn);
            this.Controls.Add(this.stepListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Folding Animation Designer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.foldTab.ResumeLayout(false);
            this.foldTab.PerformLayout();
            this.moveTab.ResumeLayout(false);
            this.moveTab.PerformLayout();
            this.cameraTab.ResumeLayout(false);
            this.cameraTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox stepListBox;
        private System.Windows.Forms.Button newStepBtn;
        private System.Windows.Forms.GroupBox foldTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox foldEndTxt;
        private System.Windows.Forms.TextBox foldStartTxt;
        private System.Windows.Forms.TextBox foldDurationTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button foldSetEndBtn;
        private System.Windows.Forms.Button foldSetStartBtn;
        private System.Windows.Forms.Button videoOutputBtn;
        private System.Windows.Forms.CheckBox foldRepeatChk;
        private System.Windows.Forms.TextBox foldWaitTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar videoOutputProgress;
        private System.Windows.Forms.Button delStepBtn;
        private System.Windows.Forms.Button upStepBtn;
        private System.Windows.Forms.Button downStepBtn;
        private System.Windows.Forms.GroupBox moveTab;
        private System.Windows.Forms.TextBox moveWaitTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox moveStartRollTxt;
        private System.Windows.Forms.TextBox moveStartYawTxt;
        private System.Windows.Forms.TextBox moveStartPitchTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox moveDurationTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button moveStartSetBtn;
        private System.Windows.Forms.TextBox moveStartZTxt;
        private System.Windows.Forms.TextBox moveStartYTxt;
        private System.Windows.Forms.TextBox moveStartXTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button moveEndSetBtn;
        private System.Windows.Forms.Button moveEndLoadBtn;
        private System.Windows.Forms.TextBox moveEndZTxt;
        private System.Windows.Forms.TextBox moveEndRollTxt;
        private System.Windows.Forms.TextBox moveEndYTxt;
        private System.Windows.Forms.TextBox moveEndYawTxt;
        private System.Windows.Forms.TextBox moveEndXTxt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox moveEndPitchTxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button moveStartLoadBtn;
        private System.Windows.Forms.GroupBox cameraTab;
        private System.Windows.Forms.TextBox cameraWaitTxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button cameraEndLoadBtn;
        private System.Windows.Forms.Button cameraStartLoadBtn;
        private System.Windows.Forms.Button cameraEndSetBtn;
        private System.Windows.Forms.Button cameraStartSetBtn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox cameraDurationTxt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button saveProjectBtn;
        private System.Windows.Forms.Button loadProjectBtn;
    }
}

