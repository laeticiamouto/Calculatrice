namespace Calculatrice
{
    partial class F_Calculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Ecran = new System.Windows.Forms.Label();
            this.btn_Inverse = new System.Windows.Forms.Button();
            this.btn_Modulo = new System.Windows.Forms.Button();
            this.btn_Factoriel = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Multiplication = new System.Windows.Forms.Button();
            this.btn_Neuf = new System.Windows.Forms.Button();
            this.btn_Huit = new System.Windows.Forms.Button();
            this.btn_Sept = new System.Windows.Forms.Button();
            this.btn_Moins = new System.Windows.Forms.Button();
            this.btn_Six = new System.Windows.Forms.Button();
            this.btn_Cinq = new System.Windows.Forms.Button();
            this.btn_Quatre = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Trois = new System.Windows.Forms.Button();
            this.btn_Deux = new System.Windows.Forms.Button();
            this.btn_Un = new System.Windows.Forms.Button();
            this.btn_Effacer = new System.Windows.Forms.Button();
            this.btn_Zero = new System.Windows.Forms.Button();
            this.btn_Virgule = new System.Windows.Forms.Button();
            this.btn_Egal = new System.Windows.Forms.Button();
            this.lbl_Operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Ecran
            // 
            this.lbl_Ecran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Ecran.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ecran.Location = new System.Drawing.Point(-3, 66);
            this.lbl_Ecran.Name = "lbl_Ecran";
            this.lbl_Ecran.Size = new System.Drawing.Size(394, 106);
            this.lbl_Ecran.TabIndex = 0;
            this.lbl_Ecran.Text = "0";
            this.lbl_Ecran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Inverse
            // 
            this.btn_Inverse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Inverse.BackColor = System.Drawing.Color.White;
            this.btn_Inverse.FlatAppearance.BorderSize = 0;
            this.btn_Inverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inverse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inverse.Location = new System.Drawing.Point(0, 174);
            this.btn_Inverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Inverse.Name = "btn_Inverse";
            this.btn_Inverse.Size = new System.Drawing.Size(93, 47);
            this.btn_Inverse.TabIndex = 1;
            this.btn_Inverse.Text = "⅟x";
            this.btn_Inverse.UseVisualStyleBackColor = false;
            this.btn_Inverse.Click += new System.EventHandler(this.btn_Inverse_Click);
            // 
            // btn_Modulo
            // 
            this.btn_Modulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Modulo.BackColor = System.Drawing.Color.White;
            this.btn_Modulo.FlatAppearance.BorderSize = 0;
            this.btn_Modulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modulo.Location = new System.Drawing.Point(100, 174);
            this.btn_Modulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Modulo.Name = "btn_Modulo";
            this.btn_Modulo.Size = new System.Drawing.Size(93, 47);
            this.btn_Modulo.TabIndex = 2;
            this.btn_Modulo.Text = "%";
            this.btn_Modulo.UseVisualStyleBackColor = false;
            this.btn_Modulo.Click += new System.EventHandler(this.btn_Modulo_Click);
            // 
            // btn_Factoriel
            // 
            this.btn_Factoriel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Factoriel.BackColor = System.Drawing.Color.White;
            this.btn_Factoriel.FlatAppearance.BorderSize = 0;
            this.btn_Factoriel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Factoriel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Factoriel.Location = new System.Drawing.Point(199, 174);
            this.btn_Factoriel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Factoriel.Name = "btn_Factoriel";
            this.btn_Factoriel.Size = new System.Drawing.Size(93, 47);
            this.btn_Factoriel.TabIndex = 3;
            this.btn_Factoriel.Text = "n!";
            this.btn_Factoriel.UseVisualStyleBackColor = false;
            this.btn_Factoriel.Click += new System.EventHandler(this.btn_Factoriel_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Division.BackColor = System.Drawing.Color.LightGray;
            this.btn_Division.FlatAppearance.BorderSize = 0;
            this.btn_Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Division.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Division.Location = new System.Drawing.Point(298, 174);
            this.btn_Division.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(93, 47);
            this.btn_Division.TabIndex = 4;
            this.btn_Division.Text = "÷";
            this.btn_Division.UseVisualStyleBackColor = false;
            this.btn_Division.Click += new System.EventHandler(this.btn_Division_Click);
            // 
            // btn_Multiplication
            // 
            this.btn_Multiplication.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Multiplication.BackColor = System.Drawing.Color.LightGray;
            this.btn_Multiplication.FlatAppearance.BorderSize = 0;
            this.btn_Multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Multiplication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiplication.Location = new System.Drawing.Point(298, 227);
            this.btn_Multiplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Multiplication.Name = "btn_Multiplication";
            this.btn_Multiplication.Size = new System.Drawing.Size(93, 47);
            this.btn_Multiplication.TabIndex = 8;
            this.btn_Multiplication.Text = "×";
            this.btn_Multiplication.UseVisualStyleBackColor = false;
            this.btn_Multiplication.Click += new System.EventHandler(this.btn_Multiplication_Click);
            // 
            // btn_Neuf
            // 
            this.btn_Neuf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Neuf.BackColor = System.Drawing.Color.White;
            this.btn_Neuf.FlatAppearance.BorderSize = 0;
            this.btn_Neuf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Neuf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Neuf.Location = new System.Drawing.Point(199, 227);
            this.btn_Neuf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Neuf.Name = "btn_Neuf";
            this.btn_Neuf.Size = new System.Drawing.Size(93, 47);
            this.btn_Neuf.TabIndex = 7;
            this.btn_Neuf.Text = "9";
            this.btn_Neuf.UseVisualStyleBackColor = false;
            this.btn_Neuf.Click += new System.EventHandler(this.btn_Neuf_Click);
            // 
            // btn_Huit
            // 
            this.btn_Huit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Huit.BackColor = System.Drawing.Color.White;
            this.btn_Huit.FlatAppearance.BorderSize = 0;
            this.btn_Huit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huit.Location = new System.Drawing.Point(100, 227);
            this.btn_Huit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Huit.Name = "btn_Huit";
            this.btn_Huit.Size = new System.Drawing.Size(93, 47);
            this.btn_Huit.TabIndex = 6;
            this.btn_Huit.Text = "8";
            this.btn_Huit.UseVisualStyleBackColor = false;
            this.btn_Huit.Click += new System.EventHandler(this.btn_Huit_Click);
            // 
            // btn_Sept
            // 
            this.btn_Sept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Sept.BackColor = System.Drawing.Color.White;
            this.btn_Sept.FlatAppearance.BorderSize = 0;
            this.btn_Sept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sept.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sept.Location = new System.Drawing.Point(0, 227);
            this.btn_Sept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sept.Name = "btn_Sept";
            this.btn_Sept.Size = new System.Drawing.Size(93, 47);
            this.btn_Sept.TabIndex = 5;
            this.btn_Sept.Text = "7";
            this.btn_Sept.UseVisualStyleBackColor = false;
            this.btn_Sept.Click += new System.EventHandler(this.btn_Sept_Click);
            // 
            // btn_Moins
            // 
            this.btn_Moins.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Moins.BackColor = System.Drawing.Color.LightGray;
            this.btn_Moins.FlatAppearance.BorderSize = 0;
            this.btn_Moins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Moins.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Moins.Location = new System.Drawing.Point(298, 280);
            this.btn_Moins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Moins.Name = "btn_Moins";
            this.btn_Moins.Size = new System.Drawing.Size(93, 47);
            this.btn_Moins.TabIndex = 12;
            this.btn_Moins.Text = "-";
            this.btn_Moins.UseVisualStyleBackColor = false;
            this.btn_Moins.Click += new System.EventHandler(this.btn_Moins_Click);
            // 
            // btn_Six
            // 
            this.btn_Six.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Six.BackColor = System.Drawing.Color.White;
            this.btn_Six.FlatAppearance.BorderSize = 0;
            this.btn_Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Six.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Six.Location = new System.Drawing.Point(199, 280);
            this.btn_Six.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Six.Name = "btn_Six";
            this.btn_Six.Size = new System.Drawing.Size(93, 47);
            this.btn_Six.TabIndex = 11;
            this.btn_Six.Text = "6";
            this.btn_Six.UseVisualStyleBackColor = false;
            this.btn_Six.Click += new System.EventHandler(this.btn_Six_Click);
            // 
            // btn_Cinq
            // 
            this.btn_Cinq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Cinq.BackColor = System.Drawing.Color.White;
            this.btn_Cinq.FlatAppearance.BorderSize = 0;
            this.btn_Cinq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cinq.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cinq.Location = new System.Drawing.Point(100, 280);
            this.btn_Cinq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cinq.Name = "btn_Cinq";
            this.btn_Cinq.Size = new System.Drawing.Size(93, 47);
            this.btn_Cinq.TabIndex = 10;
            this.btn_Cinq.Text = "5";
            this.btn_Cinq.UseVisualStyleBackColor = false;
            this.btn_Cinq.Click += new System.EventHandler(this.btn_Cinq_Click);
            // 
            // btn_Quatre
            // 
            this.btn_Quatre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Quatre.BackColor = System.Drawing.Color.White;
            this.btn_Quatre.FlatAppearance.BorderSize = 0;
            this.btn_Quatre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quatre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quatre.Location = new System.Drawing.Point(0, 280);
            this.btn_Quatre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quatre.Name = "btn_Quatre";
            this.btn_Quatre.Size = new System.Drawing.Size(93, 47);
            this.btn_Quatre.TabIndex = 9;
            this.btn_Quatre.Text = "4";
            this.btn_Quatre.UseVisualStyleBackColor = false;
            this.btn_Quatre.Click += new System.EventHandler(this.btn_Quatre_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Plus.BackColor = System.Drawing.Color.LightGray;
            this.btn_Plus.FlatAppearance.BorderSize = 0;
            this.btn_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Plus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Plus.Location = new System.Drawing.Point(298, 333);
            this.btn_Plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(93, 47);
            this.btn_Plus.TabIndex = 16;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = false;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Trois
            // 
            this.btn_Trois.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Trois.BackColor = System.Drawing.Color.White;
            this.btn_Trois.FlatAppearance.BorderSize = 0;
            this.btn_Trois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Trois.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trois.Location = new System.Drawing.Point(199, 333);
            this.btn_Trois.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Trois.Name = "btn_Trois";
            this.btn_Trois.Size = new System.Drawing.Size(93, 47);
            this.btn_Trois.TabIndex = 15;
            this.btn_Trois.Text = "3";
            this.btn_Trois.UseVisualStyleBackColor = false;
            this.btn_Trois.Click += new System.EventHandler(this.btn_Trois_Click);
            // 
            // btn_Deux
            // 
            this.btn_Deux.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Deux.BackColor = System.Drawing.Color.White;
            this.btn_Deux.FlatAppearance.BorderSize = 0;
            this.btn_Deux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deux.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deux.Location = new System.Drawing.Point(100, 333);
            this.btn_Deux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Deux.Name = "btn_Deux";
            this.btn_Deux.Size = new System.Drawing.Size(93, 47);
            this.btn_Deux.TabIndex = 14;
            this.btn_Deux.Text = "2";
            this.btn_Deux.UseVisualStyleBackColor = false;
            this.btn_Deux.Click += new System.EventHandler(this.btn_Deux_Click);
            // 
            // btn_Un
            // 
            this.btn_Un.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Un.BackColor = System.Drawing.Color.White;
            this.btn_Un.FlatAppearance.BorderSize = 0;
            this.btn_Un.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Un.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Un.Location = new System.Drawing.Point(0, 333);
            this.btn_Un.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Un.Name = "btn_Un";
            this.btn_Un.Size = new System.Drawing.Size(93, 47);
            this.btn_Un.TabIndex = 13;
            this.btn_Un.Text = "1";
            this.btn_Un.UseVisualStyleBackColor = false;
            this.btn_Un.Click += new System.EventHandler(this.btn_Un_Click);
            // 
            // btn_Effacer
            // 
            this.btn_Effacer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Effacer.BackColor = System.Drawing.Color.LightGray;
            this.btn_Effacer.FlatAppearance.BorderSize = 0;
            this.btn_Effacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Effacer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Effacer.Location = new System.Drawing.Point(298, 386);
            this.btn_Effacer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Effacer.Name = "btn_Effacer";
            this.btn_Effacer.Size = new System.Drawing.Size(93, 47);
            this.btn_Effacer.TabIndex = 20;
            this.btn_Effacer.Text = "c";
            this.btn_Effacer.UseVisualStyleBackColor = false;
            this.btn_Effacer.Click += new System.EventHandler(this.btn_Effacer_Click);
            // 
            // btn_Zero
            // 
            this.btn_Zero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Zero.BackColor = System.Drawing.Color.White;
            this.btn_Zero.FlatAppearance.BorderSize = 0;
            this.btn_Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Zero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Zero.Location = new System.Drawing.Point(199, 386);
            this.btn_Zero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Zero.Name = "btn_Zero";
            this.btn_Zero.Size = new System.Drawing.Size(93, 47);
            this.btn_Zero.TabIndex = 19;
            this.btn_Zero.Text = "0";
            this.btn_Zero.UseVisualStyleBackColor = false;
            this.btn_Zero.Click += new System.EventHandler(this.btn_Zero_Click);
            // 
            // btn_Virgule
            // 
            this.btn_Virgule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Virgule.BackColor = System.Drawing.Color.White;
            this.btn_Virgule.FlatAppearance.BorderSize = 0;
            this.btn_Virgule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Virgule.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Virgule.Location = new System.Drawing.Point(100, 386);
            this.btn_Virgule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Virgule.Name = "btn_Virgule";
            this.btn_Virgule.Size = new System.Drawing.Size(93, 47);
            this.btn_Virgule.TabIndex = 18;
            this.btn_Virgule.Text = ".";
            this.btn_Virgule.UseVisualStyleBackColor = false;
            this.btn_Virgule.Click += new System.EventHandler(this.btn_Virgule_Click);
            // 
            // btn_Egal
            // 
            this.btn_Egal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Egal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Egal.FlatAppearance.BorderSize = 0;
            this.btn_Egal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Egal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Egal.Location = new System.Drawing.Point(0, 386);
            this.btn_Egal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Egal.Name = "btn_Egal";
            this.btn_Egal.Size = new System.Drawing.Size(93, 47);
            this.btn_Egal.TabIndex = 17;
            this.btn_Egal.Text = "=";
            this.btn_Egal.UseVisualStyleBackColor = false;
            this.btn_Egal.Click += new System.EventHandler(this.btn_Egal_Click);
            // 
            // lbl_Operation
            // 
            this.lbl_Operation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Operation.Location = new System.Drawing.Point(-3, 9);
            this.lbl_Operation.Name = "lbl_Operation";
            this.lbl_Operation.Size = new System.Drawing.Size(394, 33);
            this.lbl_Operation.TabIndex = 21;
            this.lbl_Operation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // F_Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(392, 443);
            this.Controls.Add(this.lbl_Operation);
            this.Controls.Add(this.btn_Effacer);
            this.Controls.Add(this.btn_Zero);
            this.Controls.Add(this.btn_Virgule);
            this.Controls.Add(this.btn_Egal);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.btn_Trois);
            this.Controls.Add(this.btn_Deux);
            this.Controls.Add(this.btn_Un);
            this.Controls.Add(this.btn_Moins);
            this.Controls.Add(this.btn_Six);
            this.Controls.Add(this.btn_Cinq);
            this.Controls.Add(this.btn_Quatre);
            this.Controls.Add(this.btn_Multiplication);
            this.Controls.Add(this.btn_Neuf);
            this.Controls.Add(this.btn_Huit);
            this.Controls.Add(this.btn_Sept);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Factoriel);
            this.Controls.Add(this.btn_Modulo);
            this.Controls.Add(this.btn_Inverse);
            this.Controls.Add(this.lbl_Ecran);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "F_Calculatrice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculatrice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ecran;
        private System.Windows.Forms.Button btn_Inverse;
        private System.Windows.Forms.Button btn_Modulo;
        private System.Windows.Forms.Button btn_Factoriel;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Multiplication;
        private System.Windows.Forms.Button btn_Neuf;
        private System.Windows.Forms.Button btn_Huit;
        private System.Windows.Forms.Button btn_Sept;
        private System.Windows.Forms.Button btn_Moins;
        private System.Windows.Forms.Button btn_Six;
        private System.Windows.Forms.Button btn_Cinq;
        private System.Windows.Forms.Button btn_Quatre;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Trois;
        private System.Windows.Forms.Button btn_Deux;
        private System.Windows.Forms.Button btn_Un;
        private System.Windows.Forms.Button btn_Effacer;
        private System.Windows.Forms.Button btn_Zero;
        private System.Windows.Forms.Button btn_Virgule;
        private System.Windows.Forms.Button btn_Egal;
        private System.Windows.Forms.Label lbl_Operation;
    }
}

