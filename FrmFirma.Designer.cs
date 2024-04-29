namespace pryEmilianoFernandezEtapa1
{
    partial class FrmFirma
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
            PctFirma = new PictureBox();
            BtnLimpiar = new Button();
            BtnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)PctFirma).BeginInit();
            SuspendLayout();
            // 
            // PctFirma
            // 
            PctFirma.BackColor = Color.White;
            PctFirma.BorderStyle = BorderStyle.Fixed3D;
            PctFirma.Location = new Point(80, 23);
            PctFirma.Name = "PctFirma";
            PctFirma.Size = new Size(372, 284);
            PctFirma.TabIndex = 0;
            PctFirma.TabStop = false;
            PctFirma.MouseDown += PctFirma_MouseDown;
            PctFirma.MouseMove += PctFirma_MouseMove;
            PctFirma.MouseUp += PctFirma_MouseUp;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(80, 352);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(137, 59);
            BtnLimpiar.TabIndex = 1;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(315, 352);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(137, 59);
            BtnGuardar.TabIndex = 2;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // FrmFirma
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 448);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnLimpiar);
            Controls.Add(PctFirma);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmFirma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Firma";
            ((System.ComponentModel.ISupportInitialize)PctFirma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PctFirma;
        private Button BtnLimpiar;
        private Button BtnGuardar;
    }
}
