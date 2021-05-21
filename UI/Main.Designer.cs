namespace UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.listDataGridView = new System.Windows.Forms.DataGridView();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exam1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exam2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exam3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Certificate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contract = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.passedCountInput = new System.Windows.Forms.NumericUpDown();
            this.passedCountLabel = new System.Windows.Forms.Label();
            this.minRatingLabel = new System.Windows.Forms.Label();
            this.minRatingInput = new System.Windows.Forms.NumericUpDown();
            this.exam1CInput = new System.Windows.Forms.NumericUpDown();
            this.exam2CInput = new System.Windows.Forms.NumericUpDown();
            this.exam3CInput = new System.Windows.Forms.NumericUpDown();
            this.certificateCInput = new System.Windows.Forms.NumericUpDown();
            this.recalculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.listDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.passedCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.minRatingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.exam1CInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.exam2CInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.exam3CInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.certificateCInput)).BeginInit();
            this.SuspendLayout();
            // 
            // listDataGridView
            // 
            this.listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Info, this.Exam1, this.Exam2, this.Exam3, this.Certificate, this.Contract, this.BirthDate, this.Rating});
            this.listDataGridView.Location = new System.Drawing.Point(12, 12);
            this.listDataGridView.Name = "listDataGridView";
            this.listDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.listDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.listDataGridView.Size = new System.Drawing.Size(643, 426);
            this.listDataGridView.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.Width = 200;
            // 
            // Exam1
            // 
            this.Exam1.HeaderText = "Exam1";
            this.Exam1.Name = "Exam1";
            this.Exam1.Width = 40;
            // 
            // Exam2
            // 
            this.Exam2.HeaderText = "Exam2";
            this.Exam2.Name = "Exam2";
            this.Exam2.Width = 40;
            // 
            // Exam3
            // 
            this.Exam3.HeaderText = "Exam3";
            this.Exam3.Name = "Exam3";
            this.Exam3.Width = 40;
            // 
            // Certificate
            // 
            this.Certificate.HeaderText = "Certificate";
            this.Certificate.Name = "Certificate";
            this.Certificate.Width = 40;
            // 
            // Contract
            // 
            this.Contract.HeaderText = "Contract";
            this.Contract.Name = "Contract";
            this.Contract.Width = 20;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BirthDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 70;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(661, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(202, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(661, 41);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(202, 23);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Show and Export Lists";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // passedCountInput
            // 
            this.passedCountInput.Location = new System.Drawing.Point(661, 87);
            this.passedCountInput.Name = "passedCountInput";
            this.passedCountInput.Size = new System.Drawing.Size(202, 20);
            this.passedCountInput.TabIndex = 3;
            // 
            // passedCountLabel
            // 
            this.passedCountLabel.Location = new System.Drawing.Point(661, 71);
            this.passedCountLabel.Name = "passedCountLabel";
            this.passedCountLabel.Size = new System.Drawing.Size(202, 13);
            this.passedCountLabel.TabIndex = 4;
            this.passedCountLabel.Text = "Number to Pass";
            // 
            // minRatingLabel
            // 
            this.minRatingLabel.Location = new System.Drawing.Point(661, 126);
            this.minRatingLabel.Name = "minRatingLabel";
            this.minRatingLabel.Size = new System.Drawing.Size(202, 13);
            this.minRatingLabel.TabIndex = 6;
            this.minRatingLabel.Text = "Minimum rating";
            // 
            // minRatingInput
            // 
            this.minRatingInput.DecimalPlaces = 1;
            this.minRatingInput.Location = new System.Drawing.Point(661, 142);
            this.minRatingInput.Maximum = new decimal(new int[] {200, 0, 0, 0});
            this.minRatingInput.Name = "minRatingInput";
            this.minRatingInput.Size = new System.Drawing.Size(202, 20);
            this.minRatingInput.TabIndex = 5;
            this.minRatingInput.Value = new decimal(new int[] {150, 0, 0, 0});
            // 
            // exam1CInput
            // 
            this.exam1CInput.DecimalPlaces = 1;
            this.exam1CInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.exam1CInput.Location = new System.Drawing.Point(661, 168);
            this.exam1CInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.exam1CInput.Name = "exam1CInput";
            this.exam1CInput.Size = new System.Drawing.Size(46, 20);
            this.exam1CInput.TabIndex = 7;
            this.exam1CInput.Value = new decimal(new int[] {5, 0, 0, 65536});
            // 
            // exam2CInput
            // 
            this.exam2CInput.DecimalPlaces = 1;
            this.exam2CInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.exam2CInput.Location = new System.Drawing.Point(713, 168);
            this.exam2CInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.exam2CInput.Name = "exam2CInput";
            this.exam2CInput.Size = new System.Drawing.Size(46, 20);
            this.exam2CInput.TabIndex = 8;
            this.exam2CInput.Value = new decimal(new int[] {2, 0, 0, 65536});
            // 
            // exam3CInput
            // 
            this.exam3CInput.DecimalPlaces = 1;
            this.exam3CInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.exam3CInput.Location = new System.Drawing.Point(765, 168);
            this.exam3CInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.exam3CInput.Name = "exam3CInput";
            this.exam3CInput.Size = new System.Drawing.Size(46, 20);
            this.exam3CInput.TabIndex = 9;
            this.exam3CInput.Value = new decimal(new int[] {2, 0, 0, 65536});
            // 
            // certificateCInput
            // 
            this.certificateCInput.DecimalPlaces = 1;
            this.certificateCInput.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.certificateCInput.Location = new System.Drawing.Point(817, 168);
            this.certificateCInput.Maximum = new decimal(new int[] {1, 0, 0, 0});
            this.certificateCInput.Name = "certificateCInput";
            this.certificateCInput.Size = new System.Drawing.Size(46, 20);
            this.certificateCInput.TabIndex = 10;
            this.certificateCInput.Value = new decimal(new int[] {1, 0, 0, 65536});
            // 
            // recalculateButton
            // 
            this.recalculateButton.Location = new System.Drawing.Point(661, 195);
            this.recalculateButton.Name = "recalculateButton";
            this.recalculateButton.Size = new System.Drawing.Size(201, 24);
            this.recalculateButton.TabIndex = 11;
            this.recalculateButton.Text = "Recalculate";
            this.recalculateButton.UseVisualStyleBackColor = true;
            this.recalculateButton.Click += new System.EventHandler(this.recalculateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.recalculateButton);
            this.Controls.Add(this.certificateCInput);
            this.Controls.Add(this.exam3CInput);
            this.Controls.Add(this.exam2CInput);
            this.Controls.Add(this.exam1CInput);
            this.Controls.Add(this.minRatingLabel);
            this.Controls.Add(this.minRatingInput);
            this.Controls.Add(this.passedCountLabel);
            this.Controls.Add(this.passedCountInput);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listDataGridView);
            this.Name = "MainForm";
            this.Text = "Dmytro Vasyliev - OOP Course";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize) (this.listDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.passedCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.minRatingInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.exam1CInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.exam2CInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.exam3CInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.certificateCInput)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button recalculateButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;

        private System.Windows.Forms.NumericUpDown exam3CInput;

        private System.Windows.Forms.NumericUpDown certificateCInput;

        private System.Windows.Forms.Label passedCountLabel;
        private System.Windows.Forms.NumericUpDown passedCountInput;
        private System.Windows.Forms.Label minRatingLabel;
        private System.Windows.Forms.NumericUpDown minRatingInput;
        private System.Windows.Forms.NumericUpDown exam1CInput;
        private System.Windows.Forms.NumericUpDown exam2CInput;

        private System.Windows.Forms.DataGridViewTextBoxColumn Certificate;

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button processButton;

        private System.Windows.Forms.DataGridView listDataGridView;

        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;

        #endregion
    }
}