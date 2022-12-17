namespace kk
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("вфвыфы", System.Windows.Forms.HorizontalAlignment.Right);
            this.list1 = new System.Windows.Forms.ListView();
            this.МЕМ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ГОД = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.НАЗВАНИЕ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.МЕМ1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list1
            // 
            this.list1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.list1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list1.AllowColumnReorder = true;
            this.list1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.list1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.МЕМ,
            this.ГОД,
            this.НАЗВАНИЕ,
            this.МЕМ1});
            this.list1.ForeColor = System.Drawing.Color.White;
            listViewGroup1.Header = "вфвыфы";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup1.Tag = "выф";
            this.list1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.list1.Location = new System.Drawing.Point(-1, -3);
            this.list1.MultiSelect = false;
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(498, 582);
            this.list1.TabIndex = 0;
            this.list1.UseCompatibleStateImageBehavior = false;
            this.list1.View = System.Windows.Forms.View.Details;
            this.list1.SelectedIndexChanged += new System.EventHandler(this.list1_SelectedIndexChanged);
            // 
            // МЕМ
            // 
            this.МЕМ.Text = "МЕМ";
            this.МЕМ.Width = 256;
            // 
            // ГОД
            // 
            this.ГОД.Text = "ГОД";
            this.ГОД.Width = 50;
            // 
            // НАЗВАНИЕ
            // 
            this.НАЗВАНИЕ.Text = "НАЗВАНИЕ";
            this.НАЗВАНИЕ.Width = 140;
            // 
            // МЕМ1
            // 
            this.МЕМ1.Text = "МЕМ";
            this.МЕМ1.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(496, 577);
            this.Controls.Add(this.list1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list1;
        private System.Windows.Forms.ColumnHeader МЕМ;
        private System.Windows.Forms.ColumnHeader ГОД;
        private System.Windows.Forms.ColumnHeader НАЗВАНИЕ;
        private System.Windows.Forms.ColumnHeader МЕМ1;
    }
}

