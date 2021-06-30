
namespace Gestion_de_congé
{
    partial class Login
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
            this.afficher_mdp = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.login_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.mdp_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.create_new_button = new Guna.UI2.WinForms.Guna2Button();
            this.login_butt = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // afficher_mdp
            // 
            this.afficher_mdp.AutoSize = true;
            this.afficher_mdp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.afficher_mdp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.afficher_mdp.CheckedState.BorderRadius = 0;
            this.afficher_mdp.CheckedState.BorderThickness = 0;
            this.afficher_mdp.CheckedState.FillColor = System.Drawing.Color.Beige;
            this.afficher_mdp.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            this.afficher_mdp.Location = new System.Drawing.Point(341, 282);
            this.afficher_mdp.Name = "afficher_mdp";
            this.afficher_mdp.Size = new System.Drawing.Size(194, 24);
            this.afficher_mdp.TabIndex = 2;
            this.afficher_mdp.Text = "Afficher mot de passe ";
            this.afficher_mdp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            this.afficher_mdp.UncheckedState.BorderRadius = 0;
            this.afficher_mdp.UncheckedState.BorderThickness = 0;
            this.afficher_mdp.UncheckedState.FillColor = System.Drawing.Color.White;
            this.afficher_mdp.UseVisualStyleBackColor = false;
            this.afficher_mdp.CheckedChanged += new System.EventHandler(this.afficher_mdp_CheckedChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 100;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DragEndTransparencyValue = 0.1D;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 23;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Gestion_de_congé.Properties.Resources.android_close;
            this.guna2Button1.Location = new System.Drawing.Point(549, 25);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(49, 49);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // login_text
            // 
            this.login_text.Animated = true;
            this.login_text.AutoRoundedCorners = true;
            this.login_text.BorderRadius = 17;
            this.login_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_text.DefaultText = "";
            this.login_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_text.DisabledState.Parent = this.login_text;
            this.login_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            this.login_text.FocusedState.Parent = this.login_text;
            this.login_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_text.ForeColor = System.Drawing.Color.Black;
            this.login_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            this.login_text.HoverState.Parent = this.login_text;
            this.login_text.IconRight = global::Gestion_de_congé.Properties.Resources.android_social_user;
            this.login_text.Location = new System.Drawing.Point(107, 125);
            this.login_text.Name = "login_text";
            this.login_text.PasswordChar = '\0';
            this.login_text.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.login_text.PlaceholderText = "Login";
            this.login_text.SelectedText = "";
            this.login_text.ShadowDecoration.Parent = this.login_text;
            this.login_text.Size = new System.Drawing.Size(200, 36);
            this.login_text.TabIndex = 0;
            // 
            // mdp_text
            // 
            this.mdp_text.Animated = true;
            this.mdp_text.AutoRoundedCorners = true;
            this.mdp_text.BorderRadius = 17;
            this.mdp_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mdp_text.DefaultText = "";
            this.mdp_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mdp_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mdp_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mdp_text.DisabledState.Parent = this.mdp_text;
            this.mdp_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mdp_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.mdp_text.FocusedState.Parent = this.mdp_text;
            this.mdp_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mdp_text.ForeColor = System.Drawing.Color.Black;
            this.mdp_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.mdp_text.HoverState.Parent = this.mdp_text;
            this.mdp_text.IconRight = global::Gestion_de_congé.Properties.Resources.key;
            this.mdp_text.Location = new System.Drawing.Point(107, 270);
            this.mdp_text.Name = "mdp_text";
            this.mdp_text.PasswordChar = '\0';
            this.mdp_text.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.mdp_text.PlaceholderText = "Mot de passe";
            this.mdp_text.SelectedText = "";
            this.mdp_text.ShadowDecoration.Parent = this.mdp_text;
            this.mdp_text.Size = new System.Drawing.Size(200, 36);
            this.mdp_text.TabIndex = 1;
            this.mdp_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mdp_text_KeyDown);
            // 
            // create_new_button
            // 
            this.create_new_button.Animated = true;
            this.create_new_button.AutoRoundedCorners = true;
            this.create_new_button.BorderRadius = 17;
            this.create_new_button.CheckedState.Parent = this.create_new_button;
            this.create_new_button.CustomImages.Parent = this.create_new_button;
            this.create_new_button.FillColor = System.Drawing.Color.Gray;
            this.create_new_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.create_new_button.ForeColor = System.Drawing.Color.White;
            this.create_new_button.HoverState.Parent = this.create_new_button;
            this.create_new_button.Image = global::Gestion_de_congé.Properties.Resources.android_add;
            this.create_new_button.Location = new System.Drawing.Point(214, 390);
            this.create_new_button.Name = "create_new_button";
            this.create_new_button.ShadowDecoration.Parent = this.create_new_button;
            this.create_new_button.Size = new System.Drawing.Size(127, 36);
            this.create_new_button.TabIndex = 4;
            this.create_new_button.Text = "Inscription";
            this.create_new_button.Click += new System.EventHandler(this.create_new_button_Click);
            // 
            // login_butt
            // 
            this.login_butt.Animated = true;
            this.login_butt.AutoRoundedCorners = true;
            this.login_butt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.login_butt.BorderRadius = 17;
            this.login_butt.CheckedState.Parent = this.login_butt;
            this.login_butt.CustomImages.Parent = this.login_butt;
            this.login_butt.FillColor = System.Drawing.Color.Gray;
            this.login_butt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_butt.ForeColor = System.Drawing.Color.White;
            this.login_butt.HoverState.Parent = this.login_butt;
            this.login_butt.Image = global::Gestion_de_congé.Properties.Resources.log_in;
            this.login_butt.Location = new System.Drawing.Point(50, 390);
            this.login_butt.Name = "login_butt";
            this.login_butt.ShadowDecoration.Parent = this.login_butt;
            this.login_butt.Size = new System.Drawing.Size(132, 36);
            this.login_butt.TabIndex = 3;
            this.login_butt.Text = "Login";
            this.login_butt.Click += new System.EventHandler(this.login_butt_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 500);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.afficher_mdp);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.mdp_text);
            this.Controls.Add(this.create_new_button);
            this.Controls.Add(this.login_butt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button login_butt;
        private Guna.UI2.WinForms.Guna2Button create_new_button;
        private Guna.UI2.WinForms.Guna2TextBox mdp_text;
        private Guna.UI2.WinForms.Guna2TextBox login_text;
        private Guna.UI2.WinForms.Guna2CheckBox afficher_mdp;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}

