namespace CarApp
{
    partial class CarFinder
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
            this.Color = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.NumDoors = new System.Windows.Forms.Label();
            this.EngineVolume = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Year_Out = new System.Windows.Forms.Label();
            this.Price_Out = new System.Windows.Forms.Label();
            this.Volume_Out = new System.Windows.Forms.Label();
            this.Doors_Out = new System.Windows.Forms.Label();
            this.Type_Out = new System.Windows.Forms.Label();
            this.Color_Out = new System.Windows.Forms.Label();
            this.FindCar = new System.Windows.Forms.Button();
            this.AddCar = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(12, 9);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(42, 20);
            this.Color.TabIndex = 0;
            this.Color.Text = "Цвет";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(12, 39);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(35, 20);
            this.Type.TabIndex = 1;
            this.Type.Text = "Тип";
            // 
            // NumDoors
            // 
            this.NumDoors.AutoSize = true;
            this.NumDoors.Location = new System.Drawing.Point(12, 69);
            this.NumDoors.Name = "NumDoors";
            this.NumDoors.Size = new System.Drawing.Size(144, 20);
            this.NumDoors.TabIndex = 2;
            this.NumDoors.Text = "Количество дверей";
            // 
            // EngineVolume
            // 
            this.EngineVolume.AutoSize = true;
            this.EngineVolume.Location = new System.Drawing.Point(12, 99);
            this.EngineVolume.Name = "EngineVolume";
            this.EngineVolume.Size = new System.Drawing.Size(130, 20);
            this.EngineVolume.TabIndex = 3;
            this.EngineVolume.Text = "Объём двигателя";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(12, 129);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(45, 20);
            this.Price.TabIndex = 4;
            this.Price.Text = "Цена";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(12, 159);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(94, 20);
            this.Year.TabIndex = 5;
            this.Year.Text = "Год выпуска";
            // 
            // Year_Out
            // 
            this.Year_Out.AutoSize = true;
            this.Year_Out.Location = new System.Drawing.Point(220, 159);
            this.Year_Out.Name = "Year_Out";
            this.Year_Out.Size = new System.Drawing.Size(15, 20);
            this.Year_Out.TabIndex = 11;
            this.Year_Out.Text = "*";
            // 
            // Price_Out
            // 
            this.Price_Out.AutoSize = true;
            this.Price_Out.Location = new System.Drawing.Point(220, 129);
            this.Price_Out.Name = "Price_Out";
            this.Price_Out.Size = new System.Drawing.Size(15, 20);
            this.Price_Out.TabIndex = 10;
            this.Price_Out.Text = "*";
            // 
            // Volume_Out
            // 
            this.Volume_Out.AutoSize = true;
            this.Volume_Out.Location = new System.Drawing.Point(220, 99);
            this.Volume_Out.Name = "Volume_Out";
            this.Volume_Out.Size = new System.Drawing.Size(15, 20);
            this.Volume_Out.TabIndex = 9;
            this.Volume_Out.Text = "*";
            // 
            // Doors_Out
            // 
            this.Doors_Out.AutoSize = true;
            this.Doors_Out.Location = new System.Drawing.Point(220, 69);
            this.Doors_Out.Name = "Doors_Out";
            this.Doors_Out.Size = new System.Drawing.Size(15, 20);
            this.Doors_Out.TabIndex = 8;
            this.Doors_Out.Text = "*";
            // 
            // Type_Out
            // 
            this.Type_Out.AutoSize = true;
            this.Type_Out.Location = new System.Drawing.Point(220, 39);
            this.Type_Out.Name = "Type_Out";
            this.Type_Out.Size = new System.Drawing.Size(15, 20);
            this.Type_Out.TabIndex = 7;
            this.Type_Out.Text = "*";
            // 
            // Color_Out
            // 
            this.Color_Out.AutoSize = true;
            this.Color_Out.Location = new System.Drawing.Point(220, 9);
            this.Color_Out.Name = "Color_Out";
            this.Color_Out.Size = new System.Drawing.Size(15, 20);
            this.Color_Out.TabIndex = 6;
            this.Color_Out.Text = "*";
            // 
            // FindCar
            // 
            this.FindCar.Location = new System.Drawing.Point(12, 261);
            this.FindCar.Name = "FindCar";
            this.FindCar.Size = new System.Drawing.Size(169, 29);
            this.FindCar.TabIndex = 12;
            this.FindCar.Text = "Найти автомобиль";
            this.FindCar.UseVisualStyleBackColor = true;
            this.FindCar.Click += new System.EventHandler(this.FindCar_Click);
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(187, 261);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(187, 29);
            this.AddCar.TabIndex = 13;
            this.AddCar.Text = "Добавить автомобиль";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(12, 209);
            this.idBox.Name = "idBox";
            this.idBox.PlaceholderText = "Введите ID...";
            this.idBox.Size = new System.Drawing.Size(125, 27);
            this.idBox.TabIndex = 14;
            this.idBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.idBox_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Показать владельца";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.FindCar);
            this.Controls.Add(this.Year_Out);
            this.Controls.Add(this.Price_Out);
            this.Controls.Add(this.Volume_Out);
            this.Controls.Add(this.Doors_Out);
            this.Controls.Add(this.Type_Out);
            this.Controls.Add(this.Color_Out);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.EngineVolume);
            this.Controls.Add(this.NumDoors);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Color);
            this.Name = "CarFinder";
            this.Text = "Поиск транспорта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Color;
        private Label Type;
        private Label NumDoors;
        private Label EngineVolume;
        private Label Price;
        private Label Year;
        private Label Year_Out;
        private Label Price_Out;
        private Label Volume_Out;
        private Label Doors_Out;
        private Label Type_Out;
        private Label Color_Out;
        private Button FindCar;
        private Button AddCar;
        private TextBox idBox;
        private Button button1;
    }
}