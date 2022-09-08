namespace blackjack
{
    partial class blackjack
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label7;
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameLabel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.p2winsCounter = new System.Windows.Forms.Label();
            this.p1winsCounter = new System.Windows.Forms.Label();
            this.waitLabel = new System.Windows.Forms.Label();
            this.revenge = new System.Windows.Forms.Button();
            this.player2 = new System.Windows.Forms.Panel();
            this.enemy2 = new System.Windows.Forms.Label();
            this.p2result = new System.Windows.Forms.Label();
            this.enemy3 = new System.Windows.Forms.Label();
            this.enemy1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Panel();
            this.action1number = new System.Windows.Forms.Label();
            this.action2number = new System.Windows.Forms.Label();
            this.action3 = new System.Windows.Forms.Button();
            this.p1result = new System.Windows.Forms.Label();
            this.p1r2Dice2 = new System.Windows.Forms.RadioButton();
            this.p1r2Dice1 = new System.Windows.Forms.RadioButton();
            this.action2 = new System.Windows.Forms.Button();
            this.action1 = new System.Windows.Forms.Button();
            this.p1score = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.action2Separator = new System.Windows.Forms.Label();
            this.p1r1Dice2 = new System.Windows.Forms.Label();
            this.action1separator = new System.Windows.Forms.Label();
            this.p1r1Dice1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.player1Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.send = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.connect = new System.Windows.Forms.Button();
            this.nick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gameLabel.SuspendLayout();
            this.player2.SuspendLayout();
            this.player1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(15, 15);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(96, 27);
            label7.TabIndex = 0;
            label7.Text = "Gracz 2 :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.gameLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.connect);
            this.panel1.Controls.Add(this.nick);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.port);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.MaximumSize = new System.Drawing.Size(1278, 718);
            this.panel1.MinimumSize = new System.Drawing.Size(1278, 718);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 718);
            this.panel1.TabIndex = 0;
            // 
            // gameLabel
            // 
            this.gameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.gameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameLabel.Controls.Add(this.label10);
            this.gameLabel.Controls.Add(this.p2winsCounter);
            this.gameLabel.Controls.Add(this.p1winsCounter);
            this.gameLabel.Controls.Add(this.waitLabel);
            this.gameLabel.Controls.Add(this.revenge);
            this.gameLabel.Controls.Add(this.player2);
            this.gameLabel.Controls.Add(this.player1);
            this.gameLabel.Controls.Add(this.dice2);
            this.gameLabel.Controls.Add(this.dice1);
            this.gameLabel.Location = new System.Drawing.Point(45, 70);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(750, 600);
            this.gameLabel.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(311, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 27);
            this.label10.TabIndex = 27;
            this.label10.Text = "WYGRANE";
            // 
            // p2winsCounter
            // 
            this.p2winsCounter.AutoSize = true;
            this.p2winsCounter.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p2winsCounter.ForeColor = System.Drawing.Color.White;
            this.p2winsCounter.Location = new System.Drawing.Point(513, 557);
            this.p2winsCounter.Name = "p2winsCounter";
            this.p2winsCounter.Size = new System.Drawing.Size(28, 31);
            this.p2winsCounter.TabIndex = 26;
            this.p2winsCounter.Text = "0";
            // 
            // p1winsCounter
            // 
            this.p1winsCounter.AutoSize = true;
            this.p1winsCounter.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1winsCounter.ForeColor = System.Drawing.Color.White;
            this.p1winsCounter.Location = new System.Drawing.Point(180, 557);
            this.p1winsCounter.Name = "p1winsCounter";
            this.p1winsCounter.Size = new System.Drawing.Size(28, 31);
            this.p1winsCounter.TabIndex = 25;
            this.p1winsCounter.Text = "0";
            // 
            // waitLabel
            // 
            this.waitLabel.AutoSize = true;
            this.waitLabel.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.waitLabel.ForeColor = System.Drawing.Color.White;
            this.waitLabel.Location = new System.Drawing.Point(351, 340);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(21, 198);
            this.waitLabel.TabIndex = 24;
            this.waitLabel.Text = "C\r\nZ\r\nE\r\nK\r\nA\r\nJ\r\n.\r\n.\r\n.";
            this.waitLabel.Visible = false;
            // 
            // revenge
            // 
            this.revenge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.revenge.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.revenge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.revenge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.revenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revenge.Font = new System.Drawing.Font("Alef", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.revenge.ForeColor = System.Drawing.Color.White;
            this.revenge.Location = new System.Drawing.Point(330, 323);
            this.revenge.Name = "revenge";
            this.revenge.Size = new System.Drawing.Size(66, 229);
            this.revenge.TabIndex = 23;
            this.revenge.Text = "R\r\nE\r\nW\r\nA\r\nN\r\nŻ";
            this.revenge.UseVisualStyleBackColor = false;
            this.revenge.Visible = false;
            this.revenge.Click += new System.EventHandler(this.revenge_Click);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.player2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player2.Controls.Add(this.enemy2);
            this.player2.Controls.Add(this.p2result);
            this.player2.Controls.Add(this.enemy3);
            this.player2.Controls.Add(this.enemy1);
            this.player2.Controls.Add(this.label16);
            this.player2.Controls.Add(this.label15);
            this.player2.Controls.Add(this.label14);
            this.player2.Controls.Add(this.player2Name);
            this.player2.Controls.Add(this.label6);
            this.player2.Controls.Add(label7);
            this.player2.Location = new System.Drawing.Point(402, 323);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(255, 229);
            this.player2.TabIndex = 4;
            // 
            // enemy2
            // 
            this.enemy2.Cursor = System.Windows.Forms.Cursors.Default;
            this.enemy2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemy2.ForeColor = System.Drawing.Color.LightGreen;
            this.enemy2.Location = new System.Drawing.Point(86, 82);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(30, 23);
            this.enemy2.TabIndex = 22;
            this.enemy2.Text = "0";
            this.enemy2.Visible = false;
            // 
            // p2result
            // 
            this.p2result.AutoSize = true;
            this.p2result.Font = new System.Drawing.Font("Alef", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p2result.ForeColor = System.Drawing.Color.Red;
            this.p2result.Location = new System.Drawing.Point(13, 158);
            this.p2result.Name = "p2result";
            this.p2result.Size = new System.Drawing.Size(192, 42);
            this.p2result.TabIndex = 21;
            this.p2result.Text = "Przegrałeś!";
            this.p2result.Visible = false;
            // 
            // enemy3
            // 
            this.enemy3.AutoSize = true;
            this.enemy3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemy3.ForeColor = System.Drawing.Color.LightGreen;
            this.enemy3.Location = new System.Drawing.Point(86, 112);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(20, 23);
            this.enemy3.TabIndex = 17;
            this.enemy3.Text = "0";
            this.enemy3.Visible = false;
            // 
            // enemy1
            // 
            this.enemy1.AutoSize = true;
            this.enemy1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemy1.ForeColor = System.Drawing.Color.LightGreen;
            this.enemy1.Location = new System.Drawing.Point(86, 52);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(20, 23);
            this.enemy1.TabIndex = 15;
            this.enemy1.Text = "0";
            this.enemy1.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(12, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 27);
            this.label16.TabIndex = 14;
            this.label16.Text = "Wynik :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 27);
            this.label15.TabIndex = 14;
            this.label15.Text = "Rzut 2 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 27);
            this.label14.TabIndex = 14;
            this.label14.Text = "Rzut 1 :";
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2Name.ForeColor = System.Drawing.Color.LightGreen;
            this.player2Name.Location = new System.Drawing.Point(102, 15);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(156, 27);
            this.player2Name.TabIndex = 2;
            this.player2Name.Text = "Oczekiwanie...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.player1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player1.Controls.Add(this.action1number);
            this.player1.Controls.Add(this.action2number);
            this.player1.Controls.Add(this.action3);
            this.player1.Controls.Add(this.p1result);
            this.player1.Controls.Add(this.p1r2Dice2);
            this.player1.Controls.Add(this.p1r2Dice1);
            this.player1.Controls.Add(this.action2);
            this.player1.Controls.Add(this.action1);
            this.player1.Controls.Add(this.p1score);
            this.player1.Controls.Add(this.label12);
            this.player1.Controls.Add(this.action2Separator);
            this.player1.Controls.Add(this.p1r1Dice2);
            this.player1.Controls.Add(this.action1separator);
            this.player1.Controls.Add(this.p1r1Dice1);
            this.player1.Controls.Add(this.label9);
            this.player1.Controls.Add(this.label8);
            this.player1.Controls.Add(this.player1Name);
            this.player1.Controls.Add(this.label5);
            this.player1.Location = new System.Drawing.Point(69, 323);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(255, 229);
            this.player1.TabIndex = 3;
            // 
            // action1number
            // 
            this.action1number.AutoSize = true;
            this.action1number.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.action1number.ForeColor = System.Drawing.Color.LightGreen;
            this.action1number.Location = new System.Drawing.Point(86, 55);
            this.action1number.Name = "action1number";
            this.action1number.Size = new System.Drawing.Size(20, 23);
            this.action1number.TabIndex = 21;
            this.action1number.Text = "0";
            this.action1number.Visible = false;
            // 
            // action2number
            // 
            this.action2number.AutoSize = true;
            this.action2number.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.action2number.ForeColor = System.Drawing.Color.LightGreen;
            this.action2number.Location = new System.Drawing.Point(86, 83);
            this.action2number.Name = "action2number";
            this.action2number.Size = new System.Drawing.Size(20, 23);
            this.action2number.TabIndex = 20;
            this.action2number.Text = "0";
            this.action2number.Visible = false;
            // 
            // action3
            // 
            this.action3.Enabled = false;
            this.action3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.action3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.action3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.action3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action3.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.action3.ForeColor = System.Drawing.Color.White;
            this.action3.Location = new System.Drawing.Point(168, 110);
            this.action3.Name = "action3";
            this.action3.Size = new System.Drawing.Size(75, 25);
            this.action3.TabIndex = 19;
            this.action3.Text = "Zatwierdź";
            this.action3.UseVisualStyleBackColor = true;
            this.action3.Click += new System.EventHandler(this.action3_Click);
            // 
            // p1result
            // 
            this.p1result.AutoSize = true;
            this.p1result.Font = new System.Drawing.Font("Alef", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1result.ForeColor = System.Drawing.Color.LightGreen;
            this.p1result.Location = new System.Drawing.Point(9, 158);
            this.p1result.Name = "p1result";
            this.p1result.Size = new System.Drawing.Size(170, 42);
            this.p1result.TabIndex = 18;
            this.p1result.Text = "Wygrałeś!";
            this.p1result.Visible = false;
            // 
            // p1r2Dice2
            // 
            this.p1r2Dice2.AutoSize = true;
            this.p1r2Dice2.Enabled = false;
            this.p1r2Dice2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1r2Dice2.ForeColor = System.Drawing.Color.LightGreen;
            this.p1r2Dice2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.p1r2Dice2.Location = new System.Drawing.Point(134, 81);
            this.p1r2Dice2.Name = "p1r2Dice2";
            this.p1r2Dice2.Size = new System.Drawing.Size(38, 27);
            this.p1r2Dice2.TabIndex = 17;
            this.p1r2Dice2.TabStop = true;
            this.p1r2Dice2.Text = "0";
            this.p1r2Dice2.UseVisualStyleBackColor = true;
            this.p1r2Dice2.CheckedChanged += new System.EventHandler(this.p1r2Dice2_CheckedChanged);
            // 
            // p1r2Dice1
            // 
            this.p1r2Dice1.AutoSize = true;
            this.p1r2Dice1.Enabled = false;
            this.p1r2Dice1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1r2Dice1.ForeColor = System.Drawing.Color.LightGreen;
            this.p1r2Dice1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.p1r2Dice1.Location = new System.Drawing.Point(90, 81);
            this.p1r2Dice1.Name = "p1r2Dice1";
            this.p1r2Dice1.Size = new System.Drawing.Size(38, 27);
            this.p1r2Dice1.TabIndex = 16;
            this.p1r2Dice1.TabStop = true;
            this.p1r2Dice1.Text = "0";
            this.p1r2Dice1.UseVisualStyleBackColor = true;
            this.p1r2Dice1.CheckedChanged += new System.EventHandler(this.p1r2Dice1_CheckedChanged);
            // 
            // action2
            // 
            this.action2.Enabled = false;
            this.action2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.action2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.action2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.action2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action2.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.action2.ForeColor = System.Drawing.Color.White;
            this.action2.Location = new System.Drawing.Point(178, 80);
            this.action2.Name = "action2";
            this.action2.Size = new System.Drawing.Size(65, 25);
            this.action2.TabIndex = 15;
            this.action2.Text = "Wykonaj";
            this.action2.UseVisualStyleBackColor = true;
            this.action2.Click += new System.EventHandler(this.action2_Click);
            // 
            // action1
            // 
            this.action1.Enabled = false;
            this.action1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.action1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.action1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.action1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action1.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.action1.ForeColor = System.Drawing.Color.White;
            this.action1.Location = new System.Drawing.Point(178, 47);
            this.action1.Name = "action1";
            this.action1.Size = new System.Drawing.Size(65, 25);
            this.action1.TabIndex = 14;
            this.action1.Text = "Wykonaj";
            this.action1.UseVisualStyleBackColor = true;
            this.action1.Click += new System.EventHandler(this.action1_Click);
            // 
            // p1score
            // 
            this.p1score.AutoSize = true;
            this.p1score.Enabled = false;
            this.p1score.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1score.ForeColor = System.Drawing.Color.LightGreen;
            this.p1score.Location = new System.Drawing.Point(89, 112);
            this.p1score.Name = "p1score";
            this.p1score.Size = new System.Drawing.Size(20, 23);
            this.p1score.TabIndex = 13;
            this.p1score.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 27);
            this.label12.TabIndex = 12;
            this.label12.Text = "Wynik :";
            // 
            // action2Separator
            // 
            this.action2Separator.AutoSize = true;
            this.action2Separator.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.action2Separator.ForeColor = System.Drawing.Color.White;
            this.action2Separator.Location = new System.Drawing.Point(120, 81);
            this.action2Separator.Name = "action2Separator";
            this.action2Separator.Size = new System.Drawing.Size(18, 27);
            this.action2Separator.TabIndex = 10;
            this.action2Separator.Text = "|";
            // 
            // p1r1Dice2
            // 
            this.p1r1Dice2.AutoSize = true;
            this.p1r1Dice2.Enabled = false;
            this.p1r1Dice2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1r1Dice2.ForeColor = System.Drawing.Color.LightGreen;
            this.p1r1Dice2.Location = new System.Drawing.Point(121, 54);
            this.p1r1Dice2.Name = "p1r1Dice2";
            this.p1r1Dice2.Size = new System.Drawing.Size(20, 23);
            this.p1r1Dice2.TabIndex = 8;
            this.p1r1Dice2.Text = "0";
            // 
            // action1separator
            // 
            this.action1separator.AutoSize = true;
            this.action1separator.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.action1separator.ForeColor = System.Drawing.Color.White;
            this.action1separator.Location = new System.Drawing.Point(103, 54);
            this.action1separator.Name = "action1separator";
            this.action1separator.Size = new System.Drawing.Size(18, 27);
            this.action1separator.TabIndex = 7;
            this.action1separator.Text = "|";
            // 
            // p1r1Dice1
            // 
            this.p1r1Dice1.AutoSize = true;
            this.p1r1Dice1.Enabled = false;
            this.p1r1Dice1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1r1Dice1.ForeColor = System.Drawing.Color.LightGreen;
            this.p1r1Dice1.Location = new System.Drawing.Point(86, 54);
            this.p1r1Dice1.Name = "p1r1Dice1";
            this.p1r1Dice1.Size = new System.Drawing.Size(20, 23);
            this.p1r1Dice1.TabIndex = 6;
            this.p1r1Dice1.Text = "0";
            this.p1r1Dice1.Click += new System.EventHandler(this.p1r1Dice1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 27);
            this.label9.TabIndex = 5;
            this.label9.Text = "Rzut 2 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rzut 1 :";
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1Name.ForeColor = System.Drawing.Color.LightGreen;
            this.player1Name.Location = new System.Drawing.Point(101, 15);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(156, 27);
            this.player1Name.TabIndex = 3;
            this.player1Name.Text = "Oczekiwanie...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gracz 1 :";
            // 
            // dice2
            // 
            this.dice2.Image = global::blackjack.Properties.Resources.diceForm_resized;
            this.dice2.Location = new System.Drawing.Point(402, 33);
            this.dice2.MaximumSize = new System.Drawing.Size(255, 255);
            this.dice2.MinimumSize = new System.Drawing.Size(255, 255);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(255, 255);
            this.dice2.TabIndex = 1;
            this.dice2.TabStop = false;
            // 
            // dice1
            // 
            this.dice1.Image = global::blackjack.Properties.Resources.diceForm_resized;
            this.dice1.Location = new System.Drawing.Point(69, 33);
            this.dice1.MaximumSize = new System.Drawing.Size(255, 255);
            this.dice1.MinimumSize = new System.Drawing.Size(255, 255);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(255, 255);
            this.dice1.TabIndex = 0;
            this.dice1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Alef", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(933, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "BLACKJACK";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.send);
            this.panel2.Controls.Add(this.messageBox);
            this.panel2.Controls.Add(this.chatBox);
            this.panel2.Font = new System.Drawing.Font("Alef", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(840, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 600);
            this.panel2.TabIndex = 8;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.send.Enabled = false;
            this.send.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Alef", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(321, 515);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(72, 76);
            this.send.TabIndex = 2;
            this.send.Text = "Wyślij";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.messageBox.Font = new System.Drawing.Font("Alef", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageBox.ForeColor = System.Drawing.Color.White;
            this.messageBox.Location = new System.Drawing.Point(4, 515);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(313, 77);
            this.messageBox.TabIndex = 1;
            this.messageBox.Text = "";
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.chatBox.ForeColor = System.Drawing.Color.White;
            this.chatBox.Location = new System.Drawing.Point(4, 4);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.chatBox.Size = new System.Drawing.Size(389, 505);
            this.chatBox.TabIndex = 0;
            this.chatBox.Text = "";
            // 
            // connect
            // 
            this.connect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connect.ForeColor = System.Drawing.Color.White;
            this.connect.Location = new System.Drawing.Point(618, 14);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(150, 35);
            this.connect.TabIndex = 7;
            this.connect.Text = "Połącz:";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // nick
            // 
            this.nick.BackColor = System.Drawing.Color.Black;
            this.nick.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nick.ForeColor = System.Drawing.Color.White;
            this.nick.Location = new System.Drawing.Point(449, 15);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(150, 35);
            this.nick.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Alef", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(377, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nick:";
            // 
            // port
            // 
            this.port.BackColor = System.Drawing.Color.Black;
            this.port.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.port.ForeColor = System.Drawing.Color.White;
            this.port.Location = new System.Drawing.Point(291, 15);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(80, 35);
            this.port.TabIndex = 4;
            this.port.Text = "8888";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alef", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.Black;
            this.address.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(63, 15);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(150, 35);
            this.address.TabIndex = 2;
            this.address.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alef", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("DejaVu Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1238, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.MaximumSize = new System.Drawing.Size(40, 40);
            this.button1.MinimumSize = new System.Drawing.Size(40, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "×";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "blackjack";
            this.Load += new System.EventHandler(this.blackjack_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gameLabel.ResumeLayout(false);
            this.gameLabel.PerformLayout();
            this.player2.ResumeLayout(false);
            this.player2.PerformLayout();
            this.player1.ResumeLayout(false);
            this.player1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel gameLabel;
        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.Panel player2;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel player1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label p1score;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label p1r1Dice2;
        private System.Windows.Forms.Label action1separator;
        private System.Windows.Forms.Label p1r1Dice1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button action2;
        private System.Windows.Forms.Button action1;
        private System.Windows.Forms.RadioButton p1r2Dice2;
        private System.Windows.Forms.RadioButton p1r2Dice1;
        private System.Windows.Forms.Label action2Separator;
        private System.Windows.Forms.Button action3;
        private System.Windows.Forms.Label p1result;
        private System.Windows.Forms.Label action2number;
        private System.Windows.Forms.Label enemy3;
        private System.Windows.Forms.Label enemy1;
        private System.Windows.Forms.Label p2result;
        private System.Windows.Forms.Label enemy2;
        private System.Windows.Forms.Label action1number;
        private System.Windows.Forms.Button revenge;
        private System.Windows.Forms.Label waitLabel;
        private System.Windows.Forms.Label p2winsCounter;
        private System.Windows.Forms.Label p1winsCounter;
        private System.Windows.Forms.Label label10;
    }
}

