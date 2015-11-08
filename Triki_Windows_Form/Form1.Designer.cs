namespace Triki_Windows_Form
{
    partial class Form1
    {
        /* # Reglas de estilo:
  * 
  * - Los nombres de métodos y variables se escriben conforme a la convención de nombres CamelCase.
  * - Nombres de tipos definidos por el usuario inician con mayuscula.
  * - Solo se escriben llaves en el cuerpo de una estructura de control de flujo cuando esta requiera más de una instrucción.
  * - Indentación de cuatro caracteres en blanco.
  * - Se comenta con "//" solo para comentarios de una línea.
  */

        /* # Últimos cambios generales
         * 
         * ## Nombres de etiquetas
         * 
         * button6 ... button14		->	botonA ... botonI
         * label1					->	titularJuego
         * label2					->	etiquetaEstado
         * N/A						->	etiquetaVictoriasX
         * N/A						->	etiquetaVictoriasO
         * 
         * ## Variables
         * 
         * contadorGanadasA			->	contadorVictoriasA
         * contadorGanadasB			->	contadorVictoriasB
         * const string jugador?	-> readonly string jugador?
         * vacio					->	string.Empty (se eliminó la variable y sus apariciones se remplazaron por la constante)
         * 
         * ## Texto inicial de etiquetas
         * 
         * "Ganadas X: "			->	"Victorias del jugador X: 0"
         * "Ganadas O: "			->	"Victorias del jugador O: 0"
         */



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
            this.label1 = new System.Windows.Forms.Label();
            this.BotonA = new System.Windows.Forms.Button();
            this.BotonB = new System.Windows.Forms.Button();
            this.BotonC = new System.Windows.Forms.Button();
            this.BotonG = new System.Windows.Forms.Button();
            this.BotonE = new System.Windows.Forms.Button();
            this.BotonF = new System.Windows.Forms.Button();
            this.BotonD = new System.Windows.Forms.Button();
            this.BotonH = new System.Windows.Forms.Button();
            this.BotonI = new System.Windows.Forms.Button();
            this.botonReseteo = new System.Windows.Forms.Button();
            this.etiquetaVictoriasX = new System.Windows.Forms.Label();
            this.etiquetaVictoriasO = new System.Windows.Forms.Label();
            this.etiquetaEstado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Motorwerk", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "El Triki Trake";
            // 
            // BotonA
            // 
            this.BotonA.Location = new System.Drawing.Point(122, 66);
            this.BotonA.Name = "BotonA";
            this.BotonA.Size = new System.Drawing.Size(50, 50);
            this.BotonA.TabIndex = 1;
            this.BotonA.UseVisualStyleBackColor = true;
            this.BotonA.Click += new System.EventHandler(this.BotonA_Click);
            // 
            // BotonB
            // 
            this.BotonB.Location = new System.Drawing.Point(178, 66);
            this.BotonB.Name = "BotonB";
            this.BotonB.Size = new System.Drawing.Size(50, 50);
            this.BotonB.TabIndex = 2;
            this.BotonB.UseVisualStyleBackColor = true;
            this.BotonB.Click += new System.EventHandler(this.BotonB_Click);
            // 
            // BotonC
            // 
            this.BotonC.Location = new System.Drawing.Point(234, 66);
            this.BotonC.Name = "BotonC";
            this.BotonC.Size = new System.Drawing.Size(50, 50);
            this.BotonC.TabIndex = 3;
            this.BotonC.UseVisualStyleBackColor = true;
            this.BotonC.Click += new System.EventHandler(this.BotonC_Click);
            // 
            // BotonG
            // 
            this.BotonG.Location = new System.Drawing.Point(122, 178);
            this.BotonG.Name = "BotonG";
            this.BotonG.Size = new System.Drawing.Size(50, 50);
            this.BotonG.TabIndex = 4;
            this.BotonG.UseVisualStyleBackColor = true;
            this.BotonG.Click += new System.EventHandler(this.BotonG_Click);
            // 
            // BotonE
            // 
            this.BotonE.Location = new System.Drawing.Point(178, 122);
            this.BotonE.Name = "BotonE";
            this.BotonE.Size = new System.Drawing.Size(50, 50);
            this.BotonE.TabIndex = 5;
            this.BotonE.UseVisualStyleBackColor = true;
            this.BotonE.Click += new System.EventHandler(this.BotonE_Click);
            // 
            // BotonF
            // 
            this.BotonF.Location = new System.Drawing.Point(234, 122);
            this.BotonF.Name = "BotonF";
            this.BotonF.Size = new System.Drawing.Size(50, 50);
            this.BotonF.TabIndex = 6;
            this.BotonF.UseVisualStyleBackColor = true;
            this.BotonF.Click += new System.EventHandler(this.BotonF_Click);
            // 
            // BotonD
            // 
            this.BotonD.Location = new System.Drawing.Point(122, 122);
            this.BotonD.Name = "BotonD";
            this.BotonD.Size = new System.Drawing.Size(50, 50);
            this.BotonD.TabIndex = 7;
            this.BotonD.UseVisualStyleBackColor = true;
            this.BotonD.Click += new System.EventHandler(this.BotonD_Click);
            // 
            // BotonH
            // 
            this.BotonH.Location = new System.Drawing.Point(178, 178);
            this.BotonH.Name = "BotonH";
            this.BotonH.Size = new System.Drawing.Size(50, 50);
            this.BotonH.TabIndex = 8;
            this.BotonH.UseVisualStyleBackColor = true;
            this.BotonH.Click += new System.EventHandler(this.BotonH_Click);
            // 
            // BotonI
            // 
            this.BotonI.Location = new System.Drawing.Point(234, 178);
            this.BotonI.Name = "BotonI";
            this.BotonI.Size = new System.Drawing.Size(50, 50);
            this.BotonI.TabIndex = 9;
            this.BotonI.UseVisualStyleBackColor = true;
            this.BotonI.Click += new System.EventHandler(this.BotonI_Click);
            // 
            // botonReseteo
            // 
            this.botonReseteo.Location = new System.Drawing.Point(178, 234);
            this.botonReseteo.Name = "botonReseteo";
            this.botonReseteo.Size = new System.Drawing.Size(75, 23);
            this.botonReseteo.TabIndex = 10;
            this.botonReseteo.Text = "Reiniciar";
            this.botonReseteo.UseVisualStyleBackColor = true;
            this.botonReseteo.Click += new System.EventHandler(this.botonReseteo_Click);
            // 
            // etiquetaVictoriasX
            // 
            this.etiquetaVictoriasX.AutoSize = true;
            this.etiquetaVictoriasX.Location = new System.Drawing.Point(21, 366);
            this.etiquetaVictoriasX.Name = "etiquetaVictoriasX";
            this.etiquetaVictoriasX.Size = new System.Drawing.Size(121, 13);
            this.etiquetaVictoriasX.TabIndex = 11;
            this.etiquetaVictoriasX.Text = "Victorias del Jugador X: ";
            // 
            // etiquetaVictoriasO
            // 
            this.etiquetaVictoriasO.AutoSize = true;
            this.etiquetaVictoriasO.Location = new System.Drawing.Point(292, 366);
            this.etiquetaVictoriasO.Name = "etiquetaVictoriasO";
            this.etiquetaVictoriasO.Size = new System.Drawing.Size(116, 13);
            this.etiquetaVictoriasO.TabIndex = 12;
            this.etiquetaVictoriasO.Text = "Victorias del jugador O:";
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.AutoSize = true;
            this.etiquetaEstado.Location = new System.Drawing.Point(157, 366);
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(0, 13);
            this.etiquetaEstado.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 52);
            this.label2.TabIndex = 14;
            this.label2.Text = "Desarrollador por: Albeiro Cuadrado \r\n                   Jesus Gambin\r\n          " +
    "         Sebastian Arteaga\r\nTodos los derechos reservados 2015 ®";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(442, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etiquetaEstado);
            this.Controls.Add(this.etiquetaVictoriasO);
            this.Controls.Add(this.etiquetaVictoriasX);
            this.Controls.Add(this.botonReseteo);
            this.Controls.Add(this.BotonI);
            this.Controls.Add(this.BotonH);
            this.Controls.Add(this.BotonD);
            this.Controls.Add(this.BotonF);
            this.Controls.Add(this.BotonE);
            this.Controls.Add(this.BotonG);
            this.Controls.Add(this.BotonC);
            this.Controls.Add(this.BotonB);
            this.Controls.Add(this.BotonA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "El triki trake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonA;
        private System.Windows.Forms.Button BotonC;
        private System.Windows.Forms.Button BotonG;
        private System.Windows.Forms.Button BotonE;
        private System.Windows.Forms.Button BotonF;
        private System.Windows.Forms.Button BotonD;
        private System.Windows.Forms.Button BotonH;
        private System.Windows.Forms.Button BotonI;
        private System.Windows.Forms.Button BotonB;
        private System.Windows.Forms.Button botonReseteo;
        private System.Windows.Forms.Label etiquetaVictoriasX;
        private System.Windows.Forms.Label etiquetaVictoriasO;
        private System.Windows.Forms.Label etiquetaEstado;
        private System.Windows.Forms.Label label2;
    }
}

