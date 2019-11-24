namespace My_Custom_List_by_MCF___stud_
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.logsTxt = new System.Windows.Forms.RichTextBox();
            this.listCatego = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listMyList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndeleteList = new System.Windows.Forms.Button();
            this.btnDeleteCatego = new System.Windows.Forms.Button();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.btnCreateCatego = new System.Windows.Forms.Button();
            this.editNameList = new System.Windows.Forms.TextBox();
            this.editFolderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkAllCatego = new System.Windows.Forms.CheckBox();
            this.btnTirage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddItemInList = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.editAdditemsList = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtShowList = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counter)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(12, 478);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(446, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "fermer";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Button1_Click);
            // 
            // logsTxt
            // 
            this.logsTxt.Location = new System.Drawing.Point(7, 17);
            this.logsTxt.Margin = new System.Windows.Forms.Padding(4);
            this.logsTxt.Name = "logsTxt";
            this.logsTxt.Size = new System.Drawing.Size(429, 47);
            this.logsTxt.TabIndex = 1;
            this.logsTxt.Text = "";
            // 
            // listCatego
            // 
            this.listCatego.FormattingEnabled = true;
            this.listCatego.ItemHeight = 16;
            this.listCatego.Location = new System.Drawing.Point(15, 41);
            this.listCatego.Name = "listCatego";
            this.listCatego.Size = new System.Drawing.Size(163, 84);
            this.listCatego.TabIndex = 2;
            this.listCatego.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListCatego_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes catégories :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listMyList);
            this.groupBox1.Controls.Add(this.listCatego);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // listMyList
            // 
            this.listMyList.FormattingEnabled = true;
            this.listMyList.ItemHeight = 16;
            this.listMyList.Location = new System.Drawing.Point(272, 41);
            this.listMyList.Name = "listMyList";
            this.listMyList.Size = new System.Drawing.Size(163, 84);
            this.listMyList.TabIndex = 2;
            this.listMyList.SelectedIndexChanged += new System.EventHandler(this.ListMyList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mes listes :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndeleteList);
            this.groupBox2.Controls.Add(this.btnDeleteCatego);
            this.groupBox2.Controls.Add(this.btnCreateList);
            this.groupBox2.Controls.Add(this.btnCreateCatego);
            this.groupBox2.Controls.Add(this.editNameList);
            this.groupBox2.Controls.Add(this.editFolderName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(464, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 146);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Création";
            // 
            // btndeleteList
            // 
            this.btndeleteList.Location = new System.Drawing.Point(273, 103);
            this.btndeleteList.Name = "btndeleteList";
            this.btndeleteList.Size = new System.Drawing.Size(163, 28);
            this.btndeleteList.TabIndex = 5;
            this.btndeleteList.Text = "Supprimer liste";
            this.btndeleteList.UseVisualStyleBackColor = true;
            this.btndeleteList.Click += new System.EventHandler(this.BtndeleteList_Click);
            // 
            // btnDeleteCatego
            // 
            this.btnDeleteCatego.Location = new System.Drawing.Point(16, 104);
            this.btnDeleteCatego.Name = "btnDeleteCatego";
            this.btnDeleteCatego.Size = new System.Drawing.Size(163, 28);
            this.btnDeleteCatego.TabIndex = 5;
            this.btnDeleteCatego.Text = "Supprimer catégorie";
            this.btnDeleteCatego.UseVisualStyleBackColor = true;
            this.btnDeleteCatego.Click += new System.EventHandler(this.BtnDeleteCatego_Click);
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(273, 69);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(163, 28);
            this.btnCreateList.TabIndex = 4;
            this.btnCreateList.Text = "Créer la liste";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.BtnCreateList_Click);
            // 
            // btnCreateCatego
            // 
            this.btnCreateCatego.Location = new System.Drawing.Point(16, 69);
            this.btnCreateCatego.Name = "btnCreateCatego";
            this.btnCreateCatego.Size = new System.Drawing.Size(163, 28);
            this.btnCreateCatego.TabIndex = 3;
            this.btnCreateCatego.Text = "Créer la catégorie";
            this.btnCreateCatego.UseVisualStyleBackColor = true;
            this.btnCreateCatego.Click += new System.EventHandler(this.BtnCreateCatego_Click);
            // 
            // editNameList
            // 
            this.editNameList.Location = new System.Drawing.Point(273, 42);
            this.editNameList.Name = "editNameList";
            this.editNameList.Size = new System.Drawing.Size(163, 22);
            this.editNameList.TabIndex = 2;
            // 
            // editFolderName
            // 
            this.editFolderName.Location = new System.Drawing.Point(16, 42);
            this.editFolderName.Name = "editFolderName";
            this.editFolderName.Size = new System.Drawing.Size(163, 22);
            this.editFolderName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Créer une liste :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Créer une catégorie :";
            // 
            // counter
            // 
            this.counter.Location = new System.Drawing.Point(16, 44);
            this.counter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(83, 22);
            this.counter.TabIndex = 6;
            this.counter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkAllCatego);
            this.groupBox3.Controls.Add(this.btnTirage);
            this.groupBox3.Controls.Add(this.counter);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(465, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 119);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tirage";
            // 
            // checkAllCatego
            // 
            this.checkAllCatego.AutoSize = true;
            this.checkAllCatego.Location = new System.Drawing.Point(144, 46);
            this.checkAllCatego.Name = "checkAllCatego";
            this.checkAllCatego.Size = new System.Drawing.Size(289, 20);
            this.checkAllCatego.TabIndex = 8;
            this.checkAllCatego.Text = "Recherche dans toutes les catégories";
            this.checkAllCatego.UseVisualStyleBackColor = true;
            this.checkAllCatego.CheckedChanged += new System.EventHandler(this.CheckAllCatego_CheckedChanged);
            // 
            // btnTirage
            // 
            this.btnTirage.Location = new System.Drawing.Point(15, 77);
            this.btnTirage.Name = "btnTirage";
            this.btnTirage.Size = new System.Drawing.Size(418, 28);
            this.btnTirage.TabIndex = 7;
            this.btnTirage.Text = "Effectuer le tirage";
            this.btnTirage.UseVisualStyleBackColor = true;
            this.btnTirage.Click += new System.EventHandler(this.BtnTirage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre de mots dans le tirage :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.logsTxt);
            this.groupBox4.Location = new System.Drawing.Point(465, 450);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 71);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(388, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "By : [MCF] Aroun Le BriCodeur | aroun.lbcd@gmail.com";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddItemInList);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.editAdditemsList);
            this.groupBox5.Location = new System.Drawing.Point(464, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 155);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ajouter";
            // 
            // btnAddItemInList
            // 
            this.btnAddItemInList.Location = new System.Drawing.Point(271, 96);
            this.btnAddItemInList.Name = "btnAddItemInList";
            this.btnAddItemInList.Size = new System.Drawing.Size(163, 53);
            this.btnAddItemInList.TabIndex = 3;
            this.btnAddItemInList.Text = "Ajouter";
            this.btnAddItemInList.UseVisualStyleBackColor = true;
            this.btnAddItemInList.Click += new System.EventHandler(this.BtnAddItemInList_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ajouter dans la liste \r\n(mettre une virgule entre chaque mot):";
            // 
            // editAdditemsList
            // 
            this.editAdditemsList.Location = new System.Drawing.Point(14, 53);
            this.editAdditemsList.Multiline = true;
            this.editAdditemsList.Name = "editAdditemsList";
            this.editAdditemsList.Size = new System.Drawing.Size(251, 96);
            this.editAdditemsList.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtShowList);
            this.groupBox6.Location = new System.Drawing.Point(12, 164);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(446, 307);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Visualisation";
            // 
            // txtShowList
            // 
            this.txtShowList.Location = new System.Drawing.Point(6, 21);
            this.txtShowList.Name = "txtShowList";
            this.txtShowList.ReadOnly = true;
            this.txtShowList.Size = new System.Drawing.Size(429, 280);
            this.txtShowList.TabIndex = 0;
            this.txtShowList.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(922, 545);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "BackG";
            this.Text = "My Custom List - MCF Stud\'";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counter)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox logsTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCatego;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listMyList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox editNameList;
        private System.Windows.Forms.TextBox editFolderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown counter;
        private System.Windows.Forms.Button btnCreateCatego;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.Button btnTirage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btndeleteList;
        private System.Windows.Forms.Button btnDeleteCatego;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editAdditemsList;
        private System.Windows.Forms.Button btnAddItemInList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox txtShowList;
        private System.Windows.Forms.CheckBox checkAllCatego;
    }
}

