namespace MannysMusicForm
{
    partial class MainFrm
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
            this.grpInstrument = new System.Windows.Forms.GroupBox();
            this.txtElecPiano = new System.Windows.Forms.TextBox();
            this.txtViola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblViolaPrice = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSilver = new System.Windows.Forms.RadioButton();
            this.rbtnGold = new System.Windows.Forms.RadioButton();
            this.rbtnPlatinum = new System.Windows.Forms.RadioButton();
            this.grpbTotals = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotalTEXT = new System.Windows.Forms.Label();
            this.lblDiscountTEXT = new System.Windows.Forms.Label();
            this.lblSubtotalTEXT = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpInstrument.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInstrument
            // 
            this.grpInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpInstrument.Controls.Add(this.txtElecPiano);
            this.grpInstrument.Controls.Add(this.txtViola);
            this.grpInstrument.Controls.Add(this.label1);
            this.grpInstrument.Controls.Add(this.lblQuantity);
            this.grpInstrument.Controls.Add(this.lblViolaPrice);
            this.grpInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInstrument.Location = new System.Drawing.Point(100, 353);
            this.grpInstrument.Name = "grpInstrument";
            this.grpInstrument.Size = new System.Drawing.Size(644, 278);
            this.grpInstrument.TabIndex = 0;
            this.grpInstrument.TabStop = false;
            this.grpInstrument.Text = "Instrument";
            // 
            // txtElecPiano
            // 
            this.txtElecPiano.Location = new System.Drawing.Point(408, 162);
            this.txtElecPiano.Name = "txtElecPiano";
            this.txtElecPiano.Size = new System.Drawing.Size(160, 38);
            this.txtElecPiano.TabIndex = 1;
            this.txtElecPiano.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtViola
            // 
            this.txtViola.Location = new System.Drawing.Point(408, 91);
            this.txtViola.Name = "txtViola";
            this.txtViola.Size = new System.Drawing.Size(160, 38);
            this.txtViola.TabIndex = 1;
            this.txtViola.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elec. Piano ($795 ea.)";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(425, 34);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(124, 31);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblViolaPrice
            // 
            this.lblViolaPrice.AutoSize = true;
            this.lblViolaPrice.Location = new System.Drawing.Point(105, 91);
            this.lblViolaPrice.Name = "lblViolaPrice";
            this.lblViolaPrice.Size = new System.Drawing.Size(204, 31);
            this.lblViolaPrice.TabIndex = 0;
            this.lblViolaPrice.Text = "Viola ($295 ea.)";
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHeading.Location = new System.Drawing.Point(500, 73);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1105, 151);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Manny\'s Music Purchase Form";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.rbtnSilver);
            this.groupBox1.Controls.Add(this.rbtnGold);
            this.groupBox1.Controls.Add(this.rbtnPlatinum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(781, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount Level";
            // 
            // rbtnSilver
            // 
            this.rbtnSilver.AutoSize = true;
            this.rbtnSilver.Location = new System.Drawing.Point(80, 195);
            this.rbtnSilver.Name = "rbtnSilver";
            this.rbtnSilver.Size = new System.Drawing.Size(113, 35);
            this.rbtnSilver.TabIndex = 0;
            this.rbtnSilver.TabStop = true;
            this.rbtnSilver.Text = "Silver";
            this.rbtnSilver.UseVisualStyleBackColor = true;
            // 
            // rbtnGold
            // 
            this.rbtnGold.AutoSize = true;
            this.rbtnGold.Location = new System.Drawing.Point(80, 135);
            this.rbtnGold.Name = "rbtnGold";
            this.rbtnGold.Size = new System.Drawing.Size(102, 35);
            this.rbtnGold.TabIndex = 0;
            this.rbtnGold.TabStop = true;
            this.rbtnGold.Text = "Gold";
            this.rbtnGold.UseVisualStyleBackColor = true;
            // 
            // rbtnPlatinum
            // 
            this.rbtnPlatinum.AutoSize = true;
            this.rbtnPlatinum.Location = new System.Drawing.Point(80, 75);
            this.rbtnPlatinum.Name = "rbtnPlatinum";
            this.rbtnPlatinum.Size = new System.Drawing.Size(150, 35);
            this.rbtnPlatinum.TabIndex = 0;
            this.rbtnPlatinum.TabStop = true;
            this.rbtnPlatinum.Text = "Platinum";
            this.rbtnPlatinum.UseVisualStyleBackColor = true;
            // 
            // grpbTotals
            // 
            this.grpbTotals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpbTotals.Controls.Add(this.lblTotal);
            this.grpbTotals.Controls.Add(this.lblDiscount);
            this.grpbTotals.Controls.Add(this.lblSubtotal);
            this.grpbTotals.Controls.Add(this.lblTotalTEXT);
            this.grpbTotals.Controls.Add(this.lblDiscountTEXT);
            this.grpbTotals.Controls.Add(this.lblSubtotalTEXT);
            this.grpbTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbTotals.Location = new System.Drawing.Point(1159, 353);
            this.grpbTotals.Name = "grpbTotals";
            this.grpbTotals.Size = new System.Drawing.Size(644, 278);
            this.grpbTotals.TabIndex = 0;
            this.grpbTotals.TabStop = false;
            this.grpbTotals.Text = "Totals";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(350, 188);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(180, 42);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.White;
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Location = new System.Drawing.Point(350, 130);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(180, 40);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiscount.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.White;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(350, 70);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(180, 40);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // lblTotalTEXT
            // 
            this.lblTotalTEXT.AutoSize = true;
            this.lblTotalTEXT.Location = new System.Drawing.Point(144, 195);
            this.lblTotalTEXT.Name = "lblTotalTEXT";
            this.lblTotalTEXT.Size = new System.Drawing.Size(83, 31);
            this.lblTotalTEXT.TabIndex = 0;
            this.lblTotalTEXT.Text = "Total:";
            // 
            // lblDiscountTEXT
            // 
            this.lblDiscountTEXT.AutoSize = true;
            this.lblDiscountTEXT.Location = new System.Drawing.Point(98, 135);
            this.lblDiscountTEXT.Name = "lblDiscountTEXT";
            this.lblDiscountTEXT.Size = new System.Drawing.Size(129, 31);
            this.lblDiscountTEXT.TabIndex = 0;
            this.lblDiscountTEXT.Text = "Discount:";
            // 
            // lblSubtotalTEXT
            // 
            this.lblSubtotalTEXT.AutoSize = true;
            this.lblSubtotalTEXT.Location = new System.Drawing.Point(105, 77);
            this.lblSubtotalTEXT.Name = "lblSubtotalTEXT";
            this.lblSubtotalTEXT.Size = new System.Drawing.Size(122, 31);
            this.lblSubtotalTEXT.TabIndex = 0;
            this.lblSubtotalTEXT.Text = "Subtotal:";
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(809, 721);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(153, 46);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "&Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1309, 822);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 46);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(809, 822);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2041, 1055);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbTotals);
            this.Controls.Add(this.grpInstrument);
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.grpInstrument.ResumeLayout(false);
            this.grpInstrument.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbTotals.ResumeLayout(false);
            this.grpbTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInstrument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblViolaPrice;
        private System.Windows.Forms.TextBox txtViola;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtElecPiano;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSilver;
        private System.Windows.Forms.RadioButton rbtnGold;
        private System.Windows.Forms.RadioButton rbtnPlatinum;
        private System.Windows.Forms.GroupBox grpbTotals;
        private System.Windows.Forms.Label lblTotalTEXT;
        private System.Windows.Forms.Label lblDiscountTEXT;
        private System.Windows.Forms.Label lblSubtotalTEXT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnClear;
    }
}

