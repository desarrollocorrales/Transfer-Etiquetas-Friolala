namespace Transferencias_de_Etiquetas.GUIs
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRutaArchivoEscaneo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.etiquetasGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEtiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroDeEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDeEmpaque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDeCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPiezas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDeRecepcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.ofdBuscar = new System.Windows.Forms.OpenFileDialog();
            this.bgwConsulta = new System.ComponentModel.BackgroundWorker();
            this.pbCargando = new System.Windows.Forms.PictureBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(248, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(289, 64);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Transferencia de Etiquetas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.DoubleClick += new System.EventHandler(this.lblTitulo_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archivo de escaneo:";
            // 
            // txbRutaArchivoEscaneo
            // 
            this.txbRutaArchivoEscaneo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRutaArchivoEscaneo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRutaArchivoEscaneo.Enabled = false;
            this.txbRutaArchivoEscaneo.Location = new System.Drawing.Point(12, 88);
            this.txbRutaArchivoEscaneo.Name = "txbRutaArchivoEscaneo";
            this.txbRutaArchivoEscaneo.Size = new System.Drawing.Size(704, 26);
            this.txbRutaArchivoEscaneo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(722, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 26);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(342, 120);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 35);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.etiquetasGridBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(12, 161);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(760, 330);
            this.gridEtiquetas.TabIndex = 5;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiquetas});
            // 
            // etiquetasGridBindingSource
            // 
            this.etiquetasGridBindingSource.DataSource = typeof(Transferencias_de_Etiquetas.WS_Friolala.EtiquetasGrid);
            // 
            // gvEtiquetas
            // 
            this.gvEtiquetas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gvEtiquetas.Appearance.Empty.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvEtiquetas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvEtiquetas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvEtiquetas.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvEtiquetas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvEtiquetas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvEtiquetas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.gvEtiquetas.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(86)))), ((int)(((byte)(156)))));
            this.gvEtiquetas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.gvEtiquetas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.gvEtiquetas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvEtiquetas.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvEtiquetas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupPanel.Options.UseFont = true;
            this.gvEtiquetas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvEtiquetas.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvEtiquetas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvEtiquetas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvEtiquetas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.gvEtiquetas.Appearance.Preview.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.Preview.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.Row.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.Row.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gvEtiquetas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(116)))));
            this.gvEtiquetas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvEtiquetas.Appearance.VertLine.Options.UseBackColor = true;
            this.gvEtiquetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroDeEtiqueta,
            this.colTipoEtiqueta,
            this.colIdProveedor,
            this.colIdLote,
            this.colIdPedido,
            this.colClave,
            this.colClaveNombre,
            this.colFechaDeEmpaque,
            this.colFechaDeCaducidad,
            this.colCantidad,
            this.colUnidad,
            this.colPiezas,
            this.colFechaDeRecepcion});
            this.gvEtiquetas.GridControl = this.gridEtiquetas;
            this.gvEtiquetas.GroupCount = 1;
            this.gvEtiquetas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NumeroDeEtiqueta", null, "( Etiquetas= {0} )"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", null, "( Cantidad Total= {0:n} )")});
            this.gvEtiquetas.Name = "gvEtiquetas";
            this.gvEtiquetas.OptionsBehavior.Editable = false;
            this.gvEtiquetas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEtiquetas.OptionsView.EnableAppearanceOddRow = true;
            this.gvEtiquetas.OptionsView.ShowFooter = true;
            this.gvEtiquetas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colClaveNombre, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNumeroDeEtiqueta
            // 
            this.colNumeroDeEtiqueta.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroDeEtiqueta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeEtiqueta.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroDeEtiqueta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroDeEtiqueta.FieldName = "NumeroDeEtiqueta";
            this.colNumeroDeEtiqueta.Name = "colNumeroDeEtiqueta";
            this.colNumeroDeEtiqueta.Visible = true;
            this.colNumeroDeEtiqueta.VisibleIndex = 0;
            // 
            // colTipoEtiqueta
            // 
            this.colTipoEtiqueta.FieldName = "TipoEtiqueta";
            this.colTipoEtiqueta.Name = "colTipoEtiqueta";
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colIdLote
            // 
            this.colIdLote.FieldName = "IdLote";
            this.colIdLote.Name = "colIdLote";
            // 
            // colIdPedido
            // 
            this.colIdPedido.FieldName = "IdPedido";
            this.colIdPedido.Name = "colIdPedido";
            // 
            // colClave
            // 
            this.colClave.FieldName = "Clave";
            this.colClave.Name = "colClave";
            // 
            // colClaveNombre
            // 
            this.colClaveNombre.FieldName = "ClaveNombre";
            this.colClaveNombre.Name = "colClaveNombre";
            this.colClaveNombre.Visible = true;
            this.colClaveNombre.VisibleIndex = 6;
            // 
            // colFechaDeEmpaque
            // 
            this.colFechaDeEmpaque.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaDeEmpaque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeEmpaque.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaDeEmpaque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeEmpaque.FieldName = "FechaDeEmpaque";
            this.colFechaDeEmpaque.Name = "colFechaDeEmpaque";
            this.colFechaDeEmpaque.Visible = true;
            this.colFechaDeEmpaque.VisibleIndex = 1;
            // 
            // colFechaDeCaducidad
            // 
            this.colFechaDeCaducidad.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaDeCaducidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeCaducidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaDeCaducidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaDeCaducidad.FieldName = "FechaDeCaducidad";
            this.colFechaDeCaducidad.Name = "colFechaDeCaducidad";
            this.colFechaDeCaducidad.Visible = true;
            this.colFechaDeCaducidad.VisibleIndex = 2;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.DisplayFormat.FormatString = "n";
            this.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            // 
            // colUnidad
            // 
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 4;
            // 
            // colPiezas
            // 
            this.colPiezas.AppearanceCell.Options.UseTextOptions = true;
            this.colPiezas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPiezas.AppearanceHeader.Options.UseTextOptions = true;
            this.colPiezas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPiezas.FieldName = "Piezas";
            this.colPiezas.Name = "colPiezas";
            this.colPiezas.Visible = true;
            this.colPiezas.VisibleIndex = 5;
            // 
            // colFechaDeRecepcion
            // 
            this.colFechaDeRecepcion.FieldName = "FechaDeRecepcion";
            this.colFechaDeRecepcion.Name = "colFechaDeRecepcion";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTransferir.AutoSize = true;
            this.btnTransferir.BackColor = System.Drawing.Color.White;
            this.btnTransferir.Enabled = false;
            this.btnTransferir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTransferir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Location = new System.Drawing.Point(342, 515);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(100, 35);
            this.btnTransferir.TabIndex = 6;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // ofdBuscar
            // 
            this.ofdBuscar.Filter = "Archivos de Texto | *.txt";
            // 
            // bgwConsulta
            // 
            this.bgwConsulta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsulta_DoWork);
            this.bgwConsulta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConsulta_RunWorkerCompleted);
            // 
            // pbCargando
            // 
            this.pbCargando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCargando.Image = ((System.Drawing.Image)(resources.GetObject("pbCargando.Image")));
            this.pbCargando.Location = new System.Drawing.Point(308, 234);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(169, 94);
            this.pbCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCargando.TabIndex = 7;
            this.pbCargando.TabStop = false;
            this.pbCargando.Visible = false;
            // 
            // lblTiempo
            // 
            this.lblTiempo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTiempo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(12, 494);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(760, 18);
            this.lblTiempo.TabIndex = 8;
            this.lblTiempo.Text = "Tiempo de consulta: 0 segundos.";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(544, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbRutaArchivoEscaneo);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.pbCargando);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.gridEtiquetas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Transferencias de etiquetas";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRutaArchivoEscaneo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConsultar;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiquetas;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.BindingSource etiquetasGridBindingSource;
        private System.Windows.Forms.OpenFileDialog ofdBuscar;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDeEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLote;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colClave;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDeEmpaque;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDeCaducidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPiezas;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDeRecepcion;
        private System.ComponentModel.BackgroundWorker bgwConsulta;
        private System.Windows.Forms.PictureBox pbCargando;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}