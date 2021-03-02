namespace PuntodeVenta
{
    partial class realizarVenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgridVentas = new System.Windows.Forms.DataGridView();
            this.btn_eliminarVentas = new FontAwesome.Sharp.IconButton();
            this.btn_agregarVentas = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TotalFinal = new System.Windows.Forms.Label();
            this.lbl_CambioFinal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_PagoFinal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lbl_total = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_existencia = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panelRealizarVenta = new System.Windows.Forms.Panel();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.btn_realizarVenta = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_pago = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_totalPagar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_numVenta = new System.Windows.Forms.Label();
            this.lbl_idDetalleVenta = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.dgrid_idDetalleVenta = new System.Windows.Forms.DataGridView();
            this.dgrid_idVenta = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_cantProductos = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgridVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelRealizarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_idDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_idVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridVentas
            // 
            this.dgridVentas.AllowUserToAddRows = false;
            this.dgridVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgridVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgridVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.producto,
            this.precio,
            this.cantidad,
            this.subtotal,
            this.id_detalle});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgridVentas.EnableHeadersVisualStyles = false;
            this.dgridVentas.GridColor = System.Drawing.Color.White;
            this.dgridVentas.Location = new System.Drawing.Point(134, 144);
            this.dgridVentas.Name = "dgridVentas";
            this.dgridVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgridVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgridVentas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgridVentas.Size = new System.Drawing.Size(540, 219);
            this.dgridVentas.TabIndex = 1;
            this.dgridVentas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridVentas_CellEndEdit);
            // 
            // btn_eliminarVentas
            // 
            this.btn_eliminarVentas.BackColor = System.Drawing.Color.Firebrick;
            this.btn_eliminarVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminarVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_eliminarVentas.FlatAppearance.BorderSize = 0;
            this.btn_eliminarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_eliminarVentas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btn_eliminarVentas.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarVentas.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_eliminarVentas.IconColor = System.Drawing.Color.White;
            this.btn_eliminarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminarVentas.IconSize = 20;
            this.btn_eliminarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarVentas.Location = new System.Drawing.Point(563, 94);
            this.btn_eliminarVentas.Name = "btn_eliminarVentas";
            this.btn_eliminarVentas.Rotation = 0D;
            this.btn_eliminarVentas.Size = new System.Drawing.Size(111, 31);
            this.btn_eliminarVentas.TabIndex = 8;
            this.btn_eliminarVentas.Text = "Quitar";
            this.btn_eliminarVentas.UseVisualStyleBackColor = false;
            this.btn_eliminarVentas.Click += new System.EventHandler(this.btn_eliminarVentas_Click);
            // 
            // btn_agregarVentas
            // 
            this.btn_agregarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            this.btn_agregarVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_agregarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_agregarVentas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarVentas.ForeColor = System.Drawing.Color.White;
            this.btn_agregarVentas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_agregarVentas.IconColor = System.Drawing.Color.White;
            this.btn_agregarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregarVentas.IconSize = 27;
            this.btn_agregarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarVentas.Location = new System.Drawing.Point(140, 94);
            this.btn_agregarVentas.Name = "btn_agregarVentas";
            this.btn_agregarVentas.Rotation = 0D;
            this.btn_agregarVentas.Size = new System.Drawing.Size(417, 31);
            this.btn_agregarVentas.TabIndex = 6;
            this.btn_agregarVentas.Text = "     Agregar Producto";
            this.btn_agregarVentas.UseVisualStyleBackColor = false;
            this.btn_agregarVentas.Click += new System.EventHandler(this.btn_agregarVentas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total:";
            // 
            // lbl_TotalFinal
            // 
            this.lbl_TotalFinal.AutoSize = true;
            this.lbl_TotalFinal.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalFinal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_TotalFinal.Location = new System.Drawing.Point(83, 442);
            this.lbl_TotalFinal.Name = "lbl_TotalFinal";
            this.lbl_TotalFinal.Size = new System.Drawing.Size(37, 23);
            this.lbl_TotalFinal.TabIndex = 14;
            this.lbl_TotalFinal.Text = "$ 0";
            // 
            // lbl_CambioFinal
            // 
            this.lbl_CambioFinal.AutoSize = true;
            this.lbl_CambioFinal.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CambioFinal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_CambioFinal.Location = new System.Drawing.Point(327, 442);
            this.lbl_CambioFinal.Name = "lbl_CambioFinal";
            this.lbl_CambioFinal.Size = new System.Drawing.Size(37, 23);
            this.lbl_CambioFinal.TabIndex = 15;
            this.lbl_CambioFinal.Text = "$ 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(314, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cambio:";
            // 
            // lbl_PagoFinal
            // 
            this.lbl_PagoFinal.AutoSize = true;
            this.lbl_PagoFinal.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PagoFinal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_PagoFinal.Location = new System.Drawing.Point(207, 442);
            this.lbl_PagoFinal.Name = "lbl_PagoFinal";
            this.lbl_PagoFinal.Size = new System.Drawing.Size(37, 23);
            this.lbl_PagoFinal.TabIndex = 17;
            this.lbl_PagoFinal.Text = "$ 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(187, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Pago con:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(922, 489);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 920;
            this.lineShape1.Y1 = 383;
            this.lineShape1.Y2 = 383;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_total.Location = new System.Drawing.Point(817, 414);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(94, 44);
            this.lbl_total.TabIndex = 20;
            this.lbl_total.Text = "0.00";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(659, 414);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(119, 51);
            this.iconButton2.TabIndex = 21;
            this.iconButton2.Text = "    Cobrar";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Codigo";
            // 
            // txt_existencia
            // 
            this.txt_existencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_existencia.Enabled = false;
            this.txt_existencia.Location = new System.Drawing.Point(403, 59);
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(100, 20);
            this.txt_existencia.TabIndex = 24;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_cantidad.Location = new System.Drawing.Point(523, 59);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(402, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Existencia";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_codigo.Location = new System.Drawing.Point(139, 59);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(138, 20);
            this.txt_codigo.TabIndex = 28;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_producto_KeyPress);
            // 
            // txt_producto
            // 
            this.txt_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_producto.Enabled = false;
            this.txt_producto.Location = new System.Drawing.Point(289, 59);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(100, 20);
            this.txt_producto.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(288, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Producto";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(784, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 44);
            this.label8.TabIndex = 35;
            this.label8.Text = "$";
            // 
            // panelRealizarVenta
            // 
            this.panelRealizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelRealizarVenta.Controls.Add(this.btn_cancelar);
            this.panelRealizarVenta.Controls.Add(this.btn_realizarVenta);
            this.panelRealizarVenta.Controls.Add(this.label16);
            this.panelRealizarVenta.Controls.Add(this.txt_pago);
            this.panelRealizarVenta.Controls.Add(this.label15);
            this.panelRealizarVenta.Controls.Add(this.lbl_totalPagar);
            this.panelRealizarVenta.Controls.Add(this.label13);
            this.panelRealizarVenta.Location = new System.Drawing.Point(691, 117);
            this.panelRealizarVenta.Name = "panelRealizarVenta";
            this.panelRealizarVenta.Size = new System.Drawing.Size(219, 229);
            this.panelRealizarVenta.TabIndex = 36;
            this.panelRealizarVenta.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_cancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            this.btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelar.IconSize = 30;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(184, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Rotation = 0D;
            this.btn_cancelar.Size = new System.Drawing.Size(33, 27);
            this.btn_cancelar.TabIndex = 44;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_realizarVenta
            // 
            this.btn_realizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            this.btn_realizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_realizarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_realizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_realizarVenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_realizarVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_realizarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_realizarVenta.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_realizarVenta.IconColor = System.Drawing.Color.White;
            this.btn_realizarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_realizarVenta.IconSize = 30;
            this.btn_realizarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_realizarVenta.Location = new System.Drawing.Point(25, 174);
            this.btn_realizarVenta.Name = "btn_realizarVenta";
            this.btn_realizarVenta.Rotation = 0D;
            this.btn_realizarVenta.Size = new System.Drawing.Size(164, 33);
            this.btn_realizarVenta.TabIndex = 40;
            this.btn_realizarVenta.Text = "    Realizar Venta";
            this.btn_realizarVenta.UseVisualStyleBackColor = false;
            this.btn_realizarVenta.Click += new System.EventHandler(this.btn_realizarVenta_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(78, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 24);
            this.label16.TabIndex = 43;
            this.label16.Text = "$";
            // 
            // txt_pago
            // 
            this.txt_pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(71)))));
            this.txt_pago.Location = new System.Drawing.Point(61, 131);
            this.txt_pago.Name = "txt_pago";
            this.txt_pago.Size = new System.Drawing.Size(100, 20);
            this.txt_pago.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(78, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 42;
            this.label15.Text = "Pago:";
            // 
            // lbl_totalPagar
            // 
            this.lbl_totalPagar.AutoSize = true;
            this.lbl_totalPagar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPagar.Location = new System.Drawing.Point(101, 51);
            this.lbl_totalPagar.Name = "lbl_totalPagar";
            this.lbl_totalPagar.Size = new System.Drawing.Size(22, 24);
            this.lbl_totalPagar.TabIndex = 41;
            this.lbl_totalPagar.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "Total a pagar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "No. Venta";
            // 
            // lbl_numVenta
            // 
            this.lbl_numVenta.AutoSize = true;
            this.lbl_numVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numVenta.Location = new System.Drawing.Point(47, 32);
            this.lbl_numVenta.Name = "lbl_numVenta";
            this.lbl_numVenta.Size = new System.Drawing.Size(19, 21);
            this.lbl_numVenta.TabIndex = 38;
            this.lbl_numVenta.Text = "1";
            // 
            // lbl_idDetalleVenta
            // 
            this.lbl_idDetalleVenta.AutoSize = true;
            this.lbl_idDetalleVenta.Location = new System.Drawing.Point(594, 12);
            this.lbl_idDetalleVenta.Name = "lbl_idDetalleVenta";
            this.lbl_idDetalleVenta.Size = new System.Drawing.Size(13, 13);
            this.lbl_idDetalleVenta.TabIndex = 39;
            this.lbl_idDetalleVenta.Text = "0";
            this.lbl_idDetalleVenta.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(402, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 40;
            this.lbl.Visible = false;
            // 
            // dgrid_idDetalleVenta
            // 
            this.dgrid_idDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_idDetalleVenta.Location = new System.Drawing.Point(646, 15);
            this.dgrid_idDetalleVenta.Name = "dgrid_idDetalleVenta";
            this.dgrid_idDetalleVenta.Size = new System.Drawing.Size(19, 16);
            this.dgrid_idDetalleVenta.TabIndex = 41;
            this.dgrid_idDetalleVenta.Visible = false;
            // 
            // dgrid_idVenta
            // 
            this.dgrid_idVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_idVenta.Location = new System.Drawing.Point(671, 14);
            this.dgrid_idVenta.Name = "dgrid_idVenta";
            this.dgrid_idVenta.Size = new System.Drawing.Size(18, 16);
            this.dgrid_idVenta.TabIndex = 42;
            this.dgrid_idVenta.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(706, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Cantidad de Productos:";
            // 
            // lbl_cantProductos
            // 
            this.lbl_cantProductos.AutoSize = true;
            this.lbl_cantProductos.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lbl_cantProductos.Location = new System.Drawing.Point(762, 39);
            this.lbl_cantProductos.Name = "lbl_cantProductos";
            this.lbl_cantProductos.Size = new System.Drawing.Size(24, 25);
            this.lbl_cantProductos.TabIndex = 44;
            this.lbl_cantProductos.Text = "0";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(367, 19);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(35, 13);
            this.lbl_precio.TabIndex = 45;
            this.lbl_precio.Text = "label3";
            this.lbl_precio.Visible = false;
            this.lbl_precio.Click += new System.EventHandler(this.lbl_precio_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // id_detalle
            // 
            this.id_detalle.HeaderText = "id";
            this.id_detalle.Name = "id_detalle";
            this.id_detalle.ReadOnly = true;
            this.id_detalle.Visible = false;
            // 
            // realizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 489);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_cantProductos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgrid_idVenta);
            this.Controls.Add(this.dgrid_idDetalleVenta);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbl_idDetalleVenta);
            this.Controls.Add(this.lbl_numVenta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panelRealizarVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_existencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_PagoFinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_CambioFinal);
            this.Controls.Add(this.lbl_TotalFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_eliminarVentas);
            this.Controls.Add(this.btn_agregarVentas);
            this.Controls.Add(this.dgridVentas);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "realizarVenta";
            this.Text = "Realizar Venta";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelRealizarVenta.ResumeLayout(false);
            this.panelRealizarVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_idDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_idVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridVentas;
        private FontAwesome.Sharp.IconButton btn_eliminarVentas;
        private FontAwesome.Sharp.IconButton btn_agregarVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TotalFinal;
        private System.Windows.Forms.Label lbl_CambioFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_PagoFinal;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lbl_total;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_existencia;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_idDetalleVenta;
        private System.Windows.Forms.Label lbl_numVenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelRealizarVenta;
        private FontAwesome.Sharp.IconButton btn_realizarVenta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_pago;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_totalPagar;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridView dgrid_idDetalleVenta;
        private System.Windows.Forms.DataGridView dgrid_idVenta;
        private System.Windows.Forms.Label lbl_cantProductos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle;
    }
}