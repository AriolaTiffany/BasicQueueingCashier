namespace BasicQueueingCashier
{
    partial class QueuingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCashier = new Button();
            lblQueue = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.PowderBlue;
            btnCashier.FlatStyle = FlatStyle.Popup;
            btnCashier.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(40, 101);
            btnCashier.Margin = new Padding(3, 4, 3, 4);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(127, 133);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(43, 65);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(162, 31);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "X - XXXXX ";
            lblQueue.Click += btnCashier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(40, 256);
            label1.Name = "label1";
            label1.Size = new Size(154, 18);
            label1.TabIndex = 2;
            label1.Text = "*Click to get a number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 19);
            label2.Name = "label2";
            label2.Size = new Size(204, 29);
            label2.TabIndex = 3;
            label2.Text = "Position in Queue";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblQueue);
            panel1.Location = new Point(190, 101);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 133);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(137, 49);
            label3.Name = "label3";
            label3.Size = new Size(194, 48);
            label3.TabIndex = 5;
            label3.Text = "Queuing";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(475, 327);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QueuingForm";
            Text = "QueuingForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label lblQueue;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}
