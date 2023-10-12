namespace Task3
{
    partial class Anket
    {

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anket));
            panel1 = new Panel();
            add_button = new Button();
            replace_button = new Button();
            dateTimePicker1 = new DateTimePicker();
            phone_text_box = new TextBox();
            surname_text_box = new TextBox();
            email_text_box = new TextBox();
            name_text_box = new TextBox();
            birtday_label = new Label();
            phone_label = new Label();
            email_label = new Label();
            surname_label = new Label();
            name_label = new Label();
            label1 = new Label();
            panel2 = new Panel();
            clear_button = new Button();
            list_box = new ListBox();
            panel3 = new Panel();
            label2 = new Label();
            load_button = new Button();
            save_button = new Button();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(add_button);
            panel1.Controls.Add(replace_button);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(phone_text_box);
            panel1.Controls.Add(surname_text_box);
            panel1.Controls.Add(email_text_box);
            panel1.Controls.Add(name_text_box);
            panel1.Controls.Add(birtday_label);
            panel1.Controls.Add(phone_label);
            panel1.Controls.Add(email_label);
            panel1.Controls.Add(surname_label);
            panel1.Controls.Add(name_label);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 426);
            panel1.TabIndex = 0;
            // 
            // add_button
            // 
            add_button.BackColor = Color.White;
            add_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            add_button.Location = new Point(338, 338);
            add_button.Name = "add_button";
            add_button.Size = new Size(134, 52);
            add_button.TabIndex = 5;
            add_button.Text = "ADD";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // replace_button
            // 
            replace_button.BackColor = Color.White;
            replace_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            replace_button.Location = new Point(338, 256);
            replace_button.Name = "replace_button";
            replace_button.Size = new Size(134, 52);
            replace_button.TabIndex = 4;
            replace_button.Text = "CHANGE";
            replace_button.UseVisualStyleBackColor = false;
            replace_button.Click += replace_button_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(148, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // phone_text_box
            // 
            phone_text_box.Location = new Point(147, 142);
            phone_text_box.Name = "phone_text_box";
            phone_text_box.Size = new Size(325, 23);
            phone_text_box.TabIndex = 3;
            // 
            // surname_text_box
            // 
            surname_text_box.Location = new Point(147, 74);
            surname_text_box.Name = "surname_text_box";
            surname_text_box.Size = new Size(325, 23);
            surname_text_box.TabIndex = 1;
            // 
            // email_text_box
            // 
            email_text_box.Location = new Point(147, 108);
            email_text_box.Name = "email_text_box";
            email_text_box.Size = new Size(325, 23);
            email_text_box.TabIndex = 2;
            // 
            // name_text_box
            // 
            name_text_box.Location = new Point(147, 41);
            name_text_box.Name = "name_text_box";
            name_text_box.Size = new Size(325, 23);
            name_text_box.TabIndex = 0;
            // 
            // birtday_label
            // 
            birtday_label.AutoSize = true;
            birtday_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            birtday_label.Location = new Point(20, 179);
            birtday_label.Name = "birtday_label";
            birtday_label.Size = new Size(113, 23);
            birtday_label.TabIndex = 4;
            birtday_label.Text = "Birthday date";
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            phone_label.Location = new Point(20, 142);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(59, 23);
            phone_label.TabIndex = 3;
            phone_label.Text = "Phone";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            email_label.Location = new Point(19, 108);
            email_label.Name = "email_label";
            email_label.Size = new Size(51, 23);
            email_label.TabIndex = 2;
            email_label.Text = "Email";
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            surname_label.Location = new Point(19, 74);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(78, 23);
            surname_label.TabIndex = 1;
            surname_label.Text = "Surname";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            name_label.Location = new Point(19, 41);
            name_label.Name = "name_label";
            name_label.Size = new Size(56, 23);
            name_label.TabIndex = 0;
            name_label.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Anket";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(clear_button);
            panel2.Controls.Add(list_box);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(533, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 339);
            panel2.TabIndex = 1;
            // 
            // clear_button
            // 
            clear_button.BackColor = Color.White;
            clear_button.Location = new Point(14, 284);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(230, 41);
            clear_button.TabIndex = 3;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // list_box
            // 
            list_box.BackColor = SystemColors.ActiveCaption;
            list_box.FormattingEnabled = true;
            list_box.ItemHeight = 15;
            list_box.Location = new Point(0, 31);
            list_box.Name = "list_box";
            list_box.Size = new Size(255, 304);
            list_box.TabIndex = 2;
            list_box.SelectedIndexChanged += list_box_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 29);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 4);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 0;
            label2.Text = "ALL ANKETS";
            // 
            // load_button
            // 
            load_button.BackColor = Color.White;
            load_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            load_button.Location = new Point(534, 408);
            load_button.Name = "load_button";
            load_button.Size = new Size(121, 30);
            load_button.TabIndex = 3;
            load_button.Text = "LOAD";
            load_button.UseVisualStyleBackColor = false;
            load_button.Click += load_button_Click;
            // 
            // save_button
            // 
            save_button.BackColor = Color.White;
            save_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            save_button.Location = new Point(676, 408);
            save_button.Name = "save_button";
            save_button.Size = new Size(112, 30);
            save_button.TabIndex = 4;
            save_button.Text = "SAVE";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(533, 361);
            button1.Name = "button1";
            button1.Size = new Size(259, 30);
            button1.TabIndex = 5;
            button1.Text = "SAVE TO FILE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Anket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(save_button);
            Controls.Add(load_button);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Anket";
            Text = "Anket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button load_button;
        private Button save_button;
        private Panel panel3;
        private Label label2;
        private Label name_label;
        private Label surname_label;
        private TextBox phone_text_box;
        private TextBox surname_text_box;
        private TextBox email_text_box;
        private TextBox name_text_box;
        private Label birtday_label;
        private Label phone_label;
        private Label email_label;
        private DateTimePicker dateTimePicker1;
        private Button add_button;
        private ListBox list_box;
        private Button clear_button;
        private Button replace_button;
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}