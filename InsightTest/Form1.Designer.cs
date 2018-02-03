namespace InsightTest
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
            this.btnImportLocations = new System.Windows.Forms.Button();
            this.btnCalculateDistances = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lvwWarehouseLocations = new System.Windows.Forms.ListView();
            this.colX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblCenterOfGravity = new System.Windows.Forms.Label();
            this.lblListWarehouses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImportLocations
            // 
            this.btnImportLocations.Location = new System.Drawing.Point(62, 61);
            this.btnImportLocations.Name = "btnImportLocations";
            this.btnImportLocations.Size = new System.Drawing.Size(130, 62);
            this.btnImportLocations.TabIndex = 0;
            this.btnImportLocations.Text = "Import Locations";
            this.btnImportLocations.UseVisualStyleBackColor = true;
            this.btnImportLocations.Click += new System.EventHandler(this.btnImportLocations_Click);
            // 
            // btnCalculateDistances
            // 
            this.btnCalculateDistances.Location = new System.Drawing.Point(62, 145);
            this.btnCalculateDistances.Name = "btnCalculateDistances";
            this.btnCalculateDistances.Size = new System.Drawing.Size(393, 42);
            this.btnCalculateDistances.TabIndex = 1;
            this.btnCalculateDistances.Text = "Calculate Distances to Center  of Gravity";
            this.btnCalculateDistances.UseVisualStyleBackColor = true;
            this.btnCalculateDistances.Click += new System.EventHandler(this.btnCalculateDistances_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(265, 61);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(190, 20);
            this.txtX.TabIndex = 2;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(265, 102);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(190, 20);
            this.txtY.TabIndex = 3;
            // 
            // lvwWarehouseLocations
            // 
            this.lvwWarehouseLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colX,
            this.colY,
            this.colDistance});
            this.lvwWarehouseLocations.FullRowSelect = true;
            this.lvwWarehouseLocations.GridLines = true;
            this.lvwWarehouseLocations.Location = new System.Drawing.Point(510, 61);
            this.lvwWarehouseLocations.Name = "lvwWarehouseLocations";
            this.lvwWarehouseLocations.Size = new System.Drawing.Size(198, 344);
            this.lvwWarehouseLocations.TabIndex = 4;
            this.lvwWarehouseLocations.UseCompatibleStateImageBehavior = false;
            this.lvwWarehouseLocations.View = System.Windows.Forms.View.Details;
            // 
            // colX
            // 
            this.colX.Text = "X";
            // 
            // colY
            // 
            this.colY.Text = "Y";
            // 
            // colDistance
            // 
            this.colDistance.Text = "Distance";
            this.colDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDistance.Width = 75;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(245, 64);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(245, 105);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "Y";
            // 
            // lblCenterOfGravity
            // 
            this.lblCenterOfGravity.AutoSize = true;
            this.lblCenterOfGravity.Location = new System.Drawing.Point(265, 28);
            this.lblCenterOfGravity.Name = "lblCenterOfGravity";
            this.lblCenterOfGravity.Size = new System.Drawing.Size(86, 13);
            this.lblCenterOfGravity.TabIndex = 7;
            this.lblCenterOfGravity.Text = "Center of Gravity";
            // 
            // lblListWarehouses
            // 
            this.lblListWarehouses.AutoSize = true;
            this.lblListWarehouses.Location = new System.Drawing.Point(510, 28);
            this.lblListWarehouses.Name = "lblListWarehouses";
            this.lblListWarehouses.Size = new System.Drawing.Size(142, 13);
            this.lblListWarehouses.TabIndex = 8;
            this.lblListWarehouses.Text = "List of Warehouse Locations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 617);
            this.Controls.Add(this.lblListWarehouses);
            this.Controls.Add(this.lblCenterOfGravity);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lvwWarehouseLocations);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnCalculateDistances);
            this.Controls.Add(this.btnImportLocations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportLocations;
        private System.Windows.Forms.Button btnCalculateDistances;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.ListView lvwWarehouseLocations;
        private System.Windows.Forms.ColumnHeader colX;
        private System.Windows.Forms.ColumnHeader colY;
        private System.Windows.Forms.ColumnHeader colDistance;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblCenterOfGravity;
        private System.Windows.Forms.Label lblListWarehouses;
    }
}

