namespace MyFirstWindFromsProject
{
    partial class FrmOrderPizza
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.ChkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.ChkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.ChkMushrooms = new System.Windows.Forms.CheckBox();
            this.ChkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbGrustType = new System.Windows.Forms.GroupBox();
            this.rbThinkGrust = new System.Windows.Forms.RadioButton();
            this.rbThinGrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.LblWhereToEat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblGrustType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbGrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(24, 128);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 111);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(16, 84);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Checked = true;
            this.rbMeduim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeduim.Location = new System.Drawing.Point(16, 52);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(76, 20);
            this.rbMeduim.TabIndex = 2;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Medium";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(17, 22);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.ChkGreenPeppers);
            this.gbToppings.Controls.Add(this.ChkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.ChkMushrooms);
            this.gbToppings.Controls.Add(this.ChkExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(291, 127);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(250, 112);
            this.gbToppings.TabIndex = 1;
            this.gbToppings.TabStop = false;
            this.gbToppings.Tag = "5";
            this.gbToppings.Text = "Toppings";
            // 
            // ChkGreenPeppers
            // 
            this.ChkGreenPeppers.AutoSize = true;
            this.ChkGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkGreenPeppers.Location = new System.Drawing.Point(116, 79);
            this.ChkGreenPeppers.Name = "ChkGreenPeppers";
            this.ChkGreenPeppers.Size = new System.Drawing.Size(118, 20);
            this.ChkGreenPeppers.TabIndex = 5;
            this.ChkGreenPeppers.Tag = "5";
            this.ChkGreenPeppers.Text = "GreenPeppers";
            this.ChkGreenPeppers.UseVisualStyleBackColor = true;
            this.ChkGreenPeppers.CheckedChanged += new System.EventHandler(this.ChkGreenPeppers_CheckedChanged);
            // 
            // ChkOlives
            // 
            this.ChkOlives.AutoSize = true;
            this.ChkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkOlives.Location = new System.Drawing.Point(116, 51);
            this.ChkOlives.Name = "ChkOlives";
            this.ChkOlives.Size = new System.Drawing.Size(67, 20);
            this.ChkOlives.TabIndex = 4;
            this.ChkOlives.Tag = "5";
            this.ChkOlives.Text = "Olives";
            this.ChkOlives.UseVisualStyleBackColor = true;
            this.ChkOlives.CheckedChanged += new System.EventHandler(this.ChkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(116, 23);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(6, 77);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(91, 20);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // ChkMushrooms
            // 
            this.ChkMushrooms.AutoSize = true;
            this.ChkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMushrooms.Location = new System.Drawing.Point(6, 49);
            this.ChkMushrooms.Name = "ChkMushrooms";
            this.ChkMushrooms.Size = new System.Drawing.Size(99, 20);
            this.ChkMushrooms.TabIndex = 1;
            this.ChkMushrooms.Tag = "5";
            this.ChkMushrooms.Text = "Mushrooms";
            this.ChkMushrooms.UseVisualStyleBackColor = true;
            this.ChkMushrooms.CheckedChanged += new System.EventHandler(this.ChkMushrooms_CheckedChanged);
            // 
            // ChkExtraChees
            // 
            this.ChkExtraChees.AutoSize = true;
            this.ChkExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkExtraChees.Location = new System.Drawing.Point(6, 23);
            this.ChkExtraChees.Name = "ChkExtraChees";
            this.ChkExtraChees.Size = new System.Drawing.Size(101, 20);
            this.ChkExtraChees.TabIndex = 0;
            this.ChkExtraChees.Tag = "5";
            this.ChkExtraChees.Text = "Extra Chees";
            this.ChkExtraChees.UseVisualStyleBackColor = true;
            this.ChkExtraChees.CheckedChanged += new System.EventHandler(this.ChkExtraChees_CheckedChanged);
            // 
            // gbGrustType
            // 
            this.gbGrustType.Controls.Add(this.rbThinkGrust);
            this.gbGrustType.Controls.Add(this.rbThinGrust);
            this.gbGrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGrustType.Location = new System.Drawing.Point(24, 311);
            this.gbGrustType.Name = "gbGrustType";
            this.gbGrustType.Size = new System.Drawing.Size(200, 111);
            this.gbGrustType.TabIndex = 4;
            this.gbGrustType.TabStop = false;
            this.gbGrustType.Text = "Grust Type";
            // 
            // rbThinkGrust
            // 
            this.rbThinkGrust.AutoSize = true;
            this.rbThinkGrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinkGrust.Location = new System.Drawing.Point(17, 75);
            this.rbThinkGrust.Name = "rbThinkGrust";
            this.rbThinkGrust.Size = new System.Drawing.Size(95, 20);
            this.rbThinkGrust.TabIndex = 5;
            this.rbThinkGrust.Tag = "10";
            this.rbThinkGrust.Text = "Think Grust";
            this.rbThinkGrust.UseVisualStyleBackColor = true;
            this.rbThinkGrust.CheckedChanged += new System.EventHandler(this.rbThinkGrust_CheckedChanged);
            // 
            // rbThinGrust
            // 
            this.rbThinGrust.AutoSize = true;
            this.rbThinGrust.Checked = true;
            this.rbThinGrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinGrust.Location = new System.Drawing.Point(16, 39);
            this.rbThinGrust.Name = "rbThinGrust";
            this.rbThinGrust.Size = new System.Drawing.Size(88, 20);
            this.rbThinGrust.TabIndex = 4;
            this.rbThinGrust.TabStop = true;
            this.rbThinGrust.Tag = "0";
            this.rbThinGrust.Text = "Thin Grust";
            this.rbThinGrust.UseVisualStyleBackColor = true;
            this.rbThinGrust.CheckedChanged += new System.EventHandler(this.rbThinGrust_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(291, 322);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(200, 111);
            this.gbWhereToEat.TabIndex = 6;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "WhereToEat";
           // this.gbWhereToEat.Enter += new System.EventHandler(this.gbWhereToEat_Enter);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(17, 75);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rbTakeOut.TabIndex = 5;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Tag = "0";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(16, 39);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 4;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Tag = "0";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTotalPrice);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.LblWhereToEat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LblGrustType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblToppings);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(630, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 466);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.LblTotalPrice.Location = new System.Drawing.Point(135, 424);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(53, 38);
            this.LblTotalPrice.TabIndex = 13;
            this.LblTotalPrice.Text = "$0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(47, 386);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 20);
            this.label.TabIndex = 8;
            this.label.Text = "Total Price:";
            // 
            // LblWhereToEat
            // 
            this.LblWhereToEat.AutoSize = true;
            this.LblWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWhereToEat.ForeColor = System.Drawing.Color.Black;
            this.LblWhereToEat.Location = new System.Drawing.Point(118, 329);
            this.LblWhereToEat.Name = "LblWhereToEat";
            this.LblWhereToEat.Size = new System.Drawing.Size(52, 20);
            this.LblWhereToEat.TabIndex = 11;
            this.LblWhereToEat.Text = "Eat In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(43, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Where To Eat:";
            // 
            // LblGrustType
            // 
            this.LblGrustType.AutoSize = true;
            this.LblGrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrustType.ForeColor = System.Drawing.Color.Black;
            this.LblGrustType.Location = new System.Drawing.Point(138, 210);
            this.LblGrustType.Name = "LblGrustType";
            this.LblGrustType.Size = new System.Drawing.Size(96, 20);
            this.LblGrustType.TabIndex = 8;
            this.LblGrustType.Text = "Think Grust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(19, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grust Type:";
            // 
            // lblToppings
            // 
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.Black;
            this.lblToppings.Location = new System.Drawing.Point(29, 144);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(317, 45);
            this.lblToppings.TabIndex = 9;
            this.lblToppings.Text = "NoToppings.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Toppings:";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSize.ForeColor = System.Drawing.Color.Black;
            this.LblSize.Location = new System.Drawing.Point(92, 54);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(68, 20);
            this.LblSize.TabIndex = 1;
            this.LblSize.Text = "Meduim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(111, 459);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(99, 32);
            this.btnOrderPizza.TabIndex = 8;
            this.btnOrderPizza.Text = "OrderPizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "ResetForm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(47, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(556, 71);
            this.label4.TabIndex = 10;
            this.label4.Text = "MAKE YOUR PIZZA";
            // 
            // FrmOrderPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1105, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbGrustType);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Name = "FrmOrderPizza";
            this.Text = "order pizza";
            this.Load += new System.EventHandler(this.FrmOrderPizza_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbGrustType.ResumeLayout(false);
            this.gbGrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox ChkExtraChees;
        private System.Windows.Forms.CheckBox ChkGreenPeppers;
        private System.Windows.Forms.CheckBox ChkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox ChkMushrooms;
        private System.Windows.Forms.GroupBox gbGrustType;
        private System.Windows.Forms.RadioButton rbThinkGrust;
        private System.Windows.Forms.RadioButton rbThinGrust;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblGrustType;
        private System.Windows.Forms.Label LblWhereToEat;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSmall;
    }
}