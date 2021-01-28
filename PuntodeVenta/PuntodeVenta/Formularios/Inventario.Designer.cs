namespace PuntodeVenta
{
    partial class Inventario
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
            this.dgrid_inventario = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new FontAwesome.Sharp.IconButton();
            this.lbl_cantProductos = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txt_buscarProducto = new PlaceholderTextBox.PlaceholderTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.btn_agregar_inventario = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_existencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_productos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_inventario
            // 
            this.dgrid_inventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.dgrid_inventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_inventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_inventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_inventario.EnableHeadersVisualStyles = false;
            this.dgrid_inventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.dgrid_inventario.Location = new System.Drawing.Point(61, 144);
            this.dgrid_inventario.Name = "dgrid_inventario";
            this.dgrid_inventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_inventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(98)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.dgrid_inventario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrid_inventario.Size = new System.Drawing.Size(521, 244);
            this.dgrid_inventario.TabIndex = 2;
            this.dgrid_inventario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_inventario_CellEndEdit);
            this.dgrid_inventario.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgrid_inventario_EditingControlShowing);
            this.dgrid_inventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgrid_inventario_KeyPress);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_agregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_agregar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregar.IconSize = 30;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(610, 144);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Rotation = 0D;
            this.btn_agregar.Size = new System.Drawing.Size(154, 36);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "     Agregar a Inv.";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.Btn_agregarInventario_Click);
            // 
            // lbl_cantProductos
            // 
            this.lbl_cantProductos.AutoSize = true;
            this.lbl_cantProductos.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_cantProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_cantProductos.Location = new System.Drawing.Point(669, 45);
            this.lbl_cantProductos.Name = "lbl_cantProductos";
            this.lbl_cantProductos.Size = new System.Drawing.Size(30, 32);
            this.lbl_cantProductos.TabIndex = 11;
            this.lbl_cantProductos.Text = "0";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 22;
            this.iconPictureBox1.Location = new System.Drawing.Point(62, 94);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 22);
            this.iconPictureBox1.TabIndex = 13;
            this.iconPictureBox1.TabStop = false;
            // 
            // txt_buscarProducto
            // 
            this.txt_buscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_buscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_buscarProducto.Location = new System.Drawing.Point(87, 94);
            this.txt_buscarProducto.Name = "txt_buscarProducto";
            this.txt_buscarProducto.PlaceholderText = "Buscar";
            this.txt_buscarProducto.Size = new System.Drawing.Size(323, 22);
            this.txt_buscarProducto.TabIndex = 12;
            this.txt_buscarProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_buscarProducto_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(189)))), ((int)(((byte)(144)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(600, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(270, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reporte de Inventario";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_eliminar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.IconSize = 30;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(610, 210);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Rotation = 0D;
            this.btn_eliminar.Size = new System.Drawing.Size(154, 36);
            this.btn_eliminar.TabIndex = 15;
            this.btn_eliminar.Text = "       Eliminar de Inv.";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // panelAgregar
            // 
            this.panelAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(18)))));
            this.panelAgregar.Controls.Add(this.btn_cancelar);
            this.panelAgregar.Controls.Add(this.btn_agregar_inventario);
            this.panelAgregar.Controls.Add(this.label6);
            this.panelAgregar.Controls.Add(this.txt_existencia);
            this.panelAgregar.Controls.Add(this.label5);
            this.panelAgregar.Controls.Add(this.cbx_productos);
            this.panelAgregar.Controls.Add(this.label1);
            this.panelAgregar.Location = new System.Drawing.Point(521, 21);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(27, 25);
            this.panelAgregar.TabIndex = 16;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_cancelar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelar.IconSize = 30;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(23, 216);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Rotation = 0D;
            this.btn_cancelar.Size = new System.Drawing.Size(108, 36);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "       Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // btn_agregar_inventario
            // 
            this.btn_agregar_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_agregar_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_inventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_agregar_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_inventario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_agregar_inventario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_inventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_agregar_inventario.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_agregar_inventario.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_agregar_inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregar_inventario.IconSize = 30;
            this.btn_agregar_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar_inventario.Location = new System.Drawing.Point(149, 216);
            this.btn_agregar_inventario.Name = "btn_agregar_inventario";
            this.btn_agregar_inventario.Rotation = 0D;
            this.btn_agregar_inventario.Size = new System.Drawing.Size(108, 36);
            this.btn_agregar_inventario.TabIndex = 17;
            this.btn_agregar_inventario.Text = "       Agregar";
            this.btn_agregar_inventario.UseVisualStyleBackColor = false;
            this.btn_agregar_inventario.Click += new System.EventHandler(this.Btn_agregar_inventario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(18)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(44, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Existencia";
            // 
            // txt_existencia
            // 
            this.txt_existencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_existencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_existencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_existencia.Location = new System.Drawing.Point(47, 171);
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(175, 23);
            this.txt_existencia.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(18)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(44, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Producto";
            // 
            // cbx_productos
            // 
            this.cbx_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.cbx_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_productos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_productos.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbx_productos.FormattingEnabled = true;
            this.cbx_productos.Location = new System.Drawing.Point(47, 99);
            this.cbx_productos.Name = "cbx_productos";
            this.cbx_productos.Size = new System.Drawing.Size(175, 24);
            this.cbx_productos.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Agregar producto";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(189)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(785, 457);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lbl_cantProductos);
            this.Controls.Add(this.txt_buscarProducto);
            this.Controls.Add(this.dgrid_inventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelAgregar.ResumeLayout(false);
            this.panelAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_inventario;
        private FontAwesome.Sharp.IconButton btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cantProductos;
        private System.Windows.Forms.Label label3;
        private PlaceholderTextBox.PlaceholderTextBox txt_buscarProducto;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private System.Windows.Forms.Panel panelAgregar;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private FontAwesome.Sharp.IconButton btn_agregar_inventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_existencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}