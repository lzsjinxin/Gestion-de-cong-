
namespace Gestion_de_congé
{
    partial class suppr_dialog
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
            this.emp_button = new Guna.UI2.WinForms.Guna2Button();
            this.conge_button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Back = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // emp_button
            // 
            this.emp_button.Animated = true;
            this.emp_button.AutoRoundedCorners = true;
            this.emp_button.BorderRadius = 21;
            this.emp_button.CheckedState.Parent = this.emp_button;
            this.emp_button.CustomImages.Parent = this.emp_button;
            this.emp_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            this.emp_button.Font = new System.Drawing.Font("Benguiat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_button.ForeColor = System.Drawing.Color.White;
            this.emp_button.HoverState.Parent = this.emp_button;
            this.emp_button.Location = new System.Drawing.Point(120, 29);
            this.emp_button.Name = "emp_button";
            this.emp_button.ShadowDecoration.Parent = this.emp_button;
            this.emp_button.Size = new System.Drawing.Size(259, 45);
            this.emp_button.TabIndex = 0;
            this.emp_button.Text = "Employée";
            this.emp_button.Click += new System.EventHandler(this.emp_button_Click);
            // 
            // conge_button
            // 
            this.conge_button.Animated = true;
            this.conge_button.AutoRoundedCorners = true;
            this.conge_button.BorderRadius = 21;
            this.conge_button.CheckedState.Parent = this.conge_button;
            this.conge_button.CustomImages.Parent = this.conge_button;
            this.conge_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(49)))), ((int)(((byte)(137)))));
            this.conge_button.Font = new System.Drawing.Font("Benguiat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conge_button.ForeColor = System.Drawing.Color.White;
            this.conge_button.HoverState.Parent = this.conge_button;
            this.conge_button.Location = new System.Drawing.Point(509, 29);
            this.conge_button.Name = "conge_button";
            this.conge_button.ShadowDecoration.Parent = this.conge_button;
            this.conge_button.Size = new System.Drawing.Size(224, 45);
            this.conge_button.TabIndex = 1;
            this.conge_button.Text = "Congé";
            this.conge_button.Click += new System.EventHandler(this.conge_button_Click);
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
            this.Back.Location = new System.Drawing.Point(12, 29);
            this.Back.Name = "Back";
            this.Back.ShadowDecoration.Parent = this.Back;
            this.Back.Size = new System.Drawing.Size(55, 45);
            this.Back.TabIndex = 7;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // suppr_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 102);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.conge_button);
            this.Controls.Add(this.emp_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "suppr_dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "suppr_dialog";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button emp_button;
        private Guna.UI2.WinForms.Guna2Button conge_button;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button Back;
    }
}