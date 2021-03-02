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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_agregar = new FontAwesome.Sharp.IconButton();
            this.lbl_cantProductos = new System.Windows.Forms.Label();
            this.iconlupa = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dgrid_inventario = new System.Windows.Forms.DataGridView();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscarProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconlupa)).BeginInit();
            this.panelAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_agregar.IconColor = System.Drawing.Color.White;
            this.btn_agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregar.IconSize = 30;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(619, 141);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Rotation = 0D;
            this.btn_agregar.Size = new System.Drawing.Size(224, 48);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "     Agregar a Inventario";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.Btn_agregarInventario_Click);
            // 
            // lbl_cantProductos
            // 
            this.lbl_cantProductos.AutoSize = true;
            this.lbl_cantProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cantProductos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantProductos.ForeColor = System.Drawing.Color.Black;
            this.lbl_cantProductos.Location = new System.Drawing.Point(764, 40);
            this.lbl_cantProductos.Name = "lbl_cantProductos";
            this.lbl_cantProductos.Size = new System.Drawing.Size(30, 33);
            this.lbl_cantProductos.TabIndex = 11;
            this.lbl_cantProductos.Text = "0";
            // 
            // iconlupa
            // 
            this.iconlupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconlupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconlupa.ForeColor = System.Drawing.Color.Black;
            this.iconlupa.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconlupa.IconColor = System.Drawing.Color.Black;
            this.iconlupa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconlupa.IconSize = 20;
            this.iconlupa.Location = new System.Drawing.Point(71, 85);
            this.iconlupa.Name = "iconlupa";
            this.iconlupa.Size = new System.Drawing.Size(23, 20);
            this.iconlupa.TabIndex = 13;
            this.iconlupa.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(699, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad de productos";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_eliminar.IconColor = System.Drawing.Color.White;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.IconSize = 30;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(619, 207);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Rotation = 0D;
            this.btn_eliminar.Size = new System.Drawing.Size(224, 48);
            this.btn_eliminar.TabIndex = 15;
            this.btn_eliminar.Text = "       Eliminar del inventario";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // panelAgregar
            // 
            this.panelAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelAgregar.Controls.Add(this.btn_cancelar);
            this.panelAgregar.Controls.Add(this.btn_agregar_inventario);
            this.panelAgregar.Controls.Add(this.label6);
            this.panelAgregar.Controls.Add(this.txt_existencia);
            this.panelAgregar.Controls.Add(this.label5);
            this.panelAgregar.Controls.Add(this.cbx_productos);
            this.panelAgregar.Controls.Add(this.label1);
            this.panelAgregar.Location = new System.Drawing.Point(180, 10);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(56, 28);
            this.panelAgregar.TabIndex = 16;
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
            this.btn_cancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_cancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            this.btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelar.IconSize = 30;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(311, 1);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Rotation = 0D;
            this.btn_cancelar.Size = new System.Drawing.Size(39, 36);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // btn_agregar_inventario
            // 
            this.btn_agregar_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(71)))));
            this.btn_agregar_inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_inventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_agregar_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_inventario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_agregar_inventario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_inventario.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_inventario.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_agregar_inventario.IconColor = System.Drawing.Color.White;
            this.btn_agregar_inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregar_inventario.IconSize = 30;
            this.btn_agregar_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar_inventario.Location = new System.Drawing.Point(33, 255);
            this.btn_agregar_inventario.Name = "btn_agregar_inventario";
            this.btn_agregar_inventario.Rotation = 0D;
            this.btn_agregar_inventario.Size = new System.Drawing.Size(291, 36);
            this.btn_agregar_inventario.TabIndex = 17;
            this.btn_agregar_inventario.Text = "       Agregar";
            this.btn_agregar_inventario.UseVisualStyleBackColor = false;
            this.btn_agregar_inventario.Click += new System.EventHandler(this.Btn_agregar_inventario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(77, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Existencia";
            // 
            // txt_existencia
            // 
            this.txt_existencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(71)))));
            this.txt_existencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_existencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia.ForeColor = System.Drawing.Color.Black;
            this.txt_existencia.Location = new System.Drawing.Point(79, 171);
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(189, 23);
            this.txt_existencia.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(79, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Producto";
            // 
            // cbx_productos
            // 
            this.cbx_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(71)))));
            this.cbx_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_productos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_productos.ForeColor = System.Drawing.Color.Black;
            this.cbx_productos.FormattingEnabled = true;
            this.cbx_productos.Location = new System.Drawing.Point(79, 99);
            this.cbx_productos.Name = "cbx_productos";
            this.cbx_productos.Size = new System.Drawing.Size(189, 25);
            this.cbx_productos.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Agregar producto";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgrid_inventario
            // 
            this.dgrid_inventario.AllowUserToAddRows = false;
            this.dgrid_inventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_inventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_inventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgrid_inventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_inventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrid_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_inventario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgrid_inventario.EnableHeadersVisualStyles = false;
            this.dgrid_inventario.GridColor = System.Drawing.Color.White;
            this.dgrid_inventario.Location = new System.Drawing.Point(66, 141);
            this.dgrid_inventario.Name = "dgrid_inventario";
            this.dgrid_inventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_inventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgrid_inventario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgrid_inventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgrid_inventario.Size = new System.Drawing.Size(528, 259);
            this.dgrid_inventario.TabIndex = 19;
            this.dgrid_inventario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_inventario_CellEndEdit_1);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.Black;
            this.lbl_buscar.Location = new System.Drawing.Point(70, 60);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(58, 20);
            this.lbl_buscar.TabIndex = 20;
            this.lbl_buscar.Text = "Buscar";
            // 
            // txt_buscarProducto
            // 
            this.txt_buscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_buscarProducto.Location = new System.Drawing.Point(92, 85);
            this.txt_buscarProducto.Name = "txt_buscarProducto";
            this.txt_buscarProducto.Size = new System.Drawing.Size(322, 20);
            this.txt_buscarProducto.TabIndex = 21;
            this.txt_buscarProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_buscarProducto_KeyDown);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 443);
            this.Controls.Add(this.txt_buscarProducto);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.dgrid_inventario);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.iconlupa);
            this.Controls.Add(this.lbl_cantProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.iconlupa)).EndInit();
            this.panelAgregar.ResumeLayout(false);
            this.panelAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_agregar;
        private System.Windows.Forms.Label lbl_cantProductos;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconlupa;
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
        private System.Windows.Forms.DataGridView dgrid_inventario;
        private System.Windows.Forms.TextBox txt_buscarProducto;
        private System.Windows.Forms.Label lbl_buscar;
    }
}