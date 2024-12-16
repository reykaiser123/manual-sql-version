namespace Gym_Membership_Manage
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
            this.components = new System.ComponentModel.Container();
            this.occupationTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.durationTB = new System.Windows.Forms.TextBox();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.closeBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.addBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gymMembershipDataSet = new Gym_Membership_Manage.gymMembershipDataSet();
            this.membershipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipsTableAdapter = new Gym_Membership_Manage.gymMembershipDataSetTableAdapters.MembershipsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // occupationTB
            // 
            this.occupationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationTB.Location = new System.Drawing.Point(166, 264);
            this.occupationTB.Name = "occupationTB";
            this.occupationTB.Size = new System.Drawing.Size(175, 28);
            this.occupationTB.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "OCCUPATION";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(717, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Convert To PDF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Gym Memberships";
            // 
            // durationTB
            // 
            this.durationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTB.Location = new System.Drawing.Point(159, 211);
            this.durationTB.Name = "durationTB";
            this.durationTB.Size = new System.Drawing.Size(175, 28);
            this.durationTB.TabIndex = 28;
            // 
            // numberTB
            // 
            this.numberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTB.Location = new System.Drawing.Point(159, 149);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(175, 28);
            this.numberTB.TabIndex = 27;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(159, 87);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(175, 28);
            this.nameTB.TabIndex = 26;
            // 
            // closeBT
            // 
            this.closeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBT.Location = new System.Drawing.Point(124, 362);
            this.closeBT.Name = "closeBT";
            this.closeBT.Size = new System.Drawing.Size(99, 35);
            this.closeBT.TabIndex = 25;
            this.closeBT.Text = "CLOSE";
            this.closeBT.UseVisualStyleBackColor = true;
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click_1);
            // 
            // deleteBT
            // 
            this.deleteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBT.Location = new System.Drawing.Point(229, 321);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(112, 35);
            this.deleteBT.TabIndex = 24;
            this.deleteBT.Text = "DELETE";
            this.deleteBT.UseVisualStyleBackColor = true;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click_1);
            // 
            // saveBT
            // 
            this.saveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBT.Location = new System.Drawing.Point(134, 321);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(80, 35);
            this.saveBT.TabIndex = 23;
            this.saveBT.Text = "SAVE";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click_1);
            // 
            // addBT
            // 
            this.addBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBT.Location = new System.Drawing.Point(41, 321);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(80, 35);
            this.addBT.TabIndex = 22;
            this.addBT.Text = "ADD";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "DURATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "NUMBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "NAME";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(505, 249);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gymMembershipDataSet
            // 
            this.gymMembershipDataSet.DataSetName = "gymMembershipDataSet";
            this.gymMembershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membershipsBindingSource
            // 
            this.membershipsBindingSource.DataMember = "Memberships";
            this.membershipsBindingSource.DataSource = this.gymMembershipDataSet;
            // 
            // membershipsTableAdapter
            // 
            this.membershipsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.occupationTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durationTB);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.closeBT);
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.addBT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox occupationTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox durationTB;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button closeBT;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gymMembershipDataSet gymMembershipDataSet;
        private System.Windows.Forms.BindingSource membershipsBindingSource;
        private gymMembershipDataSetTableAdapters.MembershipsTableAdapter membershipsTableAdapter;
    }
}

