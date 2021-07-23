
namespace CryptoZylix.WindowsApp
{
    partial class Form1
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
            this.buttonEncryptFile = new System.Windows.Forms.Button();
            this.buttonDecryptFile = new System.Windows.Forms.Button();
            this.buttonCreateAsmKeys = new System.Windows.Forms.Button();
            this.buttonExportPublicKey = new System.Windows.Forms.Button();
            this.buttonImportPublicKey = new System.Windows.Forms.Button();
            this.buttonGetPrivateKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.buttonGuidGenerate = new System.Windows.Forms.Button();
            this.textBoxGuid = new System.Windows.Forms.TextBox();
            this.buttonDataprotectionCrypt = new System.Windows.Forms.Button();
            this.buttonDataprotectionDeCrypt = new System.Windows.Forms.Button();
            this.buttonIdDispositivo = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxIdDispositivo = new System.Windows.Forms.TextBox();
            this.textBoxMontaString = new System.Windows.Forms.TextBox();
            this.textBoxStringCodificada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEncryptFile
            // 
            this.buttonEncryptFile.Location = new System.Drawing.Point(146, 61);
            this.buttonEncryptFile.Name = "buttonEncryptFile";
            this.buttonEncryptFile.Size = new System.Drawing.Size(156, 23);
            this.buttonEncryptFile.TabIndex = 0;
            this.buttonEncryptFile.Text = "Criptografar arquivo";
            this.buttonEncryptFile.UseVisualStyleBackColor = true;
            this.buttonEncryptFile.Click += new System.EventHandler(this.buttonEncryptFile_Click);
            // 
            // buttonDecryptFile
            // 
            this.buttonDecryptFile.Location = new System.Drawing.Point(146, 90);
            this.buttonDecryptFile.Name = "buttonDecryptFile";
            this.buttonDecryptFile.Size = new System.Drawing.Size(156, 23);
            this.buttonDecryptFile.TabIndex = 1;
            this.buttonDecryptFile.Text = "Descriptografar arquivo";
            this.buttonDecryptFile.UseVisualStyleBackColor = true;
            this.buttonDecryptFile.Click += new System.EventHandler(this.buttonDecryptFile_Click);
            // 
            // buttonCreateAsmKeys
            // 
            this.buttonCreateAsmKeys.Location = new System.Drawing.Point(146, 119);
            this.buttonCreateAsmKeys.Name = "buttonCreateAsmKeys";
            this.buttonCreateAsmKeys.Size = new System.Drawing.Size(156, 23);
            this.buttonCreateAsmKeys.TabIndex = 2;
            this.buttonCreateAsmKeys.Text = "Criar chaves";
            this.buttonCreateAsmKeys.UseVisualStyleBackColor = true;
            this.buttonCreateAsmKeys.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // buttonExportPublicKey
            // 
            this.buttonExportPublicKey.Location = new System.Drawing.Point(146, 148);
            this.buttonExportPublicKey.Name = "buttonExportPublicKey";
            this.buttonExportPublicKey.Size = new System.Drawing.Size(156, 23);
            this.buttonExportPublicKey.TabIndex = 3;
            this.buttonExportPublicKey.Text = "Exportar chave pública";
            this.buttonExportPublicKey.UseVisualStyleBackColor = true;
            this.buttonExportPublicKey.Click += new System.EventHandler(this.buttonExportPublicKey_Click);
            // 
            // buttonImportPublicKey
            // 
            this.buttonImportPublicKey.Location = new System.Drawing.Point(146, 177);
            this.buttonImportPublicKey.Name = "buttonImportPublicKey";
            this.buttonImportPublicKey.Size = new System.Drawing.Size(156, 23);
            this.buttonImportPublicKey.TabIndex = 4;
            this.buttonImportPublicKey.Text = "Importar chave pública";
            this.buttonImportPublicKey.UseVisualStyleBackColor = true;
            this.buttonImportPublicKey.Click += new System.EventHandler(this.buttonImportPublicKey_Click);
            // 
            // buttonGetPrivateKey
            // 
            this.buttonGetPrivateKey.Location = new System.Drawing.Point(146, 206);
            this.buttonGetPrivateKey.Name = "buttonGetPrivateKey";
            this.buttonGetPrivateKey.Size = new System.Drawing.Size(156, 23);
            this.buttonGetPrivateKey.TabIndex = 5;
            this.buttonGetPrivateKey.Text = "Obter chave privada";
            this.buttonGetPrivateKey.UseVisualStyleBackColor = true;
            this.buttonGetPrivateKey.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chave não definida";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // buttonGuidGenerate
            // 
            this.buttonGuidGenerate.Location = new System.Drawing.Point(146, 32);
            this.buttonGuidGenerate.Name = "buttonGuidGenerate";
            this.buttonGuidGenerate.Size = new System.Drawing.Size(156, 23);
            this.buttonGuidGenerate.TabIndex = 7;
            this.buttonGuidGenerate.Text = "Gerar Guid";
            this.buttonGuidGenerate.UseVisualStyleBackColor = true;
            this.buttonGuidGenerate.Click += new System.EventHandler(this.buttonGuidGenerate_Click);
            // 
            // textBoxGuid
            // 
            this.textBoxGuid.Location = new System.Drawing.Point(323, 32);
            this.textBoxGuid.Name = "textBoxGuid";
            this.textBoxGuid.Size = new System.Drawing.Size(244, 23);
            this.textBoxGuid.TabIndex = 9;
            this.textBoxGuid.Text = "685f1732-e34d-4aec-826b-fc86ad03e51b";
            // 
            // buttonDataprotectionCrypt
            // 
            this.buttonDataprotectionCrypt.Location = new System.Drawing.Point(146, 268);
            this.buttonDataprotectionCrypt.Name = "buttonDataprotectionCrypt";
            this.buttonDataprotectionCrypt.Size = new System.Drawing.Size(156, 23);
            this.buttonDataprotectionCrypt.TabIndex = 10;
            this.buttonDataprotectionCrypt.Text = "Data Protection Crypt";
            this.buttonDataprotectionCrypt.UseVisualStyleBackColor = true;
            this.buttonDataprotectionCrypt.Click += new System.EventHandler(this.buttonDataprotectionCrypt_Click);
            // 
            // buttonDataprotectionDeCrypt
            // 
            this.buttonDataprotectionDeCrypt.Location = new System.Drawing.Point(146, 297);
            this.buttonDataprotectionDeCrypt.Name = "buttonDataprotectionDeCrypt";
            this.buttonDataprotectionDeCrypt.Size = new System.Drawing.Size(156, 23);
            this.buttonDataprotectionDeCrypt.TabIndex = 11;
            this.buttonDataprotectionDeCrypt.Text = "Data Protection Decrypt";
            this.buttonDataprotectionDeCrypt.UseVisualStyleBackColor = true;
            this.buttonDataprotectionDeCrypt.Click += new System.EventHandler(this.buttonDataprotectionDeCrypt_Click);
            // 
            // buttonIdDispositivo
            // 
            this.buttonIdDispositivo.Location = new System.Drawing.Point(287, 491);
            this.buttonIdDispositivo.Name = "buttonIdDispositivo";
            this.buttonIdDispositivo.Size = new System.Drawing.Size(594, 23);
            this.buttonIdDispositivo.TabIndex = 12;
            this.buttonIdDispositivo.Text = "Id do dispositivo";
            this.buttonIdDispositivo.UseVisualStyleBackColor = true;
            this.buttonIdDispositivo.Click += new System.EventHandler(this.buttonIdDispositivo_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(287, 375);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(594, 23);
            this.textBoxCodigo.TabIndex = 14;
            this.textBoxCodigo.Text = "2-123";
            // 
            // textBoxIdDispositivo
            // 
            this.textBoxIdDispositivo.Location = new System.Drawing.Point(287, 404);
            this.textBoxIdDispositivo.Name = "textBoxIdDispositivo";
            this.textBoxIdDispositivo.Size = new System.Drawing.Size(594, 23);
            this.textBoxIdDispositivo.TabIndex = 16;
            // 
            // textBoxMontaString
            // 
            this.textBoxMontaString.Location = new System.Drawing.Point(287, 433);
            this.textBoxMontaString.Name = "textBoxMontaString";
            this.textBoxMontaString.Size = new System.Drawing.Size(594, 23);
            this.textBoxMontaString.TabIndex = 17;
            // 
            // textBoxStringCodificada
            // 
            this.textBoxStringCodificada.Location = new System.Drawing.Point(287, 462);
            this.textBoxStringCodificada.Name = "textBoxStringCodificada";
            this.textBoxStringCodificada.Size = new System.Drawing.Size(594, 23);
            this.textBoxStringCodificada.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Chave licença";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Id do dispositivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Composição dados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Hash SHA256 Base 64";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "ZYLIX + {CHAVE DE LICENÇA} + {MAC ADDRESS}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 638);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStringCodificada);
            this.Controls.Add(this.textBoxMontaString);
            this.Controls.Add(this.textBoxIdDispositivo);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.buttonIdDispositivo);
            this.Controls.Add(this.buttonDataprotectionDeCrypt);
            this.Controls.Add(this.buttonDataprotectionCrypt);
            this.Controls.Add(this.textBoxGuid);
            this.Controls.Add(this.buttonGuidGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGetPrivateKey);
            this.Controls.Add(this.buttonImportPublicKey);
            this.Controls.Add(this.buttonExportPublicKey);
            this.Controls.Add(this.buttonCreateAsmKeys);
            this.Controls.Add(this.buttonDecryptFile);
            this.Controls.Add(this.buttonEncryptFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncryptFile;
        private System.Windows.Forms.Button buttonDecryptFile;
        private System.Windows.Forms.Button buttonCreateAsmKeys;
        private System.Windows.Forms.Button buttonExportPublicKey;
        private System.Windows.Forms.Button buttonImportPublicKey;
        private System.Windows.Forms.Button buttonGetPrivateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button buttonGuidGenerate;
        private System.Windows.Forms.TextBox textBoxGuid;
        private System.Windows.Forms.Button buttonDataprotectionCrypt;
        private System.Windows.Forms.Button buttonDataprotectionDeCrypt;
        private System.Windows.Forms.Button buttonIdDispositivo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxIdDispositivo;
        private System.Windows.Forms.TextBox textBoxMontaString;
        private System.Windows.Forms.TextBox textBoxStringCodificada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

