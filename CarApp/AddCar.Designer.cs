namespace CarApp
{
    partial class AddCar
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
            this.Year = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.EngineVolume = new System.Windows.Forms.Label();
            this.NumDoors = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.Color_Write = new System.Windows.Forms.TextBox();
            this.Type_Write = new System.Windows.Forms.TextBox();
            this.Doors_Write = new System.Windows.Forms.TextBox();
            this.Volume_Write = new System.Windows.Forms.TextBox();
            this.Price_Write = new System.Windows.Forms.TextBox();
            this.Year_Write = new System.Windows.Forms.TextBox();
            this.Write_Car = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(12, 159);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(94, 20);
            this.Year.TabIndex = 11;
            this.Year.Text = "Год выпуска";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(12, 129);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(45, 20);
            this.Price.TabIndex = 10;
            this.Price.Text = "Цена";
            // 
            // EngineVolume
            // 
            this.EngineVolume.AutoSize = true;
            this.EngineVolume.Location = new System.Drawing.Point(12, 99);
            this.EngineVolume.Name = "EngineVolume";
            this.EngineVolume.Size = new System.Drawing.Size(130, 20);
            this.EngineVolume.TabIndex = 9;
            this.EngineVolume.Text = "Объём двигателя";
            // 
            // NumDoors
            // 
            this.NumDoors.AutoSize = true;
            this.NumDoors.Location = new System.Drawing.Point(12, 69);
            this.NumDoors.Name = "NumDoors";
            this.NumDoors.Size = new System.Drawing.Size(144, 20);
            this.NumDoors.TabIndex = 8;
            this.NumDoors.Text = "Количество дверей";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(12, 39);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(35, 20);
            this.Type.TabIndex = 7;
            this.Type.Text = "Тип";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(12, 9);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(42, 20);
            this.Color.TabIndex = 6;
            this.Color.Text = "Цвет";
            // 
            // Color_Write
            // 
            this.Color_Write.Location = new System.Drawing.Point(189, 6);
            this.Color_Write.Name = "Color_Write";
            this.Color_Write.Size = new System.Drawing.Size(125, 27);
            this.Color_Write.TabIndex = 12;
            this.Color_Write.Validating += new System.ComponentModel.CancelEventHandler(this.Color_Write_Validating);
            // 
            // Type_Write
            // 
            this.Type_Write.Location = new System.Drawing.Point(189, 36);
            this.Type_Write.Name = "Type_Write";
            this.Type_Write.Size = new System.Drawing.Size(125, 27);
            this.Type_Write.TabIndex = 13;
            this.Type_Write.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Type_Write_MouseClick);
            // 
            // Doors_Write
            // 
            this.Doors_Write.Location = new System.Drawing.Point(189, 66);
            this.Doors_Write.Name = "Doors_Write";
            this.Doors_Write.Size = new System.Drawing.Size(125, 27);
            this.Doors_Write.TabIndex = 14;
            // 
            // Volume_Write
            // 
            this.Volume_Write.Location = new System.Drawing.Point(189, 96);
            this.Volume_Write.Name = "Volume_Write";
            this.Volume_Write.Size = new System.Drawing.Size(125, 27);
            this.Volume_Write.TabIndex = 15;
            // 
            // Price_Write
            // 
            this.Price_Write.Location = new System.Drawing.Point(189, 126);
            this.Price_Write.Name = "Price_Write";
            this.Price_Write.Size = new System.Drawing.Size(125, 27);
            this.Price_Write.TabIndex = 16;
            // 
            // Year_Write
            // 
            this.Year_Write.Location = new System.Drawing.Point(189, 156);
            this.Year_Write.Name = "Year_Write";
            this.Year_Write.Size = new System.Drawing.Size(125, 27);
            this.Year_Write.TabIndex = 17;
            // 
            // Write_Car
            // 
            this.Write_Car.Location = new System.Drawing.Point(81, 261);
            this.Write_Car.Name = "Write_Car";
            this.Write_Car.Size = new System.Drawing.Size(163, 29);
            this.Write_Car.TabIndex = 18;
            this.Write_Car.Text = "Создать запись";
            this.Write_Car.UseVisualStyleBackColor = true;
            this.Write_Car.Click += new System.EventHandler(this.Write_Car_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 321);
            this.Controls.Add(this.Write_Car);
            this.Controls.Add(this.Year_Write);
            this.Controls.Add(this.Price_Write);
            this.Controls.Add(this.Volume_Write);
            this.Controls.Add(this.Doors_Write);
            this.Controls.Add(this.Type_Write);
            this.Controls.Add(this.Color_Write);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.EngineVolume);
            this.Controls.Add(this.NumDoors);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Color);
            this.Name = "AddCar";
            this.Text = "AddCar";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Year;
        private Label Price;
        private Label EngineVolume;
        private Label NumDoors;
        private Label Type;
        private Label Color;
        private TextBox Color_Write;
        private TextBox Type_Write;
        private TextBox Doors_Write;
        private TextBox Volume_Write;
        private TextBox Price_Write;
        private TextBox Year_Write;
        private Button Write_Car;
        private ErrorProvider errorProvider1;
    }
}