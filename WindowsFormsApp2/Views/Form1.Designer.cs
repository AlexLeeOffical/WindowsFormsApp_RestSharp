namespace WindowsFormsApp2
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
            this.panelMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.lblLPN = new System.Windows.Forms.Label();
            this.tboxDateTime = new System.Windows.Forms.TextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblLPN_Output = new System.Windows.Forms.Label();
            this.lblDateTime_Output = new System.Windows.Forms.Label();
            this.lblLPN_Input = new System.Windows.Forms.Label();
            this.lblDateTime_Input = new System.Windows.Forms.Label();
            this.tboxLPN = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTopic = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panelMiddle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMiddle
            // 
            this.panelMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMiddle.ColumnCount = 2;
            this.panelMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panelMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.panelMiddle.Controls.Add(this.lblLPN, 0, 0);
            this.panelMiddle.Controls.Add(this.tboxDateTime, 1, 4);
            this.panelMiddle.Controls.Add(this.lblDateTime, 0, 1);
            this.panelMiddle.Controls.Add(this.lblLPN_Output, 1, 0);
            this.panelMiddle.Controls.Add(this.lblDateTime_Output, 1, 1);
            this.panelMiddle.Controls.Add(this.lblLPN_Input, 0, 3);
            this.panelMiddle.Controls.Add(this.lblDateTime_Input, 0, 4);
            this.panelMiddle.Controls.Add(this.tboxLPN, 1, 3);
            this.panelMiddle.Location = new System.Drawing.Point(12, 67);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.RowCount = 5;
            this.panelMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.panelMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.panelMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelMiddle.Size = new System.Drawing.Size(357, 363);
            this.panelMiddle.TabIndex = 0;
            // 
            // lblLPN
            // 
            this.lblLPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLPN.AutoSize = true;
            this.lblLPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPN.Location = new System.Drawing.Point(3, 24);
            this.lblLPN.Name = "lblLPN";
            this.lblLPN.Size = new System.Drawing.Size(136, 25);
            this.lblLPN.TabIndex = 0;
            this.lblLPN.Text = "LPN:";
            this.lblLPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxDateTime
            // 
            this.tboxDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxDateTime.Location = new System.Drawing.Point(145, 312);
            this.tboxDateTime.Name = "tboxDateTime";
            this.tboxDateTime.Size = new System.Drawing.Size(209, 20);
            this.tboxDateTime.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(3, 98);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(136, 25);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date Time:";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLPN_Output
            // 
            this.lblLPN_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLPN_Output.AutoSize = true;
            this.lblLPN_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPN_Output.Location = new System.Drawing.Point(145, 24);
            this.lblLPN_Output.Name = "lblLPN_Output";
            this.lblLPN_Output.Size = new System.Drawing.Size(209, 25);
            this.lblLPN_Output.TabIndex = 0;
            this.lblLPN_Output.Text = "-";
            this.lblLPN_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTime_Output
            // 
            this.lblDateTime_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime_Output.AutoSize = true;
            this.lblDateTime_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime_Output.Location = new System.Drawing.Point(145, 98);
            this.lblDateTime_Output.Name = "lblDateTime_Output";
            this.lblDateTime_Output.Size = new System.Drawing.Size(209, 25);
            this.lblDateTime_Output.TabIndex = 0;
            this.lblDateTime_Output.Text = "-";
            this.lblDateTime_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLPN_Input
            // 
            this.lblLPN_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLPN_Input.AutoSize = true;
            this.lblLPN_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLPN_Input.Location = new System.Drawing.Point(3, 235);
            this.lblLPN_Input.Name = "lblLPN_Input";
            this.lblLPN_Input.Size = new System.Drawing.Size(136, 25);
            this.lblLPN_Input.TabIndex = 0;
            this.lblLPN_Input.Text = "LPN: ";
            this.lblLPN_Input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTime_Input
            // 
            this.lblDateTime_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime_Input.AutoSize = true;
            this.lblDateTime_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime_Input.Location = new System.Drawing.Point(3, 310);
            this.lblDateTime_Input.Name = "lblDateTime_Input";
            this.lblDateTime_Input.Size = new System.Drawing.Size(136, 25);
            this.lblDateTime_Input.TabIndex = 0;
            this.lblDateTime_Input.Text = "Date Time:";
            this.lblDateTime_Input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxLPN
            // 
            this.tboxLPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxLPN.Location = new System.Drawing.Point(145, 237);
            this.tboxLPN.Name = "tboxLPN";
            this.tboxLPN.Size = new System.Drawing.Size(209, 20);
            this.tboxLPN.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTopic, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 49);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblTopic
            // 
            this.lblTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(3, 12);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(345, 25);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "Test App";
            this.lblTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnEnter, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 436);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(357, 49);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.Location = new System.Drawing.Point(3, 3);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(351, 43);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 497);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMiddle.ResumeLayout(false);
            this.panelMiddle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMiddle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblLPN;
        private System.Windows.Forms.TextBox tboxDateTime;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblLPN_Output;
        private System.Windows.Forms.Label lblDateTime_Output;
        private System.Windows.Forms.Label lblLPN_Input;
        private System.Windows.Forms.Label lblDateTime_Input;
        private System.Windows.Forms.TextBox tboxLPN;
    }
}

