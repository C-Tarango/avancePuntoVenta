namespace PuntodeVenta
{
    partial class Productos
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
            this.dgridProductos = new System.Windows.Forms.DataGridView();
            this.txt_buscarProducto = new PlaceholderTextBox.PlaceholderTextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_agregarProducto = new FontAwesome.Sharp.IconButton();
            this.btn_editarProducto = new FontAwesome.Sharp.IconButton();
            this.btn_eliminarProducto = new FontAwesome.Sharp.IconButton();
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.txt_precioCompra_agregar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_precioVenta_agregar = new System.Windows.Forms.TextBox();
            this.txt_nombre_agregar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_categorias_productosA = new System.Windows.Forms.ComboBox();
            this.btn_cancelarProductoA = new FontAwesome.Sharp.IconButton();
            this.btn_agregarProductoA = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelActualizar = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_precioCompra_actualizar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_precioVenta_actualizar = new System.Windows.Forms.TextBox();
            this.txt_nombreActualizar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cbx_categoriasActualizar = new System.Windows.Forms.ComboBox();
            this.btn_cancelarProductosE = new FontAwesome.Sharp.IconButton();
            this.btn_editarProductos = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCategoria = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.placeholderTextBox2 = new PlaceholderTextBox.PlaceholderTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_cantidadProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelAgregar.SuspendLayout();
            this.panelActualizar.SuspendLayout();
            this.panelCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridProductos
            // 
            this.dgridProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.dgridProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgridProductos.EnableHeadersVisualStyles = false;
            this.dgridProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.dgridProductos.Location = new System.Drawing.Point(123, 122);
            this.dgridProductos.Name = "dgridProductos";
            this.dgridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(98)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.dgridProductos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgridProductos.Size = new System.Drawing.Size(558, 279);
            this.dgridProductos.TabIndex = 0;
            // 
            // txt_buscarProducto
            // 
            this.txt_buscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_buscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_buscarProducto.Location = new System.Drawing.Point(146, 80);
            this.txt_buscarProducto.Name = "txt_buscarProducto";
            this.txt_buscarProducto.PlaceholderText = "Buscar";
            this.txt_buscarProducto.Size = new System.Drawing.Size(326, 22);
            this.txt_buscarProducto.TabIndex = 1;
            this.txt_buscarProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_buscarProducto_KeyDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 22;
            this.iconPictureBox1.Location = new System.Drawing.Point(123, 80);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 22);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_agregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_agregarProducto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_agregarProducto.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_agregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregarProducto.IconSize = 30;
            this.btn_agregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarProducto.Location = new System.Drawing.Point(735, 122);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Rotation = 0D;
            this.btn_agregarProducto.Size = new System.Drawing.Size(134, 30);
            this.btn_agregarProducto.TabIndex = 3;
            this.btn_agregarProducto.Text = "     Agregar";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.Btn_agregarProducto_Click);
            // 
            // btn_editarProducto
            // 
            this.btn_editarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_editarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_editarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarProducto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_editarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_editarProducto.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_editarProducto.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_editarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_editarProducto.IconSize = 30;
            this.btn_editarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editarProducto.Location = new System.Drawing.Point(734, 177);
            this.btn_editarProducto.Name = "btn_editarProducto";
            this.btn_editarProducto.Rotation = 0D;
            this.btn_editarProducto.Size = new System.Drawing.Size(134, 30);
            this.btn_editarProducto.TabIndex = 4;
            this.btn_editarProducto.Text = "Actualizar";
            this.btn_editarProducto.UseVisualStyleBackColor = false;
            this.btn_editarProducto.Click += new System.EventHandler(this.Btn_editarProducto_Click);
            // 
            // btn_eliminarProducto
            // 
            this.btn_eliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_eliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_eliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarProducto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_eliminarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_eliminarProducto.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_eliminarProducto.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_eliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminarProducto.IconSize = 30;
            this.btn_eliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarProducto.Location = new System.Drawing.Point(735, 235);
            this.btn_eliminarProducto.Name = "btn_eliminarProducto";
            this.btn_eliminarProducto.Rotation = 0D;
            this.btn_eliminarProducto.Size = new System.Drawing.Size(134, 30);
            this.btn_eliminarProducto.TabIndex = 5;
            this.btn_eliminarProducto.Text = "Eliminar";
            this.btn_eliminarProducto.UseVisualStyleBackColor = false;
            this.btn_eliminarProducto.Click += new System.EventHandler(this.Btn_eliminarProducto_Click);
            // 
            // panelAgregar
            // 
            this.panelAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(18)))));
            this.panelAgregar.Controls.Add(this.txt_precioCompra_agregar);
            this.panelAgregar.Controls.Add(this.label12);
            this.panelAgregar.Controls.Add(this.label11);
            this.panelAgregar.Controls.Add(this.txt_precioVenta_agregar);
            this.panelAgregar.Controls.Add(this.txt_nombre_agregar);
            this.panelAgregar.Controls.Add(this.label10);
            this.panelAgregar.Controls.Add(this.label5);
            this.panelAgregar.Controls.Add(this.cbx_categorias_productosA);
            this.panelAgregar.Controls.Add(this.btn_cancelarProductoA);
            this.panelAgregar.Controls.Add(this.btn_agregarProductoA);
            this.panelAgregar.Controls.Add(this.label1);
            this.panelAgregar.Location = new System.Drawing.Point(242, 19);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(21, 15);
            this.panelAgregar.TabIndex = 6;
            this.panelAgregar.Visible = false;
            // 
            // txt_precioCompra_agregar
            // 
            this.txt_precioCompra_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_precioCompra_agregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precioCompra_agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioCompra_agregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_precioCompra_agregar.Location = new System.Drawing.Point(99, 127);
            this.txt_precioCompra_agregar.Name = "txt_precioCompra_agregar";
            this.txt_precioCompra_agregar.Size = new System.Drawing.Size(258, 22);
            this.txt_precioCompra_agregar.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(99, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Precio Venta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(99, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Precio Compra";
            // 
            // txt_precioVenta_agregar
            // 
            this.txt_precioVenta_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_precioVenta_agregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precioVenta_agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioVenta_agregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_precioVenta_agregar.Location = new System.Drawing.Point(99, 185);
            this.txt_precioVenta_agregar.Name = "txt_precioVenta_agregar";
            this.txt_precioVenta_agregar.Size = new System.Drawing.Size(258, 22);
            this.txt_precioVenta_agregar.TabIndex = 21;
            // 
            // txt_nombre_agregar
            // 
            this.txt_nombre_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_nombre_agregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre_agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_agregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nombre_agregar.Location = new System.Drawing.Point(99, 73);
            this.txt_nombre_agregar.Name = "txt_nombre_agregar";
            this.txt_nombre_agregar.Size = new System.Drawing.Size(258, 22);
            this.txt_nombre_agregar.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(99, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(18)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(99, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Categoria";
            // 
            // cbx_categorias_productosA
            // 
            this.cbx_categorias_productosA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.cbx_categorias_productosA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_categorias_productosA.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_categorias_productosA.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbx_categorias_productosA.FormattingEnabled = true;
            this.cbx_categorias_productosA.Items.AddRange(new object[] {
            "Categoria"});
            this.cbx_categorias_productosA.Location = new System.Drawing.Point(99, 247);
            this.cbx_categorias_productosA.Name = "cbx_categorias_productosA";
            this.cbx_categorias_productosA.Size = new System.Drawing.Size(230, 23);
            this.cbx_categorias_productosA.TabIndex = 11;
            // 
            // btn_cancelarProductoA
            // 
            this.btn_cancelarProductoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_cancelarProductoA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarProductoA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_cancelarProductoA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarProductoA.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_cancelarProductoA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarProductoA.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelarProductoA.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_cancelarProductoA.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelarProductoA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelarProductoA.IconSize = 30;
            this.btn_cancelarProductoA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelarProductoA.Location = new System.Drawing.Point(33, 295);
            this.btn_cancelarProductoA.Name = "btn_cancelarProductoA";
            this.btn_cancelarProductoA.Rotation = 0D;
            this.btn_cancelarProductoA.Size = new System.Drawing.Size(134, 30);
            this.btn_cancelarProductoA.TabIndex = 7;
            this.btn_cancelarProductoA.Text = "Cancelar";
            this.btn_cancelarProductoA.UseVisualStyleBackColor = false;
            this.btn_cancelarProductoA.Click += new System.EventHandler(this.Btn_cancelarProductoA_Click);
            // 
            // btn_agregarProductoA
            // 
            this.btn_agregarProductoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_agregarProductoA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarProductoA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_agregarProductoA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProductoA.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_agregarProductoA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProductoA.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_agregarProductoA.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_agregarProductoA.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_agregarProductoA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregarProductoA.IconSize = 30;
            this.btn_agregarProductoA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarProductoA.Location = new System.Drawing.Point(294, 295);
            this.btn_agregarProductoA.Name = "btn_agregarProductoA";
            this.btn_agregarProductoA.Rotation = 0D;
            this.btn_agregarProductoA.Size = new System.Drawing.Size(134, 30);
            this.btn_agregarProductoA.TabIndex = 7;
            this.btn_agregarProductoA.Text = "     Agregar";
            this.btn_agregarProductoA.UseVisualStyleBackColor = false;
            this.btn_agregarProductoA.Click += new System.EventHandler(this.Btn_agregarProductoA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(154, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Agregar Producto";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panelActualizar
            // 
            this.panelActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(18)))));
            this.panelActualizar.Controls.Add(this.label9);
            this.panelActualizar.Controls.Add(this.txt_precioCompra_actualizar);
            this.panelActualizar.Controls.Add(this.label8);
            this.panelActualizar.Controls.Add(this.txt_precioVenta_actualizar);
            this.panelActualizar.Controls.Add(this.txt_nombreActualizar);
            this.panelActualizar.Controls.Add(this.label7);
            this.panelActualizar.Controls.Add(this.label6);
            this.panelActualizar.Controls.Add(this.lbl_id);
            this.panelActualizar.Controls.Add(this.cbx_categoriasActualizar);
            this.panelActualizar.Controls.Add(this.btn_cancelarProductosE);
            this.panelActualizar.Controls.Add(this.btn_editarProductos);
            this.panelActualizar.Controls.Add(this.label2);
            this.panelActualizar.Location = new System.Drawing.Point(275, 19);
            this.panelActualizar.Name = "panelActualizar";
            this.panelActualizar.Size = new System.Drawing.Size(23, 21);
            this.panelActualizar.TabIndex = 13;
            this.panelActualizar.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(99, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Categoria";
            // 
            // txt_precioCompra_actualizar
            // 
            this.txt_precioCompra_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_precioCompra_actualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precioCompra_actualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioCompra_actualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_precioCompra_actualizar.Location = new System.Drawing.Point(99, 127);
            this.txt_precioCompra_actualizar.Name = "txt_precioCompra_actualizar";
            this.txt_precioCompra_actualizar.Size = new System.Drawing.Size(249, 22);
            this.txt_precioCompra_actualizar.TabIndex = 18;
            this.txt_precioCompra_actualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_precioVenta_agregar_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(99, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Precio Compra";
            // 
            // txt_precioVenta_actualizar
            // 
            this.txt_precioVenta_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_precioVenta_actualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precioVenta_actualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioVenta_actualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_precioVenta_actualizar.Location = new System.Drawing.Point(99, 185);
            this.txt_precioVenta_actualizar.Name = "txt_precioVenta_actualizar";
            this.txt_precioVenta_actualizar.Size = new System.Drawing.Size(250, 22);
            this.txt_precioVenta_actualizar.TabIndex = 16;
            this.txt_precioVenta_actualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_precioVenta_agregar_KeyPress);
            // 
            // txt_nombreActualizar
            // 
            this.txt_nombreActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txt_nombreActualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombreActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreActualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_nombreActualizar.Location = new System.Drawing.Point(99, 73);
            this.txt_nombreActualizar.Name = "txt_nombreActualizar";
            this.txt_nombreActualizar.Size = new System.Drawing.Size(250, 22);
            this.txt_nombreActualizar.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(99, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(99, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(31, 19);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(35, 13);
            this.lbl_id.TabIndex = 12;
            this.lbl_id.Text = "label6";
            this.lbl_id.Visible = false;
            // 
            // cbx_categoriasActualizar
            // 
            this.cbx_categoriasActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.cbx_categoriasActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_categoriasActualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_categoriasActualizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbx_categoriasActualizar.FormattingEnabled = true;
            this.cbx_categoriasActualizar.Items.AddRange(new object[] {
            "Categoria"});
            this.cbx_categoriasActualizar.Location = new System.Drawing.Point(99, 247);
            this.cbx_categoriasActualizar.Name = "cbx_categoriasActualizar";
            this.cbx_categoriasActualizar.Size = new System.Drawing.Size(230, 23);
            this.cbx_categoriasActualizar.TabIndex = 11;
            // 
            // btn_cancelarProductosE
            // 
            this.btn_cancelarProductosE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_cancelarProductosE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarProductosE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_cancelarProductosE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarProductosE.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_cancelarProductosE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarProductosE.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelarProductosE.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_cancelarProductosE.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelarProductosE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelarProductosE.IconSize = 30;
            this.btn_cancelarProductosE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelarProductosE.Location = new System.Drawing.Point(35, 295);
            this.btn_cancelarProductosE.Name = "btn_cancelarProductosE";
            this.btn_cancelarProductosE.Rotation = 0D;
            this.btn_cancelarProductosE.Size = new System.Drawing.Size(134, 30);
            this.btn_cancelarProductosE.TabIndex = 7;
            this.btn_cancelarProductosE.Text = "Cancelar";
            this.btn_cancelarProductosE.UseVisualStyleBackColor = false;
            this.btn_cancelarProductosE.Click += new System.EventHandler(this.Btn_cancelarProductosE_Click);
            // 
            // btn_editarProductos
            // 
            this.btn_editarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_editarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editarProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_editarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_editarProductos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_editarProductos.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_editarProductos.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_editarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_editarProductos.IconSize = 30;
            this.btn_editarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editarProductos.Location = new System.Drawing.Point(294, 295);
            this.btn_editarProductos.Name = "btn_editarProductos";
            this.btn_editarProductos.Rotation = 0D;
            this.btn_editarProductos.Size = new System.Drawing.Size(134, 30);
            this.btn_editarProductos.TabIndex = 7;
            this.btn_editarProductos.Text = "     Actualizar";
            this.btn_editarProductos.UseVisualStyleBackColor = false;
            this.btn_editarProductos.Click += new System.EventHandler(this.Btn_editarProductos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(154, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Actualizar Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(189)))), ((int)(((byte)(144)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(327, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nueva categoria de producto";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // panelCategoria
            // 
            this.panelCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.panelCategoria.Controls.Add(this.iconButton1);
            this.panelCategoria.Controls.Add(this.iconButton2);
            this.panelCategoria.Controls.Add(this.label4);
            this.panelCategoria.Controls.Add(this.placeholderTextBox2);
            this.panelCategoria.Location = new System.Drawing.Point(219, 19);
            this.panelCategoria.Name = "panelCategoria";
            this.panelCategoria.Size = new System.Drawing.Size(17, 19);
            this.panelCategoria.TabIndex = 15;
            this.panelCategoria.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(180, 204);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(134, 30);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.Text = "     Agregar";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(11, 204);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(134, 30);
            this.iconButton2.TabIndex = 17;
            this.iconButton2.Text = "Cancelar";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.IconButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(68, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nueva categoria";
            // 
            // placeholderTextBox2
            // 
            this.placeholderTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.placeholderTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeholderTextBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderTextBox2.Location = new System.Drawing.Point(45, 105);
            this.placeholderTextBox2.Name = "placeholderTextBox2";
            this.placeholderTextBox2.PlaceholderText = "Nombre de la Categoria";
            this.placeholderTextBox2.Size = new System.Drawing.Size(230, 21);
            this.placeholderTextBox2.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(704, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Cantidad de productos:";
            // 
            // lbl_cantidadProductos
            // 
            this.lbl_cantidadProductos.AutoSize = true;
            this.lbl_cantidadProductos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_cantidadProductos.Location = new System.Drawing.Point(868, 15);
            this.lbl_cantidadProductos.Name = "lbl_cantidadProductos";
            this.lbl_cantidadProductos.Size = new System.Drawing.Size(24, 25);
            this.lbl_cantidadProductos.TabIndex = 17;
            this.lbl_cantidadProductos.Text = "0";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(189)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(933, 459);
            this.Controls.Add(this.lbl_cantidadProductos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panelCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelActualizar);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.btn_eliminarProducto);
            this.Controls.Add(this.btn_editarProducto);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txt_buscarProducto);
            this.Controls.Add(this.dgridProductos);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelAgregar.ResumeLayout(false);
            this.panelAgregar.PerformLayout();
            this.panelActualizar.ResumeLayout(false);
            this.panelActualizar.PerformLayout();
            this.panelCategoria.ResumeLayout(false);
            this.panelCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridProductos;
        private PlaceholderTextBox.PlaceholderTextBox txt_buscarProducto;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btn_agregarProducto;
        private FontAwesome.Sharp.IconButton btn_editarProducto;
        private FontAwesome.Sharp.IconButton btn_eliminarProducto;
        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.ComboBox cbx_categorias_productosA;
        private FontAwesome.Sharp.IconButton btn_cancelarProductoA;
        private FontAwesome.Sharp.IconButton btn_agregarProductoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelActualizar;
        private System.Windows.Forms.ComboBox cbx_categoriasActualizar;
        private FontAwesome.Sharp.IconButton btn_cancelarProductosE;
        private FontAwesome.Sharp.IconButton btn_editarProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelCategoria;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label4;
        private PlaceholderTextBox.PlaceholderTextBox placeholderTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_precioCompra_actualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_precioVenta_actualizar;
        private System.Windows.Forms.TextBox txt_nombreActualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_precioCompra_agregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_precioVenta_agregar;
        private System.Windows.Forms.TextBox txt_nombre_agregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_cantidadProductos;
        private System.Windows.Forms.Label label13;
    }
}