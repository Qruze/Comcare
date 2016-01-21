namespace Comcare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dTP_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new Comcare.Models.DataSet1();
            this.lbl_MainProject = new System.Windows.Forms.Label();
            this.lbl_CreateMainProject = new System.Windows.Forms.Label();
            this.txtBox_NewProjectName = new System.Windows.Forms.TextBox();
            this.lbl_MainProjectName = new System.Windows.Forms.Label();
            this.btn_CreateMainProject = new System.Windows.Forms.Button();
            this.lbl_MainProjectStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKMainProjectsPartProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Debug = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.mainProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainProjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlyWorkDaysDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMainProjectsPartProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partProjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dTP_StartDate
            // 
            this.dTP_StartDate.Location = new System.Drawing.Point(329, 512);
            this.dTP_StartDate.Name = "dTP_StartDate";
            this.dTP_StartDate.Size = new System.Drawing.Size(167, 20);
            this.dTP_StartDate.TabIndex = 0;
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(326, 496);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_StartDate.TabIndex = 1;
            this.lbl_StartDate.Text = "Start Date";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(58, 512);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(155, 37);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.mainProjectsBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Id";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_MainProject
            // 
            this.lbl_MainProject.AutoSize = true;
            this.lbl_MainProject.Location = new System.Drawing.Point(63, 41);
            this.lbl_MainProject.Name = "lbl_MainProject";
            this.lbl_MainProject.Size = new System.Drawing.Size(63, 13);
            this.lbl_MainProject.TabIndex = 4;
            this.lbl_MainProject.Text = "MainProject";
            // 
            // lbl_CreateMainProject
            // 
            this.lbl_CreateMainProject.AutoSize = true;
            this.lbl_CreateMainProject.Location = new System.Drawing.Point(682, 104);
            this.lbl_CreateMainProject.Name = "lbl_CreateMainProject";
            this.lbl_CreateMainProject.Size = new System.Drawing.Size(94, 13);
            this.lbl_CreateMainProject.TabIndex = 5;
            this.lbl_CreateMainProject.Text = "CreateMainProject";
            // 
            // txtBox_NewProjectName
            // 
            this.txtBox_NewProjectName.Location = new System.Drawing.Point(685, 60);
            this.txtBox_NewProjectName.Name = "txtBox_NewProjectName";
            this.txtBox_NewProjectName.Size = new System.Drawing.Size(114, 20);
            this.txtBox_NewProjectName.TabIndex = 6;
            // 
            // lbl_MainProjectName
            // 
            this.lbl_MainProjectName.AutoSize = true;
            this.lbl_MainProjectName.Location = new System.Drawing.Point(682, 43);
            this.lbl_MainProjectName.Name = "lbl_MainProjectName";
            this.lbl_MainProjectName.Size = new System.Drawing.Size(94, 13);
            this.lbl_MainProjectName.TabIndex = 7;
            this.lbl_MainProjectName.Text = "MainProject Name";
            // 
            // btn_CreateMainProject
            // 
            this.btn_CreateMainProject.Location = new System.Drawing.Point(685, 121);
            this.btn_CreateMainProject.Name = "btn_CreateMainProject";
            this.btn_CreateMainProject.Size = new System.Drawing.Size(158, 20);
            this.btn_CreateMainProject.TabIndex = 8;
            this.btn_CreateMainProject.Text = "Create main project";
            this.btn_CreateMainProject.UseVisualStyleBackColor = true;
            this.btn_CreateMainProject.Click += new System.EventHandler(this.btn_CreateMainProject_Click);
            // 
            // lbl_MainProjectStatus
            // 
            this.lbl_MainProjectStatus.AutoSize = true;
            this.lbl_MainProjectStatus.Location = new System.Drawing.Point(866, 54);
            this.lbl_MainProjectStatus.Name = "lbl_MainProjectStatus";
            this.lbl_MainProjectStatus.Size = new System.Drawing.Size(0, 13);
            this.lbl_MainProjectStatus.TabIndex = 9;
            this.lbl_MainProjectStatus.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EndDate,
            this.idDataGridViewTextBoxColumn,
            this.mainProjectIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.onlyWorkDaysDataGridViewCheckBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fKMainProjectsPartProjectsBindingSource, "Name", true));
            this.dataGridView1.DataSource = this.partProjectsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 319);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 74;
            // 
            // fKMainProjectsPartProjectsBindingSource
            // 
            this.fKMainProjectsPartProjectsBindingSource.DataMember = "FK_MainProjects_PartProjects";
            // 
            // lbl_Debug
            // 
            this.lbl_Debug.AutoSize = true;
            this.lbl_Debug.Location = new System.Drawing.Point(717, 238);
            this.lbl_Debug.Name = "lbl_Debug";
            this.lbl_Debug.Size = new System.Drawing.Size(0, 13);
            this.lbl_Debug.TabIndex = 11;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(718, 241);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(134, 91);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // mainProjectsBindingSource
            // 
            this.mainProjectsBindingSource.DataMember = "MainProjects";
            this.mainProjectsBindingSource.DataSource = this.dataSet1;
            // 
            // partProjectsBindingSource
            // 
            this.partProjectsBindingSource.DataMember = "PartProjects";
            this.partProjectsBindingSource.DataSource = this.dataSet1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // mainProjectIdDataGridViewTextBoxColumn
            // 
            this.mainProjectIdDataGridViewTextBoxColumn.DataPropertyName = "MainProjectId";
            this.mainProjectIdDataGridViewTextBoxColumn.HeaderText = "MainProjectId";
            this.mainProjectIdDataGridViewTextBoxColumn.Name = "mainProjectIdDataGridViewTextBoxColumn";
            this.mainProjectIdDataGridViewTextBoxColumn.Width = 97;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 77;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.Width = 65;
            // 
            // onlyWorkDaysDataGridViewCheckBoxColumn
            // 
            this.onlyWorkDaysDataGridViewCheckBoxColumn.DataPropertyName = "OnlyWorkDays";
            this.onlyWorkDaysDataGridViewCheckBoxColumn.HeaderText = "OnlyWorkDays";
            this.onlyWorkDaysDataGridViewCheckBoxColumn.Name = "onlyWorkDaysDataGridViewCheckBoxColumn";
            this.onlyWorkDaysDataGridViewCheckBoxColumn.Width = 84;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 74;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Debug);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_MainProjectStatus);
            this.Controls.Add(this.btn_CreateMainProject);
            this.Controls.Add(this.lbl_MainProjectName);
            this.Controls.Add(this.txtBox_NewProjectName);
            this.Controls.Add(this.lbl_CreateMainProject);
            this.Controls.Add(this.lbl_MainProject);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.lbl_StartDate);
            this.Controls.Add(this.dTP_StartDate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMainProjectsPartProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partProjectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTP_StartDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.ComboBox comboBox1;
        private Models.DataSet1 dataSet1;
        private System.Windows.Forms.Label lbl_MainProject;
        private System.Windows.Forms.Label lbl_CreateMainProject;
        private System.Windows.Forms.TextBox txtBox_NewProjectName;
        private System.Windows.Forms.Label lbl_MainProjectName;
        private System.Windows.Forms.Button btn_CreateMainProject;
        private System.Windows.Forms.Label lbl_MainProjectStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKMainProjectsPartProjectsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.Label lbl_Debug;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.BindingSource mainProjectsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainProjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onlyWorkDaysDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partProjectsBindingSource;
    }
}

