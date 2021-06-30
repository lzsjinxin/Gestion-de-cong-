
namespace Gestion_de_congé
{
    partial class conge_deets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.deets_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbr_jours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_retour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.deets_table)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // deets_table
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("EPSON ëæñæí©ëÃÇa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deets_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.deets_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deets_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deets_table.BackgroundColor = System.Drawing.Color.White;
            this.deets_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deets_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Benguiat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deets_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.deets_table.ColumnHeadersHeight = 48;
            this.deets_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.login,
            this.date_debut,
            this.date_fin,
            this.nbr_jours,
            this.date_retour,
            this.type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deets_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.deets_table.EnableHeadersVisualStyles = false;
            this.deets_table.GridColor = System.Drawing.Color.Black;
            this.deets_table.Location = new System.Drawing.Point(12, 42);
            this.deets_table.Name = "deets_table";
            this.deets_table.ReadOnly = true;
            this.deets_table.RowHeadersVisible = false;
            this.deets_table.RowHeadersWidth = 62;
            this.deets_table.RowTemplate.Height = 28;
            this.deets_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deets_table.Size = new System.Drawing.Size(1256, 343);
            this.deets_table.TabIndex = 5;
            this.deets_table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.deets_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Gray;
            this.deets_table.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("EPSON ëæñæí©ëÃÇa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deets_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.deets_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.deets_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.deets_table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.deets_table.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.deets_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DimGray;
            this.deets_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.deets_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Benguiat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deets_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.deets_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.deets_table.ThemeStyle.HeaderStyle.Height = 48;
            this.deets_table.ThemeStyle.ReadOnly = true;
            this.deets_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.deets_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.deets_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.deets_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.deets_table.ThemeStyle.RowsStyle.Height = 28;
            this.deets_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.deets_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // login
            // 
            this.login.HeaderText = "Login";
            this.login.MinimumWidth = 8;
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // date_debut
            // 
            this.date_debut.HeaderText = "Date debut";
            this.date_debut.MinimumWidth = 8;
            this.date_debut.Name = "date_debut";
            this.date_debut.ReadOnly = true;
            // 
            // date_fin
            // 
            this.date_fin.HeaderText = "Date fin";
            this.date_fin.MinimumWidth = 8;
            this.date_fin.Name = "date_fin";
            this.date_fin.ReadOnly = true;
            // 
            // nbr_jours
            // 
            this.nbr_jours.HeaderText = "Nbr des jours";
            this.nbr_jours.MinimumWidth = 8;
            this.nbr_jours.Name = "nbr_jours";
            this.nbr_jours.ReadOnly = true;
            // 
            // date_retour
            // 
            this.date_retour.HeaderText = "Date retour";
            this.date_retour.MinimumWidth = 8;
            this.date_retour.Name = "date_retour";
            this.date_retour.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // quit
            // 
            this.quit.Animated = true;
            this.quit.AutoRoundedCorners = true;
            this.quit.BorderRadius = 16;
            this.quit.CheckedState.Parent = this.quit;
            this.quit.CustomImages.Parent = this.quit;
            this.quit.FillColor = System.Drawing.Color.Gray;
            this.quit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quit.ForeColor = System.Drawing.Color.White;
            this.quit.HoverState.Parent = this.quit;
            this.quit.Image = global::Gestion_de_congé.Properties.Resources.close_circled;
            this.quit.Location = new System.Drawing.Point(12, 2);
            this.quit.Name = "quit";
            this.quit.ShadowDecoration.Parent = this.quit;
            this.quit.Size = new System.Drawing.Size(58, 34);
            this.quit.TabIndex = 6;
            this.quit.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // conge_deets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 386);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.deets_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conge_deets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conge";
            this.Activated += new System.EventHandler(this.conge_deets_Activated);
            this.Load += new System.EventHandler(this.conge_deets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deets_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button quit;
        private Guna.UI2.WinForms.Guna2DataGridView deets_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbr_jours;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_retour;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}