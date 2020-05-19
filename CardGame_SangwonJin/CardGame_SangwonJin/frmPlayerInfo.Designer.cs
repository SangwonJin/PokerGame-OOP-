namespace CardGame_SangwonJin
{
    partial class frmPlayerInfo
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
            this.btnStart = new System.Windows.Forms.Button();
            this.rdoPenguin = new System.Windows.Forms.RadioButton();
            this.rdoPig = new System.Windows.Forms.RadioButton();
            this.rdoBird = new System.Windows.Forms.RadioButton();
            this.rdoBear = new System.Windows.Forms.RadioButton();
            this.lblImage = new System.Windows.Forms.Label();
            this.picPenguin = new System.Windows.Forms.PictureBox();
            this.picPig = new System.Windows.Forms.PictureBox();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.picBear = new System.Windows.Forms.PictureBox();
            this.lblPlayerMoney = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerMoney = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPenguin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(313, 330);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 47);
            this.btnStart.TabIndex = 44;
            this.btnStart.Text = "&START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdoPenguin
            // 
            this.rdoPenguin.AutoSize = true;
            this.rdoPenguin.Location = new System.Drawing.Point(576, 298);
            this.rdoPenguin.Name = "rdoPenguin";
            this.rdoPenguin.Size = new System.Drawing.Size(14, 13);
            this.rdoPenguin.TabIndex = 43;
            this.rdoPenguin.TabStop = true;
            this.rdoPenguin.UseVisualStyleBackColor = true;
            // 
            // rdoPig
            // 
            this.rdoPig.AutoSize = true;
            this.rdoPig.Location = new System.Drawing.Point(457, 298);
            this.rdoPig.Name = "rdoPig";
            this.rdoPig.Size = new System.Drawing.Size(14, 13);
            this.rdoPig.TabIndex = 42;
            this.rdoPig.TabStop = true;
            this.rdoPig.UseVisualStyleBackColor = true;
            // 
            // rdoBird
            // 
            this.rdoBird.AutoSize = true;
            this.rdoBird.Location = new System.Drawing.Point(334, 298);
            this.rdoBird.Name = "rdoBird";
            this.rdoBird.Size = new System.Drawing.Size(14, 13);
            this.rdoBird.TabIndex = 41;
            this.rdoBird.TabStop = true;
            this.rdoBird.UseVisualStyleBackColor = true;
            // 
            // rdoBear
            // 
            this.rdoBear.AutoSize = true;
            this.rdoBear.Location = new System.Drawing.Point(220, 298);
            this.rdoBear.Name = "rdoBear";
            this.rdoBear.Size = new System.Drawing.Size(14, 13);
            this.rdoBear.TabIndex = 40;
            this.rdoBear.TabStop = true;
            this.rdoBear.UseVisualStyleBackColor = true;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(171, 156);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(139, 13);
            this.lblImage.TabIndex = 39;
            this.lblImage.Text = "Select your favourite Image:";
            // 
            // picPenguin
            // 
            this.picPenguin.Location = new System.Drawing.Point(532, 182);
            this.picPenguin.Name = "picPenguin";
            this.picPenguin.Size = new System.Drawing.Size(100, 100);
            this.picPenguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPenguin.TabIndex = 38;
            this.picPenguin.TabStop = false;
            // 
            // picPig
            // 
            this.picPig.Location = new System.Drawing.Point(412, 182);
            this.picPig.Name = "picPig";
            this.picPig.Size = new System.Drawing.Size(100, 100);
            this.picPig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPig.TabIndex = 37;
            this.picPig.TabStop = false;
            // 
            // picBird
            // 
            this.picBird.Location = new System.Drawing.Point(292, 182);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(100, 100);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBird.TabIndex = 36;
            this.picBird.TabStop = false;
            // 
            // picBear
            // 
            this.picBear.Location = new System.Drawing.Point(172, 182);
            this.picBear.Name = "picBear";
            this.picBear.Size = new System.Drawing.Size(100, 100);
            this.picBear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBear.TabIndex = 35;
            this.picBear.TabStop = false;
            // 
            // lblPlayerMoney
            // 
            this.lblPlayerMoney.AutoSize = true;
            this.lblPlayerMoney.Location = new System.Drawing.Point(390, 125);
            this.lblPlayerMoney.Name = "lblPlayerMoney";
            this.lblPlayerMoney.Size = new System.Drawing.Size(81, 13);
            this.lblPlayerMoney.TabIndex = 34;
            this.lblPlayerMoney.Text = "Starting Money:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(169, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 25);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Welcome to Five Card Stud Game";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(171, 125);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(63, 13);
            this.lblPlayerName.TabIndex = 32;
            this.lblPlayerName.Text = "Your Name:";
            // 
            // txtPlayerMoney
            // 
            this.txtPlayerMoney.Location = new System.Drawing.Point(477, 122);
            this.txtPlayerMoney.Name = "txtPlayerMoney";
            this.txtPlayerMoney.Size = new System.Drawing.Size(135, 20);
            this.txtPlayerMoney.TabIndex = 31;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(240, 122);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(124, 20);
            this.txtPlayerName.TabIndex = 30;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rdoPenguin);
            this.Controls.Add(this.rdoPig);
            this.Controls.Add(this.rdoBird);
            this.Controls.Add(this.rdoBear);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.picPenguin);
            this.Controls.Add(this.picPig);
            this.Controls.Add(this.picBird);
            this.Controls.Add(this.picBear);
            this.Controls.Add(this.lblPlayerMoney);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerMoney);
            this.Controls.Add(this.txtPlayerName);
            this.Name = "frmPlayerInfo";
            this.Text = "frmPlayerInfo";
            this.Load += new System.EventHandler(this.frmPlayerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPenguin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.RadioButton rdoPenguin;
        internal System.Windows.Forms.RadioButton rdoPig;
        internal System.Windows.Forms.RadioButton rdoBird;
        internal System.Windows.Forms.RadioButton rdoBear;
        internal System.Windows.Forms.Label lblImage;
        internal System.Windows.Forms.PictureBox picPenguin;
        internal System.Windows.Forms.PictureBox picPig;
        internal System.Windows.Forms.PictureBox picBird;
        internal System.Windows.Forms.PictureBox picBear;
        internal System.Windows.Forms.Label lblPlayerMoney;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label lblPlayerName;
        internal System.Windows.Forms.TextBox txtPlayerMoney;
        internal System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}