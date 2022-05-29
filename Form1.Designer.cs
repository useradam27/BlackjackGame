
namespace Project2
{
    partial class Menu_Form
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
            this.seed_box = new System.Windows.Forms.TextBox();
            this.create_table_button = new System.Windows.Forms.Button();
            this.end_game_button = new System.Windows.Forms.Button();
            this.decks_label = new System.Windows.Forms.Label();
            this.seed_label = new System.Windows.Forms.Label();
            this.mode_checkbox = new System.Windows.Forms.CheckBox();
            this.table_label = new System.Windows.Forms.Label();
            table_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deck_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // seed_box
            // 
            this.seed_box.Location = new System.Drawing.Point(156, 114);
            this.seed_box.Name = "seed_box";
            this.seed_box.Size = new System.Drawing.Size(100, 20);
            this.seed_box.TabIndex = 1;
            this.seed_box.Text = "999";
            this.seed_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // create_table_button
            // 
            this.create_table_button.Location = new System.Drawing.Point(90, 219);
            this.create_table_button.Name = "create_table_button";
            this.create_table_button.Size = new System.Drawing.Size(75, 23);
            this.create_table_button.TabIndex = 2;
            this.create_table_button.Text = "New Table";
            this.create_table_button.UseVisualStyleBackColor = true;
            this.create_table_button.Click += new System.EventHandler(this.create_table_button_Click);
            // 
            // end_game_button
            // 
            this.end_game_button.Location = new System.Drawing.Point(90, 286);
            this.end_game_button.Name = "end_game_button";
            this.end_game_button.Size = new System.Drawing.Size(75, 23);
            this.end_game_button.TabIndex = 3;
            this.end_game_button.Text = "End Game";
            this.end_game_button.UseVisualStyleBackColor = true;
            this.end_game_button.Click += new System.EventHandler(this.end_game_button_Click);
            // 
            // decks_label
            // 
            this.decks_label.AutoSize = true;
            this.decks_label.Location = new System.Drawing.Point(59, 63);
            this.decks_label.Name = "decks_label";
            this.decks_label.Size = new System.Drawing.Size(91, 13);
            this.decks_label.TabIndex = 4;
            this.decks_label.Text = "Number of decks:";
            // 
            // seed_label
            // 
            this.seed_label.AutoSize = true;
            this.seed_label.Location = new System.Drawing.Point(83, 117);
            this.seed_label.Name = "seed_label";
            this.seed_label.Size = new System.Drawing.Size(35, 13);
            this.seed_label.TabIndex = 5;
            this.seed_label.Text = "Seed:";
            // 
            // mode_checkbox
            // 
            this.mode_checkbox.AutoSize = true;
            this.mode_checkbox.Location = new System.Drawing.Point(156, 151);
            this.mode_checkbox.Name = "mode_checkbox";
            this.mode_checkbox.Size = new System.Drawing.Size(60, 17);
            this.mode_checkbox.TabIndex = 6;
            this.mode_checkbox.Text = "Soft 17";
            this.mode_checkbox.UseVisualStyleBackColor = true;
            // 
            // table_label
            // 
            this.table_label.AutoSize = true;
            this.table_label.Location = new System.Drawing.Point(184, 228);
            this.table_label.Name = "table_label";
            this.table_label.Size = new System.Drawing.Size(72, 13);
            this.table_label.TabIndex = 9;
            this.table_label.Text = "Total Tables: ";
            // 
            // table_count
            // 
            table_count.AutoSize = true;
            table_count.Location = new System.Drawing.Point(262, 228);
            table_count.Name = "table_count";
            table_count.Size = new System.Drawing.Size(13, 13);
            table_count.TabIndex = 10;
            table_count.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Create a table with desired specifications: ";
            // 
            // deck_comboBox
            // 
            this.deck_comboBox.FormattingEnabled = true;
            this.deck_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.deck_comboBox.Location = new System.Drawing.Point(154, 63);
            this.deck_comboBox.Name = "deck_comboBox";
            this.deck_comboBox.Size = new System.Drawing.Size(121, 21);
            this.deck_comboBox.TabIndex = 12;
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 374);
            this.Controls.Add(this.deck_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(table_count);
            this.Controls.Add(this.table_label);
            this.Controls.Add(this.mode_checkbox);
            this.Controls.Add(this.seed_label);
            this.Controls.Add(this.decks_label);
            this.Controls.Add(this.end_game_button);
            this.Controls.Add(this.create_table_button);
            this.Controls.Add(this.seed_box);
            this.Name = "Menu_Form";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox seed_box;
        private System.Windows.Forms.Button create_table_button;
        private System.Windows.Forms.Button end_game_button;
        private System.Windows.Forms.Label decks_label;
        private System.Windows.Forms.Label seed_label;
        private System.Windows.Forms.CheckBox mode_checkbox;
        private System.Windows.Forms.Label table_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox deck_comboBox;
        public static System.Windows.Forms.Label table_count;
    }
}

