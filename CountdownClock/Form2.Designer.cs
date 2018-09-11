namespace CountdownClock
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbDays = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circleMinutes = new CircularProgressBar.CircularProgressBar();
            this.lbTitel = new System.Windows.Forms.Label();
            this.circleSeconds = new CircularProgressBar.CircularProgressBar();
            this.circleDays = new CircularProgressBar.CircularProgressBar();
            this.circleHours = new CircularProgressBar.CircularProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbSeconds);
            this.panel1.Controls.Add(this.lbMinutes);
            this.panel1.Controls.Add(this.lbHours);
            this.panel1.Controls.Add(this.lbDays);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.circleMinutes);
            this.panel1.Controls.Add(this.lbTitel);
            this.panel1.Controls.Add(this.circleSeconds);
            this.panel1.Controls.Add(this.circleDays);
            this.panel1.Controls.Add(this.circleHours);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 356);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AccessibleName = "btnNext";
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(-3, 319);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(120, 30);
            this.bunifuCustomLabel1.TabIndex = 22;
            this.bunifuCustomLabel1.Text = "Version 1.1.7";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AccessibleName = "btnNext";
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(765, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Contact Us";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSeconds
            // 
            this.lbSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lbSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSeconds.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeconds.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbSeconds.Location = new System.Drawing.Point(732, 129);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(57, 38);
            this.lbSeconds.TabIndex = 19;
            this.lbSeconds.Text = "09";
            this.lbSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSeconds.Click += new System.EventHandler(this.lbSeconds_Click);
            // 
            // lbMinutes
            // 
            this.lbMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.BackColor = System.Drawing.Color.Transparent;
            this.lbMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMinutes.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutes.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbMinutes.Location = new System.Drawing.Point(520, 129);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(57, 38);
            this.lbMinutes.TabIndex = 18;
            this.lbMinutes.Text = "09";
            this.lbMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMinutes.Click += new System.EventHandler(this.lbMinutes_Click);
            // 
            // lbHours
            // 
            this.lbHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHours.AutoSize = true;
            this.lbHours.BackColor = System.Drawing.Color.Transparent;
            this.lbHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHours.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbHours.Location = new System.Drawing.Point(297, 129);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(57, 38);
            this.lbHours.TabIndex = 17;
            this.lbHours.Text = "09";
            this.lbHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDays
            // 
            this.lbDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDays.AutoSize = true;
            this.lbDays.BackColor = System.Drawing.Color.Transparent;
            this.lbDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDays.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbDays.Location = new System.Drawing.Point(73, 129);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(77, 38);
            this.lbDays.TabIndex = 16;
            this.lbDays.Text = "099";
            this.lbDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(711, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Senconds";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(501, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Minutes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hours";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Days";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // circleMinutes
            // 
            this.circleMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
          //  this.circleMinutes.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleMinutes.AnimationSpeed = 500;
            this.circleMinutes.BackColor = System.Drawing.Color.Transparent;
            this.circleMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circleMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleMinutes.InnerColor = System.Drawing.Color.Transparent;
            this.circleMinutes.InnerMargin = 2;
            this.circleMinutes.InnerWidth = -1;
            this.circleMinutes.Location = new System.Drawing.Point(457, 58);
            this.circleMinutes.MarqueeAnimationSpeed = 2000;
            this.circleMinutes.Maximum = 59;
            this.circleMinutes.Name = "circleMinutes";
            this.circleMinutes.OuterColor = System.Drawing.Color.White;
            this.circleMinutes.OuterMargin = -25;
            this.circleMinutes.OuterWidth = 26;
            this.circleMinutes.ProgressColor = System.Drawing.Color.MediumPurple;
            this.circleMinutes.ProgressWidth = 8;
            this.circleMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleMinutes.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circleMinutes.Size = new System.Drawing.Size(175, 175);
            this.circleMinutes.StartAngle = 270;
            this.circleMinutes.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleMinutes.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circleMinutes.SubscriptText = ".23";
            this.circleMinutes.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleMinutes.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circleMinutes.SuperscriptText = "°C";
            this.circleMinutes.TabIndex = 10;
            this.circleMinutes.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circleMinutes.Value = 30;
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.BackColor = System.Drawing.Color.SeaGreen;
            this.lbTitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitel.ForeColor = System.Drawing.Color.White;
            this.lbTitel.Location = new System.Drawing.Point(29, 18);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(64, 25);
            this.lbTitel.TabIndex = 7;
            this.lbTitel.Text = "Event";
            this.lbTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // circleSeconds
            // 
            this.circleSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
           // this.circleSeconds.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleSeconds.AnimationSpeed = 500;
            this.circleSeconds.BackColor = System.Drawing.Color.Transparent;
            this.circleSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circleSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleSeconds.InnerColor = System.Drawing.Color.Transparent;
            this.circleSeconds.InnerMargin = 2;
            this.circleSeconds.InnerWidth = -1;
            this.circleSeconds.Location = new System.Drawing.Point(672, 58);
            this.circleSeconds.MarqueeAnimationSpeed = 2000;
            this.circleSeconds.Maximum = 59;
            this.circleSeconds.Name = "circleSeconds";
            this.circleSeconds.OuterColor = System.Drawing.Color.White;
            this.circleSeconds.OuterMargin = -25;
            this.circleSeconds.OuterWidth = 26;
            this.circleSeconds.ProgressColor = System.Drawing.Color.Aqua;
            this.circleSeconds.ProgressWidth = 8;
            this.circleSeconds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleSeconds.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circleSeconds.Size = new System.Drawing.Size(175, 175);
            this.circleSeconds.StartAngle = 270;
            this.circleSeconds.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleSeconds.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circleSeconds.SubscriptText = ".23";
            this.circleSeconds.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleSeconds.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circleSeconds.SuperscriptText = "°C";
            this.circleSeconds.TabIndex = 11;
            this.circleSeconds.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circleSeconds.Value = 30;
            // 
            // circleDays
            // 
            this.circleDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
           // this.circleDays.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleDays.AnimationSpeed = 500;
            this.circleDays.BackColor = System.Drawing.Color.Transparent;
            this.circleDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circleDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleDays.InnerColor = System.Drawing.Color.Transparent;
            this.circleDays.InnerMargin = 2;
            this.circleDays.InnerWidth = -1;
            this.circleDays.Location = new System.Drawing.Point(23, 58);
            this.circleDays.MarqueeAnimationSpeed = 2000;
            this.circleDays.Maximum = 59;
            this.circleDays.Name = "circleDays";
            this.circleDays.OuterColor = System.Drawing.Color.White;
            this.circleDays.OuterMargin = -25;
            this.circleDays.OuterWidth = 26;
            this.circleDays.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.circleDays.ProgressWidth = 8;
            this.circleDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleDays.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circleDays.Size = new System.Drawing.Size(175, 175);
            this.circleDays.StartAngle = 270;
            this.circleDays.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleDays.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circleDays.SubscriptText = ".23";
            this.circleDays.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleDays.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circleDays.SuperscriptText = "°C";
            this.circleDays.TabIndex = 9;
            this.circleDays.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circleDays.Value = 30;
            this.circleDays.Click += new System.EventHandler(this.circularProgressBar2_Click);
            // 
            // circleHours
            // 
            this.circleHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
           // this.circleHours.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleHours.AnimationSpeed = 500;
            this.circleHours.BackColor = System.Drawing.Color.Transparent;
            this.circleHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circleHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleHours.InnerColor = System.Drawing.Color.Transparent;
            this.circleHours.InnerMargin = 2;
            this.circleHours.InnerWidth = -1;
            this.circleHours.Location = new System.Drawing.Point(237, 58);
            this.circleHours.MarqueeAnimationSpeed = 2000;
            this.circleHours.Maximum = 59;
            this.circleHours.Name = "circleHours";
            this.circleHours.OuterColor = System.Drawing.Color.White;
            this.circleHours.OuterMargin = -25;
            this.circleHours.OuterWidth = 26;
            this.circleHours.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circleHours.ProgressWidth = 8;
            this.circleHours.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleHours.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circleHours.Size = new System.Drawing.Size(175, 175);
            this.circleHours.StartAngle = 270;
            this.circleHours.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleHours.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circleHours.SubscriptText = ".23";
            this.circleHours.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleHours.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circleHours.SuperscriptText = "°C";
            this.circleHours.TabIndex = 8;
            this.circleHours.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circleHours.Value = 30;
            this.circleHours.Click += new System.EventHandler(this.circleHours_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(865, 350);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar circleMinutes;
        private System.Windows.Forms.Label lbTitel;
        private CircularProgressBar.CircularProgressBar circleSeconds;
        private CircularProgressBar.CircularProgressBar circleDays;
        private CircularProgressBar.CircularProgressBar circleHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbDays;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button button1;
    }
}