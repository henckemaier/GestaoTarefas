namespace GestaoTarefas.WinApp
{
    partial class MenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTarefa = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "eAgenda 2.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Window;
            this.btnSair.BackgroundImage = global::GestaoTarefas.WinApp.Properties.Resources.arrow_alt_circle_left_solid1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 307);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(49, 49);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTarefa
            // 
            this.btnTarefa.BackColor = System.Drawing.SystemColors.Window;
            this.btnTarefa.Image = global::GestaoTarefas.WinApp.Properties.Resources.sticky_note_solid;
            this.btnTarefa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTarefa.Location = new System.Drawing.Point(133, 166);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(130, 70);
            this.btnTarefa.TabIndex = 2;
            this.btnTarefa.Text = "Tarefas";
            this.btnTarefa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTarefa.UseVisualStyleBackColor = false;
            this.btnTarefa.Click += new System.EventHandler(this.btnTarefa_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.BackColor = System.Drawing.SystemColors.Window;
            this.btnContatos.Image = global::GestaoTarefas.WinApp.Properties.Resources.user_tie_solid;
            this.btnContatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContatos.Location = new System.Drawing.Point(269, 166);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(130, 70);
            this.btnContatos.TabIndex = 3;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContatos.UseVisualStyleBackColor = false;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.BackColor = System.Drawing.SystemColors.Window;
            this.btnCompromissos.Image = global::GestaoTarefas.WinApp.Properties.Resources.address_book_regular;
            this.btnCompromissos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompromissos.Location = new System.Drawing.Point(405, 166);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(130, 70);
            this.btnCompromissos.TabIndex = 4;
            this.btnCompromissos.Text = "Compromissos";
            this.btnCompromissos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompromissos.UseVisualStyleBackColor = false;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestaoTarefas.WinApp.Properties.Resources.joinha;
            this.ClientSize = new System.Drawing.Size(646, 368);
            this.Controls.Add(this.btnCompromissos);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.btnTarefa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTarefa;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnCompromissos;
    }
}