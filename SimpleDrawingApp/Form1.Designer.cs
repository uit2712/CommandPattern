namespace SimpleDrawingApp
{
    partial class Form1
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
            this.pnlDrawingArea = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.cbbShape = new System.Windows.Forms.ComboBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlDrawingArea
            // 
            this.pnlDrawingArea.AutoScroll = true;
            this.pnlDrawingArea.BackColor = System.Drawing.Color.White;
            this.pnlDrawingArea.Location = new System.Drawing.Point(12, 12);
            this.pnlDrawingArea.Name = "pnlDrawingArea";
            this.pnlDrawingArea.Size = new System.Drawing.Size(316, 287);
            this.pnlDrawingArea.TabIndex = 0;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(334, 12);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(360, 9);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(132, 26);
            this.txtX.TabIndex = 1;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(334, 44);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 20);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(360, 41);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(132, 26);
            this.txtY.TabIndex = 2;
            // 
            // cbbShape
            // 
            this.cbbShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShape.FormattingEnabled = true;
            this.cbbShape.Items.AddRange(new object[] {
            "Hình tròn",
            "Hình chữ nhật"});
            this.cbbShape.Location = new System.Drawing.Point(360, 73);
            this.cbbShape.Name = "cbbShape";
            this.cbbShape.Size = new System.Drawing.Size(132, 28);
            this.cbbShape.TabIndex = 3;
            // 
            // btnDraw
            // 
            this.btnDraw.AutoSize = true;
            this.btnDraw.Location = new System.Drawing.Point(360, 107);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(132, 30);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Vẽ";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.AutoSize = true;
            this.btnUndo.Location = new System.Drawing.Point(360, 143);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(132, 30);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Trở lại";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 311);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.cbbShape);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.pnlDrawingArea);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawingArea;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.ComboBox cbbShape;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnUndo;
    }
}

