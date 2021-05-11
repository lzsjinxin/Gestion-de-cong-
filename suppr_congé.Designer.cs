
namespace Gestion_de_congé
{
    partial class suppr_congé
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
            this.supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Back = new Guna.UI2.WinForms.Guna2Button();
            this.deets_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbr_jours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_retour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbr_jour_text = new System.Windows.Forms.TextBox();
            this.date_retour_text = new System.Windows.Forms.TextBox();
            this.date_fin_text = new System.Windows.Forms.TextBox();
            this.date_debut_text = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.TextBox();
            this.type_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deets_table)).BeginInit();
            this.SuspendLayout();
            // 
            // supprimer
            // 
            this.supprimer.Animated = true;
            this.supprimer.AutoRoundedCorners = true;
            this.supprimer.BorderRadius = 21;
            this.supprimer.CheckedState.Parent = this.supprimer;
            this.supprimer.CustomImages.Parent = this.supprimer;
            this.supprimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            this.supprimer.Font = new System.Drawing.Font("Benguiat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.HoverState.Parent = this.supprimer;
            this.supprimer.Image = global::Gestion_de_congé.Properties.Resources.trash_b;
            this.supprimer.ImageSize = new System.Drawing.Size(30, 30);
            this.supprimer.Location = new System.Drawing.Point(446, 371);
            this.supprimer.Name = "supprimer";
            this.supprimer.ShadowDecoration.Parent = this.supprimer;
            this.supprimer.Size = new System.Drawing.Size(180, 45);
            this.supprimer.TabIndex = 4;
            this.supprimer.Text = "Supprimer";
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // Back
            // 
            this.Back.Animated = true;
            this.Back.AutoRoundedCorners = true;
            this.Back.BorderRadius = 21;
            this.Back.CheckedState.Parent = this.Back;
            this.Back.CustomImages.Parent = this.Back;
            this.Back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            this.Back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.HoverState.Parent = this.Back;
            this.Back.Image = global::Gestion_de_congé.Properties.Resources.android_arrow_back;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.ShadowDecoration.Parent = this.Back;
            this.Back.Size = new System.Drawing.Size(55, 45);
            this.Back.TabIndex = 8;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // deets_table
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("EPSON ëæñæí©ëÃÇa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deets_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.deets_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deets_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deets_table.BackgroundColor = System.Drawing.Color.White;
            this.deets_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deets_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.deets_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deets_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.deets_table.EnableHeadersVisualStyles = false;
            this.deets_table.GridColor = System.Drawing.Color.Black;
            this.deets_table.Location = new System.Drawing.Point(83, 46);
            this.deets_table.Name = "deets_table";
            this.deets_table.ReadOnly = true;
            this.deets_table.RowHeadersVisible = false;
            this.deets_table.RowHeadersWidth = 62;
            this.deets_table.RowTemplate.Height = 28;
            this.deets_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deets_table.Size = new System.Drawing.Size(919, 319);
            this.deets_table.TabIndex = 9;
            this.deets_table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            this.deets_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            this.deets_table.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("EPSON ëæñæí©ëÃÇa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deets_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.deets_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.deets_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.deets_table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.deets_table.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.deets_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.deets_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.deets_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Benguiat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deets_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.deets_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.deets_table.ThemeStyle.HeaderStyle.Height = 48;
            this.deets_table.ThemeStyle.ReadOnly = true;
            this.deets_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.deets_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.deets_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.deets_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.deets_table.ThemeStyle.RowsStyle.Height = 28;
            this.deets_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deets_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.deets_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deets_table_CellClick);
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
            // nbr_jour_text
            // 
            this.nbr_jour_text.Location = new System.Drawing.Point(217, 422);
            this.nbr_jour_text.Name = "nbr_jour_text";
            this.nbr_jour_text.Size = new System.Drawing.Size(75, 26);
            this.nbr_jour_text.TabIndex = 22;
            this.nbr_jour_text.Visible = false;
            // 
            // date_retour_text
            // 
            this.date_retour_text.Location = new System.Drawing.Point(217, 390);
            this.date_retour_text.Name = "date_retour_text";
            this.date_retour_text.Size = new System.Drawing.Size(75, 26);
            this.date_retour_text.TabIndex = 21;
            this.date_retour_text.Visible = false;
            // 
            // date_fin_text
            // 
            this.date_fin_text.Location = new System.Drawing.Point(142, 422);
            this.date_fin_text.Name = "date_fin_text";
            this.date_fin_text.Size = new System.Drawing.Size(69, 26);
            this.date_fin_text.TabIndex = 20;
            this.date_fin_text.Visible = false;
            // 
            // date_debut_text
            // 
            this.date_debut_text.Location = new System.Drawing.Point(142, 390);
            this.date_debut_text.Name = "date_debut_text";
            this.date_debut_text.Size = new System.Drawing.Size(69, 26);
            this.date_debut_text.TabIndex = 19;
            this.date_debut_text.Visible = false;
            // 
            // login_text
            // 
            this.login_text.Location = new System.Drawing.Point(74, 422);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(62, 26);
            this.login_text.TabIndex = 18;
            this.login_text.Visible = false;
            // 
            // type_text
            // 
            this.type_text.Location = new System.Drawing.Point(74, 390);
            this.type_text.Name = "type_text";
            this.type_text.Size = new System.Drawing.Size(62, 26);
            this.type_text.TabIndex = 17;
            this.type_text.Visible = false;
            // 
            // suppr_congé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 452);
            this.Controls.Add(this.nbr_jour_text);
            this.Controls.Add(this.date_retour_text);
            this.Controls.Add(this.date_fin_text);
            this.Controls.Add(this.date_debut_text);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.type_text);
            this.Controls.Add(this.deets_table);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.supprimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "suppr_congé";
            this.Text = "suppr_congé";
            this.Activated += new System.EventHandler(this.suppr_congé_Activated);
            this.Load += new System.EventHandler(this.suppr_congé_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deets_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button supprimer;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button Back;
        private Guna.UI2.WinForms.Guna2DataGridView deets_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbr_jours;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_retour;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.TextBox nbr_jour_text;
        private System.Windows.Forms.TextBox date_retour_text;
        private System.Windows.Forms.TextBox date_fin_text;
        private System.Windows.Forms.TextBox date_debut_text;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.TextBox type_text;
    }
}