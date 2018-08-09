namespace SoftManager
{
    partial class frmMain
    {

        private System.ComponentModel.IContainer components = null;
        [System.Diagnostics.DebuggerStepThrough()]

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            C1.Win.C1Command.C1NavBarButton c1NavBarButton1 = new C1.Win.C1Command.C1NavBarButton();
            C1.Win.C1Command.C1NavBarButton c1NavBarButton2 = new C1.Win.C1Command.C1NavBarButton();
            C1.Win.C1Command.C1NavBarButton c1NavBarButton3 = new C1.Win.C1Command.C1NavBarButton();
            C1.Win.C1Command.C1NavBarButton c1NavBarButton4 = new C1.Win.C1Command.C1NavBarButton();
            C1.Win.C1Command.C1NavBarButton c1NavBarButton5 = new C1.Win.C1Command.C1NavBarButton();
            C1.Win.C1Command.C1NavBarButton c1NavBarButton6 = new C1.Win.C1Command.C1NavBarButton();
            C1.Win.C1Command.C1NavBarButton c1NavBarButton7 = new C1.Win.C1Command.C1NavBarButton();
            C1.Win.C1Command.C1NavBarButton c1NavBarButton8 = new C1.Win.C1Command.C1NavBarButton();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Clienti");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Export");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Gestiune");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Produse");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Stoc chitante");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Stoc produse");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Stocuri detaliate");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Stocuri", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Introducere document nou");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Lista documente existente");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Generare NIR");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Lista NIR existente");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Facturi/Proforme/Avize");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Bon de transfer");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Bon de consum");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Raport de gestiune");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Situatie inventar");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Evolutia valorica a stocului");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Evolutia cantitativa a produselor");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Incaseaza factura");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Cautare documente");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Facturi scadente sau neincasate");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Facturi incasate");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Facturi anulate");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Rapoarte", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Vizualizare stoc");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Nomenclator produse");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Avertizari stoc");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Adauga client");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Modificare/Stergere client");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Lista clienti");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Trmite SMS Clientului");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Newsletter Clienti");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Emite chitanţă");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Predare chitanţe");
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFisier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFereastra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdaugaFirma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListaFirme = new System.Windows.Forms.ToolStripMenuItem();
            this.MLMMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RegularizariMLMfrmRegularizariMLMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDocumenteIntrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreazaNIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu12 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConturiSoftManager = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrareConturiSoftManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificareContExistentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu12p1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreazaCopieSiguranta = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerBazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetariProgramSetariProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModificareParola = new System.Windows.Forms.ToolStripMenuItem();
            this.TariJudeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportIncasariDinExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportProduse = new System.Windows.Forms.ToolStripMenuItem();
            this.preluareBNRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjutor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManual = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDespre = new System.Windows.Forms.ToolStripMenuItem();
            this.HiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NavBar = new C1.Win.C1Command.C1NavBar();
            this.C1NavBarPanel2 = new C1.Win.C1Command.C1NavBarPanel();
            this.treeRapoarte = new System.Windows.Forms.TreeView();
            this.C1NavBarPanel17 = new C1.Win.C1Command.C1NavBarPanel();
            this.treeIntrari = new System.Windows.Forms.TreeView();
            this.C1NavBarPanel9 = new C1.Win.C1Command.C1NavBarPanel();
            this.treeIesiri = new System.Windows.Forms.TreeView();
            this.C1NavBarPanel4 = new C1.Win.C1Command.C1NavBarPanel();
            this.treeSituatii = new System.Windows.Forms.TreeView();
            this.C1NavBarPanel15 = new C1.Win.C1Command.C1NavBarPanel();
            this.treeFacturi = new System.Windows.Forms.TreeView();
            this.C1NavBarPanel11 = new C1.Win.C1Command.C1NavBarPanel();
            this.treeStoc = new System.Windows.Forms.TreeView();
            this.C1NavBarPanel6 = new C1.Win.C1Command.C1NavBarPanel();
            this.treeClienti = new System.Windows.Forms.TreeView();
            this.C1NavBarPanel5 = new C1.Win.C1Command.C1NavBarPanel();
            this.treeChitante = new System.Windows.Forms.TreeView();
            this.C1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.btnCascade = new C1.Win.C1Command.C1Command();
            this.btnTileVertical = new C1.Win.C1Command.C1Command();
            this.btnTileHorizontal = new C1.Win.C1Command.C1Command();
            this.btnShowHide = new C1.Win.C1Command.C1Command();
            this.btnEmitereRapida = new C1.Win.C1Command.C1Command();
            this.C1CommandControl1 = new C1.Win.C1Command.C1CommandControl();
            this.C1Command1 = new C1.Win.C1Command.C1Command();
            this.bCautare = new C1.Win.C1Command.C1Command();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.C1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
            this.bShowHide = new C1.Win.C1Command.C1CommandLink();
            this.bCascade = new C1.Win.C1Command.C1CommandLink();
            this.bTileHorizontal = new C1.Win.C1Command.C1CommandLink();
            this.bTileVertical = new C1.Win.C1Command.C1CommandLink();
            this.btnCautare = new C1.Win.C1Command.C1CommandLink();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblBnr = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).BeginInit();
            this.NavBar.SuspendLayout();
            this.C1NavBarPanel2.SuspendLayout();
            this.C1NavBarPanel17.SuspendLayout();
            this.C1NavBarPanel9.SuspendLayout();
            this.C1NavBarPanel4.SuspendLayout();
            this.C1NavBarPanel15.SuspendLayout();
            this.C1NavBarPanel11.SuspendLayout();
            this.C1NavBarPanel6.SuspendLayout();
            this.C1NavBarPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1CommandHolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.White;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFisier,
            this.mnuFereastra,
            this.MLMMenu,
            this.mnu12,
            this.TariJudeteToolStripMenuItem,
            this.mnuAjutor,
            this.HiddenToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // mnuFisier
            // 
            this.mnuFisier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogOut,
            this.mnuIesire});
            this.mnuFisier.Image = ((System.Drawing.Image)(resources.GetObject("mnuFisier.Image")));
            this.mnuFisier.Name = "mnuFisier";
            this.mnuFisier.Size = new System.Drawing.Size(62, 20);
            this.mnuFisier.Text = "Fisier";
            // 
            // mnuLogOut
            // 
            this.mnuLogOut.Image = ((System.Drawing.Image)(resources.GetObject("mnuLogOut.Image")));
            this.mnuLogOut.Name = "mnuLogOut";
            this.mnuLogOut.Size = new System.Drawing.Size(143, 22);
            this.mnuLogOut.Text = "Log Out";
            this.mnuLogOut.Click += new System.EventHandler(this.mnuLogOut_Click);
            // 
            // mnuIesire
            // 
            this.mnuIesire.Image = ((System.Drawing.Image)(resources.GetObject("mnuIesire.Image")));
            this.mnuIesire.Name = "mnuIesire";
            this.mnuIesire.ShortcutKeyDisplayString = "Alt+F4";
            this.mnuIesire.Size = new System.Drawing.Size(143, 22);
            this.mnuIesire.Text = "Iesire";
            this.mnuIesire.Click += new System.EventHandler(this.mnuIesire_Click);
            // 
            // mnuFereastra
            // 
            this.mnuFereastra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdaugaFirma,
            this.mnuListaFirme});
            this.mnuFereastra.Image = ((System.Drawing.Image)(resources.GetObject("mnuFereastra.Image")));
            this.mnuFereastra.Name = "mnuFereastra";
            this.mnuFereastra.Size = new System.Drawing.Size(95, 20);
            this.mnuFereastra.Text = "&Firme lucru";
            // 
            // mnuAdaugaFirma
            // 
            this.mnuAdaugaFirma.Image = global::SoftManager.Properties.Resources.afiseaza;
            this.mnuAdaugaFirma.Name = "mnuAdaugaFirma";
            this.mnuAdaugaFirma.Size = new System.Drawing.Size(247, 22);
            this.mnuAdaugaFirma.Text = "Adauga firma-mnuAdaugaFirma";
            this.mnuAdaugaFirma.Click += new System.EventHandler(this.JurnalOperatiiJToolStripMenuItem_Click);
            // 
            // mnuListaFirme
            // 
            this.mnuListaFirme.Image = ((System.Drawing.Image)(resources.GetObject("mnuListaFirme.Image")));
            this.mnuListaFirme.Name = "mnuListaFirme";
            this.mnuListaFirme.Size = new System.Drawing.Size(247, 22);
            this.mnuListaFirme.Text = "Lista firme-mnuListaFirme";
            this.mnuListaFirme.Click += new System.EventHandler(this.listaFirmeToolStripMenuItem_Click);
            // 
            // MLMMenu
            // 
            this.MLMMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegularizariMLMfrmRegularizariMLMToolStripMenuItem1,
            this.listaDocumenteIntrareToolStripMenuItem,
            this.genreazaNIRToolStripMenuItem});
            this.MLMMenu.Image = global::SoftManager.Properties.Resources.enumList;
            this.MLMMenu.Name = "MLMMenu";
            this.MLMMenu.Size = new System.Drawing.Size(134, 20);
            this.MLMMenu.Text = "Documente intrare";
            // 
            // RegularizariMLMfrmRegularizariMLMToolStripMenuItem1
            // 
            this.RegularizariMLMfrmRegularizariMLMToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem,
            this.avizToolStripMenuItem});
            this.RegularizariMLMfrmRegularizariMLMToolStripMenuItem1.Image = global::SoftManager.Properties.Resources.insertcellcopy;
            this.RegularizariMLMfrmRegularizariMLMToolStripMenuItem1.Name = "RegularizariMLMfrmRegularizariMLMToolStripMenuItem1";
            this.RegularizariMLMfrmRegularizariMLMToolStripMenuItem1.Size = new System.Drawing.Size(252, 22);
            this.RegularizariMLMfrmRegularizariMLMToolStripMenuItem1.Text = "Introducere Document";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // avizToolStripMenuItem
            // 
            this.avizToolStripMenuItem.Name = "avizToolStripMenuItem";
            this.avizToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.avizToolStripMenuItem.Text = "Aviz";
            // 
            // listaDocumenteIntrareToolStripMenuItem
            // 
            this.listaDocumenteIntrareToolStripMenuItem.Name = "listaDocumenteIntrareToolStripMenuItem";
            this.listaDocumenteIntrareToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.listaDocumenteIntrareToolStripMenuItem.Text = "Lista documente intrare introduse";
            this.listaDocumenteIntrareToolStripMenuItem.Click += new System.EventHandler(this.listaDocumenteIntrareToolStripMenuItem_Click);
            // 
            // genreazaNIRToolStripMenuItem
            // 
            this.genreazaNIRToolStripMenuItem.Name = "genreazaNIRToolStripMenuItem";
            this.genreazaNIRToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.genreazaNIRToolStripMenuItem.Text = "Genreaza NIR";
            this.genreazaNIRToolStripMenuItem.Click += new System.EventHandler(this.genreazaNIRToolStripMenuItem_Click);
            // 
            // mnu12
            // 
            this.mnu12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConturiSoftManager,
            this.mnu12p1,
            this.SetariProgramSetariProgramToolStripMenuItem,
            this.mnuModificareParola});
            this.mnu12.Image = ((System.Drawing.Image)(resources.GetObject("mnu12.Image")));
            this.mnu12.Name = "mnu12";
            this.mnu12.Size = new System.Drawing.Size(64, 20);
            this.mnu12.Text = "Setari";
            // 
            // mnuConturiSoftManager
            // 
            this.mnuConturiSoftManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdministrareConturiSoftManagerToolStripMenuItem,
            this.ModificareContExistentToolStripMenuItem,
            this.cautareContToolStripMenuItem});
            this.mnuConturiSoftManager.Image = ((System.Drawing.Image)(resources.GetObject("mnuConturiSoftManager.Image")));
            this.mnuConturiSoftManager.Name = "mnuConturiSoftManager";
            this.mnuConturiSoftManager.Size = new System.Drawing.Size(287, 22);
            this.mnuConturiSoftManager.Text = "Administrare-mnuConturiSoftManager";
            // 
            // AdministrareConturiSoftManagerToolStripMenuItem
            // 
            this.AdministrareConturiSoftManagerToolStripMenuItem.Name = "AdministrareConturiSoftManagerToolStripMenuItem";
            this.AdministrareConturiSoftManagerToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.AdministrareConturiSoftManagerToolStripMenuItem.Text = "Creare cont nou";
            this.AdministrareConturiSoftManagerToolStripMenuItem.Click += new System.EventHandler(this.AdministrareConturiSoftManagerToolStripMenuItem_Click);
            // 
            // ModificareContExistentToolStripMenuItem
            // 
            this.ModificareContExistentToolStripMenuItem.Name = "ModificareContExistentToolStripMenuItem";
            this.ModificareContExistentToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.ModificareContExistentToolStripMenuItem.Text = "Modificare/Stergere cont existent";
            this.ModificareContExistentToolStripMenuItem.Click += new System.EventHandler(this.ModificareContExistentToolStripMenuItem_Click);
            // 
            // cautareContToolStripMenuItem
            // 
            this.cautareContToolStripMenuItem.Name = "cautareContToolStripMenuItem";
            this.cautareContToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.cautareContToolStripMenuItem.Text = "Cautare cont";
            this.cautareContToolStripMenuItem.Click += new System.EventHandler(this.cautareContToolStripMenuItem_Click);
            // 
            // mnu12p1
            // 
            this.mnu12p1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreazaCopieSiguranta,
            this.ServerBazaDeDateToolStripMenuItem});
            this.mnu12p1.Image = global::SoftManager.Properties.Resources.database_add;
            this.mnu12p1.Name = "mnu12p1";
            this.mnu12p1.Size = new System.Drawing.Size(287, 22);
            this.mnu12p1.Text = "Baza de date-mnu12p1";
            // 
            // mnuCreazaCopieSiguranta
            // 
            this.mnuCreazaCopieSiguranta.Name = "mnuCreazaCopieSiguranta";
            this.mnuCreazaCopieSiguranta.Size = new System.Drawing.Size(411, 22);
            this.mnuCreazaCopieSiguranta.Text = "Creaza copie de siguranta (BACKUP)-mnuCreazaCopieSiguranta";
            this.mnuCreazaCopieSiguranta.Click += new System.EventHandler(this.mnuCreazaCopieSiguranta_Click);
            // 
            // ServerBazaDeDateToolStripMenuItem
            // 
            this.ServerBazaDeDateToolStripMenuItem.Name = "ServerBazaDeDateToolStripMenuItem";
            this.ServerBazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(411, 22);
            this.ServerBazaDeDateToolStripMenuItem.Text = "Server baza de date-12.1.2";
            // 
            // SetariProgramSetariProgramToolStripMenuItem
            // 
            this.SetariProgramSetariProgramToolStripMenuItem.Image = global::SoftManager.Properties.Resources.tool;
            this.SetariProgramSetariProgramToolStripMenuItem.Name = "SetariProgramSetariProgramToolStripMenuItem";
            this.SetariProgramSetariProgramToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.SetariProgramSetariProgramToolStripMenuItem.Text = "Setari Program-SetariProgram";
            // 
            // mnuModificareParola
            // 
            this.mnuModificareParola.Name = "mnuModificareParola";
            this.mnuModificareParola.Size = new System.Drawing.Size(287, 22);
            this.mnuModificareParola.Text = "Modificare Parola-mnuModificareParola";
            this.mnuModificareParola.Click += new System.EventHandler(this.ModificareParolaToolStripMenuItem1_Click);
            // 
            // TariJudeteToolStripMenuItem
            // 
            this.TariJudeteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportToolStripMenuItem1,
            this.preluareBNRToolStripMenuItem});
            this.TariJudeteToolStripMenuItem.Image = global::SoftManager.Properties.Resources.tool;
            this.TariJudeteToolStripMenuItem.Name = "TariJudeteToolStripMenuItem";
            this.TariJudeteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.TariJudeteToolStripMenuItem.Text = "&Altele";
            // 
            // ImportToolStripMenuItem1
            // 
            this.ImportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportIncasariDinExcelToolStripMenuItem,
            this.ImportProduse});
            this.ImportToolStripMenuItem1.Name = "ImportToolStripMenuItem1";
            this.ImportToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.ImportToolStripMenuItem1.Text = "Import";
            // 
            // ImportIncasariDinExcelToolStripMenuItem
            // 
            this.ImportIncasariDinExcelToolStripMenuItem.Name = "ImportIncasariDinExcelToolStripMenuItem";
            this.ImportIncasariDinExcelToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
            this.ImportIncasariDinExcelToolStripMenuItem.Text = "Import incasari din Excel-frmImportIncasariDinExcel";
            // 
            // ImportProduse
            // 
            this.ImportProduse.Name = "ImportProduse";
            this.ImportProduse.Size = new System.Drawing.Size(346, 22);
            this.ImportProduse.Text = "Import produse";
            this.ImportProduse.Click += new System.EventHandler(this.ImportProduse_Click);
            // 
            // preluareBNRToolStripMenuItem
            // 
            this.preluareBNRToolStripMenuItem.Name = "preluareBNRToolStripMenuItem";
            this.preluareBNRToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.preluareBNRToolStripMenuItem.Text = "PreluareBNR";
            this.preluareBNRToolStripMenuItem.Click += new System.EventHandler(this.preluareBNRToolStripMenuItem_Click);
            // 
            // mnuAjutor
            // 
            this.mnuAjutor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManual,
            this.ToolStripMenuItem2,
            this.mnuDespre});
            this.mnuAjutor.Image = global::SoftManager.Properties.Resources.info;
            this.mnuAjutor.Name = "mnuAjutor";
            this.mnuAjutor.Size = new System.Drawing.Size(131, 20);
            this.mnuAjutor.Text = "&Ajutor-mnuAjutor";
            // 
            // mnuManual
            // 
            this.mnuManual.Image = ((System.Drawing.Image)(resources.GetObject("mnuManual.Image")));
            this.mnuManual.Name = "mnuManual";
            this.mnuManual.Size = new System.Drawing.Size(181, 22);
            this.mnuManual.Text = "Manual";
            this.mnuManual.Click += new System.EventHandler(this.mnuManual_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // mnuDespre
            // 
            this.mnuDespre.Image = global::SoftManager.Properties.Resources.SoftManager;
            this.mnuDespre.Name = "mnuDespre";
            this.mnuDespre.Size = new System.Drawing.Size(181, 22);
            this.mnuDespre.Text = "Despre SoftManager";
            this.mnuDespre.Click += new System.EventHandler(this.mnuDespre_Click);
            // 
            // HiddenToolStripMenuItem
            // 
            this.HiddenToolStripMenuItem.Image = global::SoftManager.Properties.Resources.jabber_protocol;
            this.HiddenToolStripMenuItem.Name = "HiddenToolStripMenuItem";
            this.HiddenToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.HiddenToolStripMenuItem.Text = "SUPORT ONLINE";
            this.HiddenToolStripMenuItem.Click += new System.EventHandler(this.HiddenToolStripMenuItem_Click);
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.White;
            c1NavBarButton1.ID = 17;
            c1NavBarButton1.Image = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton1.Image")));
            c1NavBarButton1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            c1NavBarButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton1.SmallImage")));
            c1NavBarButton1.Text = "Intrari";
            c1NavBarButton2.ID = 9;
            c1NavBarButton2.Image = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton2.Image")));
            c1NavBarButton2.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            c1NavBarButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton2.SmallImage")));
            c1NavBarButton2.Text = "Iesiri";
            c1NavBarButton3.ID = 11;
            c1NavBarButton3.Image = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton3.Image")));
            c1NavBarButton3.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            c1NavBarButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton3.SmallImage")));
            c1NavBarButton3.Text = "Stoc";
            c1NavBarButton4.ID = 4;
            c1NavBarButton4.Image = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton4.Image")));
            c1NavBarButton4.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            c1NavBarButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton4.SmallImage")));
            c1NavBarButton4.Text = "Situatii";
            c1NavBarButton5.ID = 5;
            c1NavBarButton5.Image = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton5.Image")));
            c1NavBarButton5.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            c1NavBarButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton5.SmallImage")));
            c1NavBarButton5.Text = "Chitante";
            c1NavBarButton5.Visible = false;
            c1NavBarButton6.ID = 6;
            c1NavBarButton6.Image = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton6.Image")));
            c1NavBarButton6.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            c1NavBarButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton6.SmallImage")));
            c1NavBarButton6.Text = "Clienti";
            c1NavBarButton6.Visible = false;
            c1NavBarButton7.ID = 15;
            c1NavBarButton7.Image = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton7.Image")));
            c1NavBarButton7.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            c1NavBarButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton7.SmallImage")));
            c1NavBarButton7.Text = "Facturi";
            c1NavBarButton7.Visible = false;
            c1NavBarButton8.ID = 2;
            c1NavBarButton8.Image = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton8.Image")));
            c1NavBarButton8.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            c1NavBarButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton8.SmallImage")));
            c1NavBarButton8.Text = "Rapoarte";
            this.NavBar.Buttons.AddRange(new C1.Win.C1Command.C1NavBarButton[] {
            c1NavBarButton1,
            c1NavBarButton2,
            c1NavBarButton3,
            c1NavBarButton4,
            c1NavBarButton5,
            c1NavBarButton6,
            c1NavBarButton7,
            c1NavBarButton8});
            this.NavBar.Controls.Add(this.C1NavBarPanel4);
            this.NavBar.Controls.Add(this.C1NavBarPanel2);
            this.NavBar.Controls.Add(this.C1NavBarPanel17);
            this.NavBar.Controls.Add(this.C1NavBarPanel9);
            this.NavBar.Controls.Add(this.C1NavBarPanel11);
            this.NavBar.Controls.Add(this.C1NavBarPanel15);
            this.NavBar.Controls.Add(this.C1NavBarPanel6);
            this.NavBar.Controls.Add(this.C1NavBarPanel5);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBar.ForeColor = System.Drawing.Color.Black;
            this.NavBar.Location = new System.Drawing.Point(0, 24);
            this.NavBar.Name = "NavBar";
            this.NavBar.PanelHeaderFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.NavBar.PanelHeaderHeight = 27;
            this.NavBar.Panels.AddRange(new C1.Win.C1Command.C1NavBarPanel[] {
            this.C1NavBarPanel2,
            this.C1NavBarPanel4,
            this.C1NavBarPanel5,
            this.C1NavBarPanel6,
            this.C1NavBarPanel9,
            this.C1NavBarPanel11,
            this.C1NavBarPanel15,
            this.C1NavBarPanel17});
            this.NavBar.Size = new System.Drawing.Size(281, 585);
            this.NavBar.StackButtonCount = 14;
            // 
            // C1NavBarPanel2
            // 
            this.C1NavBarPanel2.Controls.Add(this.treeRapoarte);
            this.C1NavBarPanel2.ID = 2;
            this.C1NavBarPanel2.Name = "C1NavBarPanel2";
            this.C1NavBarPanel2.Size = new System.Drawing.Size(279, 359);
            // 
            // treeRapoarte
            // 
            this.treeRapoarte.BackColor = System.Drawing.Color.White;
            this.treeRapoarte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeRapoarte.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeRapoarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeRapoarte.ForeColor = System.Drawing.Color.Black;
            this.treeRapoarte.LineColor = System.Drawing.Color.Maroon;
            this.treeRapoarte.Location = new System.Drawing.Point(0, 0);
            this.treeRapoarte.Name = "treeRapoarte";
            treeNode5.Name = "2.2";
            treeNode5.Text = "Clienti";
            treeNode6.Name = "Export";
            treeNode6.Text = "Export";
            treeNode7.Name = "frmGrafic";
            treeNode7.Text = "Gestiune";
            treeNode8.Name = "2.4";
            treeNode8.Text = "Produse";
            treeNode9.Name = "2.5.0";
            treeNode9.Text = "Stoc chitante";
            treeNode10.Name = "2.5.2";
            treeNode10.Text = "Stoc produse";
            treeNode11.Name = "2.5.4";
            treeNode11.Text = "Stocuri detaliate";
            treeNode12.Name = "2.5";
            treeNode12.Text = "Stocuri";
            this.treeRapoarte.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode12});
            this.treeRapoarte.RightToLeftLayout = true;
            this.treeRapoarte.Size = new System.Drawing.Size(279, 359);
            this.treeRapoarte.TabIndex = 3;
            this.treeRapoarte.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeRapoarte_NodeMouseDoubleClick);
            // 
            // C1NavBarPanel17
            // 
            this.C1NavBarPanel17.Controls.Add(this.treeIntrari);
            this.C1NavBarPanel17.ID = 17;
            this.C1NavBarPanel17.Name = "C1NavBarPanel17";
            this.C1NavBarPanel17.Size = new System.Drawing.Size(279, 359);
            // 
            // treeIntrari
            // 
            this.treeIntrari.BackColor = System.Drawing.Color.White;
            this.treeIntrari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeIntrari.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeIntrari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeIntrari.ForeColor = System.Drawing.Color.Black;
            this.treeIntrari.Location = new System.Drawing.Point(0, 0);
            this.treeIntrari.Name = "treeIntrari";
            treeNode13.Name = "frmIntroducereDocumentNou";
            treeNode13.Text = "Introducere document nou";
            treeNode14.Name = "frmListaDocumenteExistente";
            treeNode14.Text = "Lista documente existente";
            treeNode15.Name = "frmGenerareNIR";
            treeNode15.Text = "Generare NIR";
            treeNode16.Name = "frmListaNIR";
            treeNode16.Text = "Lista NIR existente";
            this.treeIntrari.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.treeIntrari.Size = new System.Drawing.Size(279, 359);
            this.treeIntrari.TabIndex = 5;
            this.treeIntrari.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treesoftmanager_NodeMouseDoubleClick);
            // 
            // C1NavBarPanel9
            // 
            this.C1NavBarPanel9.Controls.Add(this.treeIesiri);
            this.C1NavBarPanel9.ID = 9;
            this.C1NavBarPanel9.Name = "C1NavBarPanel9";
            this.C1NavBarPanel9.Size = new System.Drawing.Size(279, 359);
            // 
            // treeIesiri
            // 
            this.treeIesiri.BackColor = System.Drawing.Color.White;
            this.treeIesiri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeIesiri.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeIesiri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeIesiri.ForeColor = System.Drawing.Color.Black;
            this.treeIesiri.Location = new System.Drawing.Point(0, 0);
            this.treeIesiri.Name = "treeIesiri";
            treeNode17.ForeColor = System.Drawing.Color.Black;
            treeNode17.Name = "8.0";
            treeNode17.Text = "Facturi/Proforme/Avize";
            treeNode18.Name = "8.1.0";
            treeNode18.Text = "Bon de transfer";
            treeNode19.Name = "8.2.0";
            treeNode19.Text = "Bon de consum";
            this.treeIesiri.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            this.treeIesiri.Size = new System.Drawing.Size(279, 359);
            this.treeIesiri.TabIndex = 4;
            this.treeIesiri.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeIesiri_NodeMouseDoubleClick);
            // 
            // C1NavBarPanel4
            // 
            this.C1NavBarPanel4.Controls.Add(this.treeSituatii);
            this.C1NavBarPanel4.ID = 4;
            this.C1NavBarPanel4.Name = "C1NavBarPanel4";
            this.C1NavBarPanel4.Size = new System.Drawing.Size(279, 359);
            // 
            // treeSituatii
            // 
            this.treeSituatii.BackColor = System.Drawing.Color.White;
            this.treeSituatii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeSituatii.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeSituatii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSituatii.ForeColor = System.Drawing.Color.Black;
            this.treeSituatii.Location = new System.Drawing.Point(0, 0);
            this.treeSituatii.Name = "treeSituatii";
            treeNode1.Name = "b1";
            treeNode1.Text = "Raport de gestiune";
            treeNode2.Name = "bAdauga";
            treeNode2.Text = "Situatie inventar";
            treeNode3.Name = "b3";
            treeNode3.Text = "Evolutia valorica a stocului";
            treeNode4.Name = "b4";
            treeNode4.Text = "Evolutia cantitativa a produselor";
            this.treeSituatii.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeSituatii.Size = new System.Drawing.Size(279, 359);
            this.treeSituatii.TabIndex = 4;
            this.treeSituatii.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSituatii_NodeMouseDoubleClick);
            // 
            // C1NavBarPanel15
            // 
            this.C1NavBarPanel15.Controls.Add(this.treeFacturi);
            this.C1NavBarPanel15.ID = 15;
            this.C1NavBarPanel15.Name = "C1NavBarPanel15";
            this.C1NavBarPanel15.Size = new System.Drawing.Size(279, 359);
            // 
            // treeFacturi
            // 
            this.treeFacturi.BackColor = System.Drawing.Color.White;
            this.treeFacturi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeFacturi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeFacturi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeFacturi.ForeColor = System.Drawing.Color.Black;
            this.treeFacturi.Location = new System.Drawing.Point(0, 0);
            this.treeFacturi.Name = "treeFacturi";
            treeNode23.Name = "IncaseazaFactura";
            treeNode23.Text = "Incaseaza factura";
            treeNode24.Name = "CautareDocumente";
            treeNode24.Text = "Cautare documente";
            treeNode25.Name = "FacturiScadenteSauNeincasate";
            treeNode25.Text = "Facturi scadente sau neincasate";
            treeNode26.Name = "FacturiIncasate";
            treeNode26.Text = "Facturi incasate";
            treeNode27.Name = "FacturiAnulate";
            treeNode27.Text = "Facturi anulate";
            treeNode28.Name = "Rapoarte";
            treeNode28.Text = "Rapoarte";
            this.treeFacturi.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode28});
            this.treeFacturi.Size = new System.Drawing.Size(279, 359);
            this.treeFacturi.TabIndex = 6;
            // 
            // C1NavBarPanel11
            // 
            this.C1NavBarPanel11.Controls.Add(this.treeStoc);
            this.C1NavBarPanel11.ID = 11;
            this.C1NavBarPanel11.Name = "C1NavBarPanel11";
            this.C1NavBarPanel11.Size = new System.Drawing.Size(279, 359);
            // 
            // treeStoc
            // 
            this.treeStoc.BackColor = System.Drawing.Color.White;
            this.treeStoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeStoc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeStoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeStoc.ForeColor = System.Drawing.Color.Black;
            this.treeStoc.Location = new System.Drawing.Point(0, 0);
            this.treeStoc.Name = "treeStoc";
            treeNode20.Name = "10.0";
            treeNode20.Text = "Vizualizare stoc";
            treeNode21.Name = "10.1";
            treeNode21.Text = "Nomenclator produse";
            treeNode22.Name = "";
            treeNode22.Text = "Avertizari stoc";
            this.treeStoc.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            this.treeStoc.Size = new System.Drawing.Size(279, 359);
            this.treeStoc.TabIndex = 4;
            this.treeStoc.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSoftManager_NodeMouseDoubleClick);
            // 
            // C1NavBarPanel6
            // 
            this.C1NavBarPanel6.Controls.Add(this.treeClienti);
            this.C1NavBarPanel6.ID = 6;
            this.C1NavBarPanel6.Name = "C1NavBarPanel6";
            this.C1NavBarPanel6.Size = new System.Drawing.Size(279, 359);
            // 
            // treeClienti
            // 
            this.treeClienti.BackColor = System.Drawing.Color.White;
            this.treeClienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeClienti.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeClienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeClienti.ForeColor = System.Drawing.Color.Black;
            this.treeClienti.Location = new System.Drawing.Point(0, 0);
            this.treeClienti.Name = "treeClienti";
            treeNode29.Name = "5.0";
            treeNode29.Text = "Adauga client";
            treeNode30.Name = "5.1.0";
            treeNode30.Text = "Modificare/Stergere client";
            treeNode31.Name = "5.2.0";
            treeNode31.Text = "Lista clienti";
            treeNode32.Name = "frmTrimiteSMSClient";
            treeNode32.Text = "Trmite SMS Clientului";
            treeNode33.Name = "frmNewsletterClienti";
            treeNode33.Text = "Newsletter Clienti";
            this.treeClienti.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33});
            this.treeClienti.Size = new System.Drawing.Size(279, 359);
            this.treeClienti.TabIndex = 3;
            // 
            // C1NavBarPanel5
            // 
            this.C1NavBarPanel5.Controls.Add(this.treeChitante);
            this.C1NavBarPanel5.ID = 5;
            this.C1NavBarPanel5.Name = "C1NavBarPanel5";
            this.C1NavBarPanel5.Size = new System.Drawing.Size(279, 359);
            // 
            // treeChitante
            // 
            this.treeChitante.BackColor = System.Drawing.Color.White;
            this.treeChitante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeChitante.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeChitante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeChitante.Location = new System.Drawing.Point(0, 0);
            this.treeChitante.Name = "treeChitante";
            treeNode34.Name = "4.1";
            treeNode34.Text = "Emite chitanţă";
            treeNode35.Name = "4.2";
            treeNode35.Text = "Predare chitanţe";
            this.treeChitante.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35});
            this.treeChitante.Size = new System.Drawing.Size(279, 359);
            this.treeChitante.TabIndex = 2;
            // 
            // C1CommandHolder1
            // 
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnCascade);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileVertical);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnTileHorizontal);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnShowHide);
            this.C1CommandHolder1.Commands.Add(this.btnEmitereRapida);
            this.C1CommandHolder1.Commands.Add(this.btnEmitereRapida);
            this.C1CommandHolder1.Commands.Add(this.btnEmitereRapida);
            this.C1CommandHolder1.Commands.Add(this.C1CommandControl1);
            this.C1CommandHolder1.Commands.Add(this.C1Command1);
            this.C1CommandHolder1.Commands.Add(this.bCautare);
            this.C1CommandHolder1.Owner = this;
            // 
            // btnCascade
            // 
            this.btnCascade.Icon = ((System.Drawing.Icon)(resources.GetObject("btnCascade.Icon")));
            this.btnCascade.Name = "btnCascade";
            this.btnCascade.Text = "Cascade";
            this.btnCascade.Click += new C1.Win.C1Command.ClickEventHandler(this.btnCascade_Click);
            // 
            // btnTileVertical
            // 
            this.btnTileVertical.Icon = ((System.Drawing.Icon)(resources.GetObject("btnTileVertical.Icon")));
            this.btnTileVertical.Name = "btnTileVertical";
            this.btnTileVertical.Text = "Tile Vertical";
            this.btnTileVertical.ToolTipText = "Tile Vertical";
            this.btnTileVertical.Click += new C1.Win.C1Command.ClickEventHandler(this.btnTileVertical_Click);
            // 
            // btnTileHorizontal
            // 
            this.btnTileHorizontal.Icon = ((System.Drawing.Icon)(resources.GetObject("btnTileHorizontal.Icon")));
            this.btnTileHorizontal.Name = "btnTileHorizontal";
            this.btnTileHorizontal.Text = "TileHorizontal";
            this.btnTileHorizontal.Click += new C1.Win.C1Command.ClickEventHandler(this.btnTileHorizontal_Click);
            // 
            // btnShowHide
            // 
            this.btnShowHide.Icon = ((System.Drawing.Icon)(resources.GetObject("btnShowHide.Icon")));
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Text = "ShowHide";
            this.btnShowHide.Click += new C1.Win.C1Command.ClickEventHandler(this.btnShowHide_Click);
            // 
            // btnEmitereRapida
            // 
            this.btnEmitereRapida.Icon = ((System.Drawing.Icon)(resources.GetObject("btnEmitereRapida.Icon")));
            this.btnEmitereRapida.Name = "btnEmitereRapida";
            this.btnEmitereRapida.Text = "Emitere Rapida";
            // 
            // C1CommandControl1
            // 
            this.C1CommandControl1.Name = "C1CommandControl1";
            this.C1CommandControl1.Text = "New Command";
            // 
            // C1Command1
            // 
            this.C1Command1.Name = "C1Command1";
            this.C1Command1.Text = "New Command";
            // 
            // bCautare
            // 
            this.bCautare.Icon = ((System.Drawing.Icon)(resources.GetObject("bCautare.Icon")));
            this.bCautare.Name = "bCautare";
            this.bCautare.Text = "Cautare";
            this.bCautare.Click += new C1.Win.C1Command.ClickEventHandler(this.bCautare_Click);
            // 
            // Panel1
            // 
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(80, 40);
            this.Panel1.TabIndex = 7;
            // 
            // C1ToolBar1
            // 
            this.C1ToolBar1.AccessibleName = "Tool Bar";
            this.C1ToolBar1.BackColor = System.Drawing.Color.SlateGray;
            this.C1ToolBar1.BackHiColor = System.Drawing.Color.LightSteelBlue;
            this.C1ToolBar1.ButtonAlign = System.Drawing.StringAlignment.Near;
            this.C1ToolBar1.CommandHolder = this.C1CommandHolder1;
            this.C1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.bShowHide,
            this.bCascade,
            this.bTileHorizontal,
            this.bTileVertical,
            this.btnCautare});
            this.C1ToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.C1ToolBar1.ForeColor = System.Drawing.Color.White;
            this.C1ToolBar1.ForeHiColor = System.Drawing.Color.Black;
            this.C1ToolBar1.Location = new System.Drawing.Point(281, 24);
            this.C1ToolBar1.Movable = false;
            this.C1ToolBar1.Name = "C1ToolBar1";
            this.C1ToolBar1.Size = new System.Drawing.Size(747, 24);
            this.C1ToolBar1.Text = "C1ToolBar1";
            // 
            // bShowHide
            // 
            this.bShowHide.Command = this.btnShowHide;
            this.bShowHide.Text = "Arata / Ascunde";
            this.bShowHide.ToolTipText = "Arata / Ascunde";
            // 
            // bCascade
            // 
            this.bCascade.Command = this.btnCascade;
            this.bCascade.Delimiter = true;
            this.bCascade.SortOrder = 1;
            // 
            // bTileHorizontal
            // 
            this.bTileHorizontal.Command = this.btnTileHorizontal;
            this.bTileHorizontal.SortOrder = 2;
            // 
            // bTileVertical
            // 
            this.bTileVertical.Command = this.btnTileVertical;
            this.bTileVertical.SortOrder = 3;
            // 
            // btnCautare
            // 
            this.btnCautare.ButtonLook = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.btnCautare.Command = this.bCautare;
            this.btnCautare.Delimiter = true;
            this.btnCautare.SortOrder = 4;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.DarkGray;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(951, 55);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 4;
            // 
            // lblBnr
            // 
            this.lblBnr.AutoSize = true;
            this.lblBnr.Location = new System.Drawing.Point(414, 55);
            this.lblBnr.Name = "lblBnr";
            this.lblBnr.Size = new System.Drawing.Size(0, 13);
            this.lblBnr.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.lblBnr);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.C1ToolBar1);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "frmMain";
            this.Text = "SoftManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).EndInit();
            this.NavBar.ResumeLayout(false);
            this.C1NavBarPanel2.ResumeLayout(false);
            this.C1NavBarPanel17.ResumeLayout(false);
            this.C1NavBarPanel9.ResumeLayout(false);
            this.C1NavBarPanel4.ResumeLayout(false);
            this.C1NavBarPanel15.ResumeLayout(false);
            this.C1NavBarPanel11.ResumeLayout(false);
            this.C1NavBarPanel6.ResumeLayout(false);
            this.C1NavBarPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.C1CommandHolder1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.MenuStrip MenuStrip1; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1NavBar NavBar; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1NavBarPanel C1NavBarPanel2; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1NavBarPanel C1NavBarPanel4; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1NavBarPanel C1NavBarPanel5; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1NavBarPanel C1NavBarPanel6; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1CommandHolder C1CommandHolder1; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1NavBarPanel C1NavBarPanel9; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1NavBarPanel C1NavBarPanel11; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal System.Windows.Forms.TreeView treeSituatii; /* TODO ERROR didn't convert: WithEvents */
        internal System.Windows.Forms.TreeView treeChitante; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal System.Windows.Forms.TreeView treeClienti; /* TODO ERROR didn't convert: WithEvents */
        internal System.Windows.Forms.TreeView treeRapoarte; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal System.Windows.Forms.TreeView treeStoc; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal System.Windows.Forms.TreeView treeIesiri; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1NavBarPanel C1NavBarPanel15; /* TODO ERROR didn't convert: WithEvents */
        internal System.Windows.Forms.TreeView treeFacturi; /* TODO ERROR didn't convert: WithEvents */
        internal System.Windows.Forms.Panel Panel1; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1NavBarPanel C1NavBarPanel17; /* TODO ERROR didn't convert: WithEvents */
        internal System.Windows.Forms.TreeView treeIntrari; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1Command btnCascade; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1Command btnTileVertical; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1Command btnTileHorizontal; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1Command btnShowHide; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1ToolBar C1ToolBar1; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1CommandLink bShowHide; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1CommandLink bCascade; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1CommandLink bTileHorizontal; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1CommandLink bTileVertical; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        private System.Windows.Forms.ToolStripMenuItem HiddenToolStripMenuItem; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1Command btnEmitereRapida; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1CommandControl C1CommandControl1; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1Command C1Command1; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1Command bCautare; /* TODO ERROR didn't convert: WithEvents */
        internal C1.Win.C1Command.C1CommandLink btnCautare;
        private System.Windows.Forms.ToolStripMenuItem TariJudeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAdaugaFirma;
        private System.Windows.Forms.ToolStripMenuItem mnuFereastra;
        private System.Windows.Forms.ToolStripMenuItem mnuFisier;
        private System.Windows.Forms.ToolStripMenuItem mnuIesire;
        private System.Windows.Forms.ToolStripMenuItem mnuAjutor;
        private System.Windows.Forms.ToolStripMenuItem mnuManual;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuDespre;
        private System.Windows.Forms.ToolStripMenuItem mnuCreazaCopieSiguranta;
        private System.Windows.Forms.ToolStripMenuItem ServerBazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOut;
        private System.Windows.Forms.ToolStripMenuItem mnuConturiSoftManager;
        private System.Windows.Forms.ToolStripMenuItem AdministrareConturiSoftManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModificareContExistentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetariProgramSetariProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MLMMenu;
        private System.Windows.Forms.ToolStripMenuItem RegularizariMLMfrmRegularizariMLMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuModificareParola;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ImportIncasariDinExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportProduse;
        private System.Windows.Forms.ToolStripMenuItem mnu12;
        private System.Windows.Forms.ToolStripMenuItem mnu12p1;
        private System.Windows.Forms.ToolStripMenuItem mnuListaFirme;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avizToolStripMenuItem;
        public System.Windows.Forms.Label lblInfo;
        public System.Windows.Forms.Label lblBnr;
        private System.Windows.Forms.ToolStripMenuItem preluareBNRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDocumenteIntrareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreazaNIRToolStripMenuItem; /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */ /* TODO ERROR didn't convert: WithEvents */
    }
}