namespace rick_y_morty
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_Fondo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_second = new System.Windows.Forms.PictureBox();
            this.pic_titulo = new System.Windows.Forms.PictureBox();
            this.pic_main = new System.Windows.Forms.PictureBox();
            this.pic_mst1 = new System.Windows.Forms.PictureBox();
            this.player_name = new System.Windows.Forms.Label();
            this.player_hp = new System.Windows.Forms.Label();
            this.second_name = new System.Windows.Forms.Label();
            this.second_live = new System.Windows.Forms.Label();
            this.btn_burla = new System.Windows.Forms.Button();
            this.btn_golpe = new System.Windows.Forms.Button();
            this.btn_suero = new System.Windows.Forms.Button();
            this.btn_berserker = new System.Windows.Forms.Button();
            this.mst1_name = new System.Windows.Forms.Label();
            this.mst1_live = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_titulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mst1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Fondo
            // 
            this.pic_Fondo.Location = new System.Drawing.Point(53, 31);
            this.pic_Fondo.Name = "pic_Fondo";
            this.pic_Fondo.Size = new System.Drawing.Size(883, 537);
            this.pic_Fondo.TabIndex = 0;
            this.pic_Fondo.TabStop = false;
            this.pic_Fondo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pic_second
            // 
            this.pic_second.Location = new System.Drawing.Point(202, 397);
            this.pic_second.Name = "pic_second";
            this.pic_second.Size = new System.Drawing.Size(139, 136);
            this.pic_second.TabIndex = 3;
            this.pic_second.TabStop = false;
            this.pic_second.Click += new System.EventHandler(this.pic_second_Click);
            // 
            // pic_titulo
            // 
            this.pic_titulo.Location = new System.Drawing.Point(258, 31);
            this.pic_titulo.Name = "pic_titulo";
            this.pic_titulo.Size = new System.Drawing.Size(458, 175);
            this.pic_titulo.TabIndex = 4;
            this.pic_titulo.TabStop = false;
            // 
            // pic_main
            // 
            this.pic_main.Location = new System.Drawing.Point(202, 212);
            this.pic_main.Name = "pic_main";
            this.pic_main.Size = new System.Drawing.Size(139, 136);
            this.pic_main.TabIndex = 5;
            this.pic_main.TabStop = false;
            // 
            // pic_mst1
            // 
            this.pic_mst1.Location = new System.Drawing.Point(602, 300);
            this.pic_mst1.Name = "pic_mst1";
            this.pic_mst1.Size = new System.Drawing.Size(139, 136);
            this.pic_mst1.TabIndex = 6;
            this.pic_mst1.TabStop = false;
            // 
            // player_name
            // 
            this.player_name.AutoSize = true;
            this.player_name.Location = new System.Drawing.Point(105, 212);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(35, 13);
            this.player_name.TabIndex = 9;
            this.player_name.Text = "label2";
            // 
            // player_hp
            // 
            this.player_hp.AutoSize = true;
            this.player_hp.Location = new System.Drawing.Point(105, 240);
            this.player_hp.Name = "player_hp";
            this.player_hp.Size = new System.Drawing.Size(35, 13);
            this.player_hp.TabIndex = 10;
            this.player_hp.Text = "label2";
            this.player_hp.Click += new System.EventHandler(this.label2_Click);
            // 
            // second_name
            // 
            this.second_name.AutoSize = true;
            this.second_name.Location = new System.Drawing.Point(105, 397);
            this.second_name.Name = "second_name";
            this.second_name.Size = new System.Drawing.Size(35, 13);
            this.second_name.TabIndex = 11;
            this.second_name.Text = "label2";
            // 
            // second_live
            // 
            this.second_live.AutoSize = true;
            this.second_live.Location = new System.Drawing.Point(105, 423);
            this.second_live.Name = "second_live";
            this.second_live.Size = new System.Drawing.Size(35, 13);
            this.second_live.TabIndex = 12;
            this.second_live.Text = "label2";
            // 
            // btn_burla
            // 
            this.btn_burla.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_burla.Location = new System.Drawing.Point(53, 563);
            this.btn_burla.Name = "btn_burla";
            this.btn_burla.Size = new System.Drawing.Size(87, 38);
            this.btn_burla.TabIndex = 13;
            this.btn_burla.Text = "Burla ";
            this.btn_burla.UseVisualStyleBackColor = true;
            this.btn_burla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_golpe
            // 
            this.btn_golpe.Location = new System.Drawing.Point(146, 563);
            this.btn_golpe.Name = "btn_golpe";
            this.btn_golpe.Size = new System.Drawing.Size(87, 38);
            this.btn_golpe.TabIndex = 14;
            this.btn_golpe.Text = "Golpe Portal";
            this.btn_golpe.UseVisualStyleBackColor = true;
            this.btn_golpe.Click += new System.EventHandler(this.btn_golpe_Click);
            // 
            // btn_suero
            // 
            this.btn_suero.Location = new System.Drawing.Point(239, 563);
            this.btn_suero.Name = "btn_suero";
            this.btn_suero.Size = new System.Drawing.Size(87, 38);
            this.btn_suero.TabIndex = 15;
            this.btn_suero.Text = "Suero ";
            this.btn_suero.UseVisualStyleBackColor = true;
            this.btn_suero.Click += new System.EventHandler(this.btn_suero_Click);
            // 
            // btn_berserker
            // 
            this.btn_berserker.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_berserker.Location = new System.Drawing.Point(332, 563);
            this.btn_berserker.Name = "btn_berserker";
            this.btn_berserker.Size = new System.Drawing.Size(87, 38);
            this.btn_berserker.TabIndex = 16;
            this.btn_berserker.Text = "Modo Berserker";
            this.btn_berserker.UseVisualStyleBackColor = true;
            this.btn_berserker.Click += new System.EventHandler(this.btn_berserker_Click);
            // 
            // mst1_name
            // 
            this.mst1_name.AutoSize = true;
            this.mst1_name.Location = new System.Drawing.Point(760, 298);
            this.mst1_name.Name = "mst1_name";
            this.mst1_name.Size = new System.Drawing.Size(35, 13);
            this.mst1_name.TabIndex = 17;
            this.mst1_name.Text = "label2";
            this.mst1_name.Click += new System.EventHandler(this.mst1_name_Click);
            // 
            // mst1_live
            // 
            this.mst1_live.AutoSize = true;
            this.mst1_live.Location = new System.Drawing.Point(760, 317);
            this.mst1_live.Name = "mst1_live";
            this.mst1_live.Size = new System.Drawing.Size(35, 13);
            this.mst1_live.TabIndex = 18;
            this.mst1_live.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 651);
            this.Controls.Add(this.mst1_live);
            this.Controls.Add(this.mst1_name);
            this.Controls.Add(this.btn_berserker);
            this.Controls.Add(this.btn_suero);
            this.Controls.Add(this.btn_golpe);
            this.Controls.Add(this.btn_burla);
            this.Controls.Add(this.second_live);
            this.Controls.Add(this.second_name);
            this.Controls.Add(this.player_hp);
            this.Controls.Add(this.player_name);
            this.Controls.Add(this.pic_mst1);
            this.Controls.Add(this.pic_main);
            this.Controls.Add(this.pic_titulo);
            this.Controls.Add(this.pic_second);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Fondo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_titulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mst1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Fondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_second;
        private System.Windows.Forms.PictureBox pic_titulo;
        private System.Windows.Forms.PictureBox pic_main;
        private System.Windows.Forms.PictureBox pic_mst1;
        private System.Windows.Forms.Label player_name;
        private System.Windows.Forms.Label player_hp;
        private System.Windows.Forms.Label second_name;
        private System.Windows.Forms.Label second_live;
        private System.Windows.Forms.Button btn_burla;
        private System.Windows.Forms.Button btn_golpe;
        private System.Windows.Forms.Button btn_suero;
        private System.Windows.Forms.Button btn_berserker;
        private System.Windows.Forms.Label mst1_name;
        private System.Windows.Forms.Label mst1_live;
    }
}

