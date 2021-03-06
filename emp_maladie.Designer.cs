
namespace Gestion_de_congé
{
    partial class emp_maladie
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
            this.date_debut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Demander = new Guna.UI2.WinForms.Guna2Button();
            this.nombre_des_jours = new Guna.UI2.WinForms.Guna2TextBox();
            this.date_retour = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date_fin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.quitter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_debut
            // 
            this.date_debut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.date_debut.CheckedState.Parent = this.date_debut;
            this.date_debut.FillColor = System.Drawing.Color.Gray;
            this.date_debut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_debut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_debut.HoverState.Parent = this.date_debut;
            this.date_debut.Location = new System.Drawing.Point(27, 84);
            this.date_debut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_debut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_debut.Name = "date_debut";
            this.date_debut.ShadowDecoration.Parent = this.date_debut;
            this.date_debut.Size = new System.Drawing.Size(185, 36);
            this.date_debut.TabIndex = 0;
            this.date_debut.Value = new System.DateTime(2021, 4, 21, 15, 45, 54, 259);
            this.date_debut.ValueChanged += new System.EventHandler(this.date_debut_ValueChanged);
            // 
            // Demander
            // 
            this.Demander.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Demander.Animated = true;
            this.Demander.AutoRoundedCorners = true;
            this.Demander.BorderRadius = 31;
            this.Demander.CheckedState.Parent = this.Demander;
            this.Demander.CustomImages.Parent = this.Demander;
            this.Demander.FillColor = System.Drawing.Color.Gray;
            this.Demander.Font = new System.Drawing.Font("Benguiat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Demander.ForeColor = System.Drawing.Color.White;
            this.Demander.HoverState.Parent = this.Demander;
            this.Demander.Location = new System.Drawing.Point(295, 242);
            this.Demander.Name = "Demander";
            this.Demander.ShadowDecoration.Parent = this.Demander;
            this.Demander.Size = new System.Drawing.Size(200, 65);
            this.Demander.TabIndex = 3;
            this.Demander.Text = "Demander";
            this.Demander.Click += new System.EventHandler(this.Demander_Click);
            // 
            // nombre_des_jours
            // 
            this.nombre_des_jours.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nombre_des_jours.BorderColor = System.Drawing.Color.Black;
            this.nombre_des_jours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombre_des_jours.DefaultText = "";
            this.nombre_des_jours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nombre_des_jours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nombre_des_jours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nombre_des_jours.DisabledState.Parent = this.nombre_des_jours;
            this.nombre_des_jours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nombre_des_jours.Enabled = false;
            this.nombre_des_jours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.nombre_des_jours.FocusedState.Parent = this.nombre_des_jours;
            this.nombre_des_jours.Font = new System.Drawing.Font("EPSON ëæñæí©ëÃÇa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nombre_des_jours.ForeColor = System.Drawing.Color.Black;
            this.nombre_des_jours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.nombre_des_jours.HoverState.Parent = this.nombre_des_jours;
            this.nombre_des_jours.Location = new System.Drawing.Point(316, 322);
            this.nombre_des_jours.Name = "nombre_des_jours";
            this.nombre_des_jours.PasswordChar = '\0';
            this.nombre_des_jours.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nombre_des_jours.PlaceholderText = "Nombre des jours";
            this.nombre_des_jours.ReadOnly = true;
            this.nombre_des_jours.SelectedText = "";
            this.nombre_des_jours.ShadowDecoration.Parent = this.nombre_des_jours;
            this.nombre_des_jours.Size = new System.Drawing.Size(168, 30);
            this.nombre_des_jours.TabIndex = 5;
            // 
            // date_retour
            // 
            this.date_retour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.date_retour.CheckedState.Parent = this.date_retour;
            this.date_retour.FillColor = System.Drawing.Color.Gray;
            this.date_retour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_retour.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_retour.HoverState.Parent = this.date_retour;
            this.date_retour.Location = new System.Drawing.Point(563, 88);
            this.date_retour.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_retour.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_retour.Name = "date_retour";
            this.date_retour.ShadowDecoration.Parent = this.date_retour;
            this.date_retour.Size = new System.Drawing.Size(161, 32);
            this.date_retour.TabIndex = 2;
            this.date_retour.Value = new System.DateTime(2021, 4, 21, 15, 46, 17, 273);
            this.date_retour.ValueChanged += new System.EventHandler(this.date_retour_ValueChanged);
            // 
            // date_fin
            // 
            this.date_fin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.date_fin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.date_fin.CheckedState.Parent = this.date_fin;
            this.date_fin.FillColor = System.Drawing.Color.Gray;
            this.date_fin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_fin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_fin.HoverState.Parent = this.date_fin;
            this.date_fin.Location = new System.Drawing.Point(295, 84);
            this.date_fin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_fin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_fin.Name = "date_fin";
            this.date_fin.ShadowDecoration.Parent = this.date_fin;
            this.date_fin.Size = new System.Drawing.Size(171, 36);
            this.date_fin.TabIndex = 1;
            this.date_fin.Value = new System.DateTime(2021, 4, 21, 0, 0, 0, 0);
            this.date_fin.ValueChanged += new System.EventHandler(this.date_fin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.label1.Font = new System.Drawing.Font("Benguiat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congé de maladie";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.date_debut);
            this.guna2GroupBox1.Controls.Add(this.Demander);
            this.guna2GroupBox1.Controls.Add(this.nombre_des_jours);
            this.guna2GroupBox1.Controls.Add(this.date_retour);
            this.guna2GroupBox1.Controls.Add(this.date_fin);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2GroupBox1.Location = new System.Drawing.Point(194, 129);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(760, 403);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.UseTransparentBackground = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Benguiat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(581, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date retour :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Benguiat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date fin :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Benguiat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date debut :";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(194, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(763, 130);
            this.guna2Panel2.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(655, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 14;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(706, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 13;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.quitter);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(194, 544);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Silver;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Benguiat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Gestion_de_congé.Properties.Resources.android_arrow_back;
            this.guna2Button1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button1.Location = new System.Drawing.Point(0, 32);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(182, 51);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Retour";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // quitter
            // 
            this.quitter.BackColor = System.Drawing.Color.Silver;
            this.quitter.CheckedState.Parent = this.quitter;
            this.quitter.CustomImages.Parent = this.quitter;
            this.quitter.FillColor = System.Drawing.Color.SteelBlue;
            this.quitter.Font = new System.Drawing.Font("Benguiat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter.ForeColor = System.Drawing.Color.Black;
            this.quitter.HoverState.Parent = this.quitter;
            this.quitter.Image = global::Gestion_de_congé.Properties.Resources.log_out;
            this.quitter.ImageSize = new System.Drawing.Size(50, 50);
            this.quitter.Location = new System.Drawing.Point(0, 480);
            this.quitter.Name = "quitter";
            this.quitter.ShadowDecoration.Parent = this.quitter;
            this.quitter.Size = new System.Drawing.Size(185, 51);
            this.quitter.TabIndex = 1;
            this.quitter.Text = "Déconnecter";
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // emp_maladie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 544);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "emp_maladie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emp_maladie";
            this.Load += new System.EventHandler(this.emp_maladie_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker date_debut;
        private Guna.UI2.WinForms.Guna2Button Demander;
        private Guna.UI2.WinForms.Guna2TextBox nombre_des_jours;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_retour;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_fin;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button quitter;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}