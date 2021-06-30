
namespace Gestion_de_congé
{
    partial class conge_demandé
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
            this.deets_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbr_jours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_retour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accepter = new Guna.UI2.WinForms.Guna2Button();
            this.refuser = new Guna.UI2.WinForms.Guna2Button();
            this.type_text = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.TextBox();
            this.date_fin_text = new System.Windows.Forms.TextBox();
            this.date_debut_text = new System.Windows.Forms.TextBox();
            this.nbr_jour_text = new System.Windows.Forms.TextBox();
            this.date_retour_text = new System.Windows.Forms.TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Back = new Guna.UI2.WinForms.Guna2Button();
            this.quit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.deets_table)).BeginInit();
            this.SuspendLayout();
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
            this.nom,
            this.prenom,
            this.date_debut,
            this.date_fin,
            this.nbr_jours,
            this.date_retour,
            this.type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deets_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.deets_table.EnableHeadersVisualStyles = false;
            this.deets_table.GridColor = System.Drawing.Color.Black;
            this.deets_table.Location = new System.Drawing.Point(12, 12);
            this.deets_table.Name = "deets_table";
            this.deets_table.ReadOnly = true;
            this.deets_table.RowHeadersVisible = false;
            this.deets_table.RowHeadersWidth = 62;
            this.deets_table.RowTemplate.Height = 28;
            this.deets_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deets_table.Size = new System.Drawing.Size(1097, 385);
            this.deets_table.TabIndex = 7;
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
            this.deets_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deets_table.ThemeStyle.RowsStyle.Height = 28;
            this.deets_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
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
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 8;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.MinimumWidth = 8;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
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
            // accepter
            // 
            this.accepter.CheckedState.Parent = this.accepter;
            this.accepter.CustomImages.Parent = this.accepter;
            this.accepter.FillColor = System.Drawing.Color.Gray;
            this.accepter.Font = new System.Drawing.Font("Benguiat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accepter.ForeColor = System.Drawing.Color.White;
            this.accepter.HoverState.Parent = this.accepter;
            this.accepter.Location = new System.Drawing.Point(389, 435);
            this.accepter.Name = "accepter";
            this.accepter.ShadowDecoration.Parent = this.accepter;
            this.accepter.Size = new System.Drawing.Size(180, 45);
            this.accepter.TabIndex = 9;
            this.accepter.Text = "Accepter";
            this.accepter.Click += new System.EventHandler(this.accepter_Click);
            // 
            // refuser
            // 
            this.refuser.CheckedState.Parent = this.refuser;
            this.refuser.CustomImages.Parent = this.refuser;
            this.refuser.FillColor = System.Drawing.Color.Gray;
            this.refuser.Font = new System.Drawing.Font("Benguiat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refuser.ForeColor = System.Drawing.Color.White;
            this.refuser.HoverState.Parent = this.refuser;
            this.refuser.Location = new System.Drawing.Point(625, 435);
            this.refuser.Name = "refuser";
            this.refuser.ShadowDecoration.Parent = this.refuser;
            this.refuser.Size = new System.Drawing.Size(180, 45);
            this.refuser.TabIndex = 10;
            this.refuser.Text = "Refuser";
            this.refuser.Click += new System.EventHandler(this.refuser_Click);
            // 
            // type_text
            // 
            this.type_text.Location = new System.Drawing.Point(859, 403);
            this.type_text.Name = "type_text";
            this.type_text.Size = new System.Drawing.Size(62, 26);
            this.type_text.TabIndex = 11;
            this.type_text.Visible = false;
            // 
            // login_text
            // 
            this.login_text.Location = new System.Drawing.Point(859, 435);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(62, 26);
            this.login_text.TabIndex = 12;
            this.login_text.Visible = false;
            // 
            // date_fin_text
            // 
            this.date_fin_text.Location = new System.Drawing.Point(927, 435);
            this.date_fin_text.Name = "date_fin_text";
            this.date_fin_text.Size = new System.Drawing.Size(69, 26);
            this.date_fin_text.TabIndex = 14;
            this.date_fin_text.Visible = false;
            // 
            // date_debut_text
            // 
            this.date_debut_text.Location = new System.Drawing.Point(927, 403);
            this.date_debut_text.Name = "date_debut_text";
            this.date_debut_text.Size = new System.Drawing.Size(69, 26);
            this.date_debut_text.TabIndex = 13;
            this.date_debut_text.Visible = false;
            // 
            // nbr_jour_text
            // 
            this.nbr_jour_text.Location = new System.Drawing.Point(1002, 435);
            this.nbr_jour_text.Name = "nbr_jour_text";
            this.nbr_jour_text.Size = new System.Drawing.Size(75, 26);
            this.nbr_jour_text.TabIndex = 16;
            this.nbr_jour_text.Visible = false;
            // 
            // date_retour_text
            // 
            this.date_retour_text.Location = new System.Drawing.Point(1002, 403);
            this.date_retour_text.Name = "date_retour_text";
            this.date_retour_text.Size = new System.Drawing.Size(75, 26);
            this.date_retour_text.TabIndex = 15;
            this.date_retour_text.Visible = false;
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
            this.Back.FillColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.HoverState.Parent = this.Back;
            this.Back.Image = global::Gestion_de_congé.Properties.Resources.android_arrow_back;
            this.Back.Location = new System.Drawing.Point(-3, 435);
            this.Back.Name = "Back";
            this.Back.ShadowDecoration.Parent = this.Back;
            this.Back.Size = new System.Drawing.Size(55, 45);
            this.Back.TabIndex = 17;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // quit
            // 
            this.quit.Animated = true;
            this.quit.AutoRoundedCorners = true;
            this.quit.BorderRadius = 16;
            this.quit.CheckedState.Parent = this.quit;
            this.quit.CustomImages.Parent = this.quit;
            this.quit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            this.quit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quit.ForeColor = System.Drawing.Color.White;
            this.quit.HoverState.Parent = this.quit;
            this.quit.Image = global::Gestion_de_congé.Properties.Resources.close_circled;
            this.quit.Location = new System.Drawing.Point(-228, 34);
            this.quit.Name = "quit";
            this.quit.ShadowDecoration.Parent = this.quit;
            this.quit.Size = new System.Drawing.Size(58, 34);
            this.quit.TabIndex = 8;
            // 
            // conge_demandé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1121, 492);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.nbr_jour_text);
            this.Controls.Add(this.date_retour_text);
            this.Controls.Add(this.date_fin_text);
            this.Controls.Add(this.date_debut_text);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.type_text);
            this.Controls.Add(this.refuser);
            this.Controls.Add(this.accepter);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.deets_table);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conge_demandé";
            this.Text = "conge_demandé";
            this.Activated += new System.EventHandler(this.conge_demandé_Activated);
            this.Load += new System.EventHandler(this.conge_demandé_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deets_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button quit;
        private Guna.UI2.WinForms.Guna2DataGridView deets_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbr_jours;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_retour;
        private Guna.UI2.WinForms.Guna2Button accepter;
        private Guna.UI2.WinForms.Guna2Button refuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.TextBox type_text;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.TextBox date_fin_text;
        private System.Windows.Forms.TextBox date_debut_text;
        private System.Windows.Forms.TextBox nbr_jour_text;
        private System.Windows.Forms.TextBox date_retour_text;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button Back;
    }
}