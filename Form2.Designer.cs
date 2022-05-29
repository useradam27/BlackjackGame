
namespace Project2
{
    partial class Table_Form
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
            this.reset_button = new System.Windows.Forms.Button();
            this.bet_box = new System.Windows.Forms.TextBox();
            this.money_textbox = new System.Windows.Forms.TextBox();
            this.money_lable = new System.Windows.Forms.Label();
            this.bet_label = new System.Windows.Forms.Label();
            this.play_button = new System.Windows.Forms.Button();
            this.close_table_button = new System.Windows.Forms.Button();
            this.dealer1 = new System.Windows.Forms.RichTextBox();
            this.dealer2 = new System.Windows.Forms.RichTextBox();
            this.dealer3 = new System.Windows.Forms.RichTextBox();
            this.dealer4 = new System.Windows.Forms.RichTextBox();
            this.dealer5 = new System.Windows.Forms.RichTextBox();
            this.dealer6 = new System.Windows.Forms.RichTextBox();
            this.player1 = new System.Windows.Forms.RichTextBox();
            this.player2 = new System.Windows.Forms.RichTextBox();
            this.player3 = new System.Windows.Forms.RichTextBox();
            this.player4 = new System.Windows.Forms.RichTextBox();
            this.player5 = new System.Windows.Forms.RichTextBox();
            this.player6 = new System.Windows.Forms.RichTextBox();
            this.dealer_label = new System.Windows.Forms.Label();
            this.player_label = new System.Windows.Forms.Label();
            this.hit_button = new System.Windows.Forms.Button();
            this.stand_button = new System.Windows.Forms.Button();
            this.dealer_value_box = new System.Windows.Forms.TextBox();
            this.player_value_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stat_box1 = new System.Windows.Forms.Label();
            this.stat_box2 = new System.Windows.Forms.Label();
            this.stat_box3 = new System.Windows.Forms.Label();
            this.table_num = new System.Windows.Forms.Label();
            this.tnum_lable = new System.Windows.Forms.Label();
            this.seed_num = new System.Windows.Forms.Label();
            this.deck_num = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mode_label = new System.Windows.Forms.Label();
            this.output_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(34, 475);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(194, 87);
            this.reset_button.TabIndex = 0;
            this.reset_button.Text = "Reset Deck";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // bet_box
            // 
            this.bet_box.Location = new System.Drawing.Point(68, 327);
            this.bet_box.Name = "bet_box";
            this.bet_box.Size = new System.Drawing.Size(100, 20);
            this.bet_box.TabIndex = 1;
            this.bet_box.Text = "0";
            this.bet_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // money_textbox
            // 
            this.money_textbox.Location = new System.Drawing.Point(68, 196);
            this.money_textbox.Name = "money_textbox";
            this.money_textbox.ReadOnly = true;
            this.money_textbox.Size = new System.Drawing.Size(100, 20);
            this.money_textbox.TabIndex = 2;
            this.money_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // money_lable
            // 
            this.money_lable.AutoSize = true;
            this.money_lable.Location = new System.Drawing.Point(78, 180);
            this.money_lable.Name = "money_lable";
            this.money_lable.Size = new System.Drawing.Size(69, 13);
            this.money_lable.TabIndex = 3;
            this.money_lable.Text = "Total Money:";
            // 
            // bet_label
            // 
            this.bet_label.AutoSize = true;
            this.bet_label.Location = new System.Drawing.Point(100, 311);
            this.bet_label.Name = "bet_label";
            this.bet_label.Size = new System.Drawing.Size(26, 13);
            this.bet_label.TabIndex = 4;
            this.bet_label.Text = "Bet:";
            // 
            // play_button
            // 
            this.play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.Location = new System.Drawing.Point(311, 475);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(189, 87);
            this.play_button.TabIndex = 5;
            this.play_button.Text = "Play Hand!";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // close_table_button
            // 
            this.close_table_button.Location = new System.Drawing.Point(600, 475);
            this.close_table_button.Name = "close_table_button";
            this.close_table_button.Size = new System.Drawing.Size(189, 87);
            this.close_table_button.TabIndex = 6;
            this.close_table_button.Text = "End Table";
            this.close_table_button.UseVisualStyleBackColor = true;
            this.close_table_button.Click += new System.EventHandler(this.close_table_button_Click);
            // 
            // dealer1
            // 
            this.dealer1.Location = new System.Drawing.Point(231, 48);
            this.dealer1.Name = "dealer1";
            this.dealer1.ReadOnly = true;
            this.dealer1.Size = new System.Drawing.Size(100, 96);
            this.dealer1.TabIndex = 7;
            this.dealer1.Text = "";
            // 
            // dealer2
            // 
            this.dealer2.Location = new System.Drawing.Point(337, 48);
            this.dealer2.Name = "dealer2";
            this.dealer2.ReadOnly = true;
            this.dealer2.Size = new System.Drawing.Size(100, 96);
            this.dealer2.TabIndex = 8;
            this.dealer2.Text = "";
            // 
            // dealer3
            // 
            this.dealer3.Location = new System.Drawing.Point(443, 48);
            this.dealer3.Name = "dealer3";
            this.dealer3.ReadOnly = true;
            this.dealer3.Size = new System.Drawing.Size(100, 96);
            this.dealer3.TabIndex = 9;
            this.dealer3.Text = "";
            // 
            // dealer4
            // 
            this.dealer4.Location = new System.Drawing.Point(550, 48);
            this.dealer4.Name = "dealer4";
            this.dealer4.ReadOnly = true;
            this.dealer4.Size = new System.Drawing.Size(100, 96);
            this.dealer4.TabIndex = 10;
            this.dealer4.Text = "";
            // 
            // dealer5
            // 
            this.dealer5.Location = new System.Drawing.Point(657, 48);
            this.dealer5.Name = "dealer5";
            this.dealer5.ReadOnly = true;
            this.dealer5.Size = new System.Drawing.Size(100, 96);
            this.dealer5.TabIndex = 11;
            this.dealer5.Text = "";
            // 
            // dealer6
            // 
            this.dealer6.Location = new System.Drawing.Point(764, 48);
            this.dealer6.Name = "dealer6";
            this.dealer6.ReadOnly = true;
            this.dealer6.Size = new System.Drawing.Size(100, 96);
            this.dealer6.TabIndex = 12;
            this.dealer6.Text = "";
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(231, 255);
            this.player1.Name = "player1";
            this.player1.ReadOnly = true;
            this.player1.Size = new System.Drawing.Size(100, 96);
            this.player1.TabIndex = 13;
            this.player1.Text = "";
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(337, 255);
            this.player2.Name = "player2";
            this.player2.ReadOnly = true;
            this.player2.Size = new System.Drawing.Size(100, 96);
            this.player2.TabIndex = 14;
            this.player2.Text = "";
            // 
            // player3
            // 
            this.player3.Location = new System.Drawing.Point(444, 255);
            this.player3.Name = "player3";
            this.player3.ReadOnly = true;
            this.player3.Size = new System.Drawing.Size(100, 96);
            this.player3.TabIndex = 15;
            this.player3.Text = "";
            // 
            // player4
            // 
            this.player4.Location = new System.Drawing.Point(551, 255);
            this.player4.Name = "player4";
            this.player4.ReadOnly = true;
            this.player4.Size = new System.Drawing.Size(100, 96);
            this.player4.TabIndex = 16;
            this.player4.Text = "";
            // 
            // player5
            // 
            this.player5.Location = new System.Drawing.Point(657, 255);
            this.player5.Name = "player5";
            this.player5.ReadOnly = true;
            this.player5.Size = new System.Drawing.Size(100, 96);
            this.player5.TabIndex = 17;
            this.player5.Text = "";
            // 
            // player6
            // 
            this.player6.Location = new System.Drawing.Point(764, 255);
            this.player6.Name = "player6";
            this.player6.ReadOnly = true;
            this.player6.Size = new System.Drawing.Size(100, 96);
            this.player6.TabIndex = 18;
            this.player6.Text = "";
            // 
            // dealer_label
            // 
            this.dealer_label.AutoSize = true;
            this.dealer_label.Location = new System.Drawing.Point(507, 13);
            this.dealer_label.Name = "dealer_label";
            this.dealer_label.Size = new System.Drawing.Size(41, 13);
            this.dealer_label.TabIndex = 19;
            this.dealer_label.Text = "Dealer:";
            // 
            // player_label
            // 
            this.player_label.AutoSize = true;
            this.player_label.Location = new System.Drawing.Point(510, 221);
            this.player_label.Name = "player_label";
            this.player_label.Size = new System.Drawing.Size(36, 13);
            this.player_label.TabIndex = 20;
            this.player_label.Text = "Player";
            // 
            // hit_button
            // 
            this.hit_button.Location = new System.Drawing.Point(444, 377);
            this.hit_button.Name = "hit_button";
            this.hit_button.Size = new System.Drawing.Size(75, 41);
            this.hit_button.TabIndex = 21;
            this.hit_button.Text = "Hit";
            this.hit_button.UseVisualStyleBackColor = true;
            this.hit_button.Click += new System.EventHandler(this.hit_button_Click);
            // 
            // stand_button
            // 
            this.stand_button.Location = new System.Drawing.Point(571, 377);
            this.stand_button.Name = "stand_button";
            this.stand_button.Size = new System.Drawing.Size(75, 41);
            this.stand_button.TabIndex = 22;
            this.stand_button.Text = "Stand";
            this.stand_button.UseVisualStyleBackColor = true;
            this.stand_button.Click += new System.EventHandler(this.stand_button_Click);
            // 
            // dealer_value_box
            // 
            this.dealer_value_box.Location = new System.Drawing.Point(948, 83);
            this.dealer_value_box.Name = "dealer_value_box";
            this.dealer_value_box.ReadOnly = true;
            this.dealer_value_box.Size = new System.Drawing.Size(100, 20);
            this.dealer_value_box.TabIndex = 23;
            this.dealer_value_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player_value_box
            // 
            this.player_value_box.Location = new System.Drawing.Point(948, 291);
            this.player_value_box.Name = "player_value_box";
            this.player_value_box.ReadOnly = true;
            this.player_value_box.Size = new System.Drawing.Size(100, 20);
            this.player_value_box.TabIndex = 24;
            this.player_value_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(979, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(982, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Value:";
            // 
            // stat_box1
            // 
            this.stat_box1.AutoSize = true;
            this.stat_box1.Location = new System.Drawing.Point(26, 26);
            this.stat_box1.Name = "stat_box1";
            this.stat_box1.Size = new System.Drawing.Size(40, 13);
            this.stat_box1.TabIndex = 27;
            this.stat_box1.Text = "Mode: ";
            // 
            // stat_box2
            // 
            this.stat_box2.AutoSize = true;
            this.stat_box2.Location = new System.Drawing.Point(26, 48);
            this.stat_box2.Name = "stat_box2";
            this.stat_box2.Size = new System.Drawing.Size(38, 13);
            this.stat_box2.TabIndex = 28;
            this.stat_box2.Text = "Seed: ";
            // 
            // stat_box3
            // 
            this.stat_box3.AutoSize = true;
            this.stat_box3.Location = new System.Drawing.Point(26, 67);
            this.stat_box3.Name = "stat_box3";
            this.stat_box3.Size = new System.Drawing.Size(93, 13);
            this.stat_box3.TabIndex = 29;
            this.stat_box3.Text = "Number of Decks:";
            // 
            // table_num
            // 
            this.table_num.AutoSize = true;
            this.table_num.Location = new System.Drawing.Point(26, 9);
            this.table_num.Name = "table_num";
            this.table_num.Size = new System.Drawing.Size(80, 13);
            this.table_num.TabIndex = 30;
            this.table_num.Text = "Table Number: ";
            // 
            // tnum_lable
            // 
            this.tnum_lable.AutoSize = true;
            this.tnum_lable.Location = new System.Drawing.Point(100, 13);
            this.tnum_lable.Name = "tnum_lable";
            this.tnum_lable.Size = new System.Drawing.Size(0, 13);
            this.tnum_lable.TabIndex = 31;
            // 
            // seed_num
            // 
            this.seed_num.AutoSize = true;
            this.seed_num.Location = new System.Drawing.Point(70, 48);
            this.seed_num.Name = "seed_num";
            this.seed_num.Size = new System.Drawing.Size(0, 13);
            this.seed_num.TabIndex = 32;
            // 
            // deck_num
            // 
            this.deck_num.AutoSize = true;
            this.deck_num.Location = new System.Drawing.Point(126, 67);
            this.deck_num.Name = "deck_num";
            this.deck_num.Size = new System.Drawing.Size(0, 13);
            this.deck_num.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 34;
            // 
            // mode_label
            // 
            this.mode_label.AutoSize = true;
            this.mode_label.Location = new System.Drawing.Point(73, 26);
            this.mode_label.Name = "mode_label";
            this.mode_label.Size = new System.Drawing.Size(0, 13);
            this.mode_label.TabIndex = 35;
            // 
            // output_box
            // 
            this.output_box.Location = new System.Drawing.Point(861, 401);
            this.output_box.Name = "output_box";
            this.output_box.ReadOnly = true;
            this.output_box.Size = new System.Drawing.Size(187, 161);
            this.output_box.TabIndex = 36;
            this.output_box.Text = "";
            // 
            // Table_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 588);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.mode_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deck_num);
            this.Controls.Add(this.seed_num);
            this.Controls.Add(this.tnum_lable);
            this.Controls.Add(this.table_num);
            this.Controls.Add(this.stat_box3);
            this.Controls.Add(this.stat_box2);
            this.Controls.Add(this.stat_box1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player_value_box);
            this.Controls.Add(this.dealer_value_box);
            this.Controls.Add(this.stand_button);
            this.Controls.Add(this.hit_button);
            this.Controls.Add(this.player_label);
            this.Controls.Add(this.dealer_label);
            this.Controls.Add(this.player6);
            this.Controls.Add(this.player5);
            this.Controls.Add(this.player4);
            this.Controls.Add(this.player3);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.dealer6);
            this.Controls.Add(this.dealer5);
            this.Controls.Add(this.dealer4);
            this.Controls.Add(this.dealer3);
            this.Controls.Add(this.dealer2);
            this.Controls.Add(this.dealer1);
            this.Controls.Add(this.close_table_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.bet_label);
            this.Controls.Add(this.money_lable);
            this.Controls.Add(this.money_textbox);
            this.Controls.Add(this.bet_box);
            this.Controls.Add(this.reset_button);
            this.Name = "Table_Form";
            this.Text = "Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TextBox bet_box;
        private System.Windows.Forms.TextBox money_textbox;
        private System.Windows.Forms.Label money_lable;
        private System.Windows.Forms.Label bet_label;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button close_table_button;
        private System.Windows.Forms.RichTextBox dealer1;
        private System.Windows.Forms.RichTextBox dealer2;
        private System.Windows.Forms.RichTextBox dealer3;
        private System.Windows.Forms.RichTextBox dealer4;
        private System.Windows.Forms.RichTextBox dealer5;
        private System.Windows.Forms.RichTextBox dealer6;
        private System.Windows.Forms.RichTextBox player1;
        private System.Windows.Forms.RichTextBox player2;
        private System.Windows.Forms.RichTextBox player3;
        private System.Windows.Forms.RichTextBox player4;
        private System.Windows.Forms.RichTextBox player5;
        private System.Windows.Forms.RichTextBox player6;
        private System.Windows.Forms.Label dealer_label;
        private System.Windows.Forms.Label player_label;
        private System.Windows.Forms.Button hit_button;
        private System.Windows.Forms.Button stand_button;
        private System.Windows.Forms.TextBox dealer_value_box;
        private System.Windows.Forms.TextBox player_value_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stat_box1;
        private System.Windows.Forms.Label stat_box2;
        private System.Windows.Forms.Label stat_box3;
        private System.Windows.Forms.Label table_num;
        private System.Windows.Forms.Label tnum_lable;
        private System.Windows.Forms.Label seed_num;
        private System.Windows.Forms.Label deck_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mode_label;
        private System.Windows.Forms.RichTextBox output_box;
    }
}