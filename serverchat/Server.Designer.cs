namespace serverchat
{
    partial class Server
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_contador = new System.Windows.Forms.Label();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.lbl_puerto = new System.Windows.Forms.Label();
            this.lbl_host = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_msg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_contador);
            this.groupBox1.Controls.Add(this.lbl_clientes);
            this.groupBox1.Controls.Add(this.btn_stop);
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.txt_port);
            this.groupBox1.Controls.Add(this.txt_host);
            this.groupBox1.Controls.Add(this.lbl_puerto);
            this.groupBox1.Controls.Add(this.lbl_host);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion";
            // 
            // lbl_contador
            // 
            this.lbl_contador.AutoSize = true;
            this.lbl_contador.BackColor = System.Drawing.Color.White;
            this.lbl_contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contador.Location = new System.Drawing.Point(526, 27);
            this.lbl_contador.Name = "lbl_contador";
            this.lbl_contador.Size = new System.Drawing.Size(14, 13);
            this.lbl_contador.TabIndex = 7;
            this.lbl_contador.Text = "0";
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientes.Location = new System.Drawing.Point(365, 26);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(155, 16);
            this.lbl_clientes.TabIndex = 6;
            this.lbl_clientes.Text = "Clientes Conectados:";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(263, 51);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(263, 20);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
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
            // lbl_Status
            // 
            this.lbl_Status.BackColor = System.Drawing.Color.Black;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Status.Location = new System.Drawing.Point(15, 135);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(652, 145);
            this.lbl_Status.TabIndex = 1;
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(15, 19);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(637, 70);
            this.txt_msg.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_msg);
            this.groupBox2.Controls.Add(this.txt_msg);
            this.groupBox2.Location = new System.Drawing.Point(12, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 155);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mensajes";
            // 
            // btn_msg
            // 
            this.btn_msg.Location = new System.Drawing.Point(562, 107);
            this.btn_msg.Name = "btn_msg";
            this.btn_msg.Size = new System.Drawing.Size(75, 23);
            this.btn_msg.TabIndex = 3;
            this.btn_msg.Text = "Enviar MSG";
            this.btn_msg.UseVisualStyleBackColor = true;
            this.btn_msg.Click += new System.EventHandler(this.btn_msg_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.groupBox1);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.Label lbl_puerto;
        private System.Windows.Forms.Label lbl_host;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_msg;
        private System.Windows.Forms.Label lbl_contador;
        private System.Windows.Forms.Label lbl_clientes;
    }
}

