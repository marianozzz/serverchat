namespace clientchat
{
    partial class Cliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_msg = new System.Windows.Forms.Button();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.groupopciones = new System.Windows.Forms.GroupBox();
            this.txt_nick = new System.Windows.Forms.TextBox();
            this.lbl_nick = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.lbl_puerto = new System.Windows.Forms.Label();
            this.lbl_host = new System.Windows.Forms.Label();
            this.groupgeneral = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupopciones.SuspendLayout();
            this.groupgeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_msg);
            this.groupBox2.Controls.Add(this.txt_msg);
            this.groupBox2.Location = new System.Drawing.Point(12, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 114);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mensajes";
            // 
            // btn_msg
            // 
            this.btn_msg.Location = new System.Drawing.Point(551, 70);
            this.btn_msg.Name = "btn_msg";
            this.btn_msg.Size = new System.Drawing.Size(75, 34);
            this.btn_msg.TabIndex = 3;
            this.btn_msg.Text = "Enviar";
            this.btn_msg.UseVisualStyleBackColor = true;
            this.btn_msg.Click += new System.EventHandler(this.btn_msg_Click);
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(7, 19);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(637, 45);
            this.txt_msg.TabIndex = 2;
            // 
            // lbl_Status
            // 
            this.lbl_Status.BackColor = System.Drawing.Color.Black;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Status.Location = new System.Drawing.Point(6, 17);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(636, 184);
            this.lbl_Status.TabIndex = 5;
            // 
            // groupopciones
            // 
            this.groupopciones.Controls.Add(this.txt_nick);
            this.groupopciones.Controls.Add(this.lbl_nick);
            this.groupopciones.Controls.Add(this.btn_disconnect);
            this.groupopciones.Controls.Add(this.btn_connect);
            this.groupopciones.Controls.Add(this.txt_port);
            this.groupopciones.Controls.Add(this.txt_host);
            this.groupopciones.Controls.Add(this.lbl_puerto);
            this.groupopciones.Controls.Add(this.lbl_host);
            this.groupopciones.Location = new System.Drawing.Point(18, 9);
            this.groupopciones.Name = "groupopciones";
            this.groupopciones.Size = new System.Drawing.Size(649, 114);
            this.groupopciones.TabIndex = 4;
            this.groupopciones.TabStop = false;
            this.groupopciones.Text = "Opciones de conexion";
            // 
            // txt_nick
            // 
            this.txt_nick.Location = new System.Drawing.Point(335, 19);
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Size = new System.Drawing.Size(129, 20);
            this.txt_nick.TabIndex = 7;
            this.txt_nick.Text = "USER";
            // 
            // lbl_nick
            // 
            this.lbl_nick.AutoSize = true;
            this.lbl_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nick.Location = new System.Drawing.Point(249, 23);
            this.lbl_nick.Name = "lbl_nick";
            this.lbl_nick.Size = new System.Drawing.Size(80, 16);
            this.lbl_nick.TabIndex = 6;
            this.lbl_nick.Text = "NickName";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(545, 51);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 5;
            this.btn_disconnect.Text = "Desconectar";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(545, 19);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Conectar";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(107, 47);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 20);
            this.txt_port.TabIndex = 3;
            this.txt_port.Text = "3000";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(107, 22);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(100, 20);
            this.txt_host.TabIndex = 2;
            this.txt_host.Text = "127.0.0.1";
            // 
            // lbl_puerto
            // 
            this.lbl_puerto.AutoSize = true;
            this.lbl_puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puerto.Location = new System.Drawing.Point(15, 51);
            this.lbl_puerto.Name = "lbl_puerto";
            this.lbl_puerto.Size = new System.Drawing.Size(53, 16);
            this.lbl_puerto.TabIndex = 1;
            this.lbl_puerto.Text = "Puerto";
            // 
            // lbl_host
            // 
            this.lbl_host.AutoSize = true;
            this.lbl_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_host.Location = new System.Drawing.Point(15, 26);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(40, 16);
            this.lbl_host.TabIndex = 0;
            this.lbl_host.Text = "Host";
            // 
            // groupgeneral
            // 
            this.groupgeneral.Controls.Add(this.lbl_Status);
            this.groupgeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupgeneral.Location = new System.Drawing.Point(19, 129);
            this.groupgeneral.Name = "groupgeneral";
            this.groupgeneral.Size = new System.Drawing.Size(648, 214);
            this.groupgeneral.TabIndex = 7;
            this.groupgeneral.TabStop = false;
            this.groupgeneral.Text = "Chat General";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 490);
            this.Controls.Add(this.groupgeneral);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupopciones);
            this.Name = "Cliente";
            this.Text = "Cliente de chat";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupopciones.ResumeLayout(false);
            this.groupopciones.PerformLayout();
            this.groupgeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_msg;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.GroupBox groupopciones;
        private System.Windows.Forms.TextBox txt_nick;
        private System.Windows.Forms.Label lbl_nick;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.Label lbl_puerto;
        private System.Windows.Forms.Label lbl_host;
        private System.Windows.Forms.GroupBox groupgeneral;
    }
}

