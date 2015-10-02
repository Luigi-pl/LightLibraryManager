namespace LightLibraryManager.View
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox mlcGroupBox;
        private System.Windows.Forms.GroupBox mlrGroupBox;
        private System.Windows.Forms.GroupBox mbbGroupBox;
        private System.Windows.Forms.GroupBox sGroupBox;

        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Button removeBook;
        private System.Windows.Forms.Button booksList;
        private System.Windows.Forms.Button addMagazine;
        private System.Windows.Forms.Button magazinesList;
        private System.Windows.Forms.Button removeMagazine;

        private System.Windows.Forms.Button addReader;
        private System.Windows.Forms.Button readersList;
        private System.Windows.Forms.Button removeReader;

        private System.Windows.Forms.Button borrowItem;
        private System.Windows.Forms.Button borrowedMagazinesList;
        private System.Windows.Forms.Button borrowedBooksList;
        private System.Windows.Forms.Button returnItem;
        private System.Windows.Forms.PictureBox magazinesOverdueAlarm;
        private System.Windows.Forms.PictureBox booksOverdueAlarm;
        
        private System.Windows.Forms.Button settingsCodeReader;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mlcGroupBox = new System.Windows.Forms.GroupBox();
            this.mlrGroupBox = new System.Windows.Forms.GroupBox();
            this.mbbGroupBox = new System.Windows.Forms.GroupBox();
            this.addBook = new System.Windows.Forms.Button();
            this.booksList = new System.Windows.Forms.Button();
            this.removeBook = new System.Windows.Forms.Button();
            this.removeMagazine = new System.Windows.Forms.Button();
            this.magazinesList = new System.Windows.Forms.Button();
            this.addMagazine = new System.Windows.Forms.Button();
            this.sGroupBox = new System.Windows.Forms.GroupBox();
            this.addReader = new System.Windows.Forms.Button();
            this.readersList = new System.Windows.Forms.Button();
            this.removeReader = new System.Windows.Forms.Button();
            this.borrowItem = new System.Windows.Forms.Button();
            this.returnItem = new System.Windows.Forms.Button();
            this.booksOverdueAlarm = new System.Windows.Forms.PictureBox();
            this.magazinesOverdueAlarm = new System.Windows.Forms.PictureBox();
            this.borrowedBooksList = new System.Windows.Forms.Button();
            this.borrowedMagazinesList = new System.Windows.Forms.Button();
            this.settingsCodeReader = new System.Windows.Forms.Button();
            this.mlcGroupBox.SuspendLayout();
            this.mlrGroupBox.SuspendLayout();
            this.mbbGroupBox.SuspendLayout();
            this.sGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksOverdueAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinesOverdueAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // mlcGroupBox
            // 
            resources.ApplyResources(this.mlcGroupBox, "mlcGroupBox");
            this.mlcGroupBox.Controls.Add(this.addMagazine);
            this.mlcGroupBox.Controls.Add(this.magazinesList);
            this.mlcGroupBox.Controls.Add(this.removeMagazine);
            this.mlcGroupBox.Controls.Add(this.removeBook);
            this.mlcGroupBox.Controls.Add(this.booksList);
            this.mlcGroupBox.Controls.Add(this.addBook);
            this.mlcGroupBox.Name = "mlcGroupBox";
            this.mlcGroupBox.TabStop = false;
            // 
            // mlrGroupBox
            // 
            resources.ApplyResources(this.mlrGroupBox, "mlrGroupBox");
            this.mlrGroupBox.Controls.Add(this.removeReader);
            this.mlrGroupBox.Controls.Add(this.readersList);
            this.mlrGroupBox.Controls.Add(this.addReader);
            this.mlrGroupBox.Name = "mlrGroupBox";
            this.mlrGroupBox.TabStop = false;
            // 
            // mbbGroupBox
            // 
            resources.ApplyResources(this.mbbGroupBox, "mbbGroupBox");
            this.mbbGroupBox.Controls.Add(this.borrowedMagazinesList);
            this.mbbGroupBox.Controls.Add(this.borrowedBooksList);
            this.mbbGroupBox.Controls.Add(this.magazinesOverdueAlarm);
            this.mbbGroupBox.Controls.Add(this.booksOverdueAlarm);
            this.mbbGroupBox.Controls.Add(this.returnItem);
            this.mbbGroupBox.Controls.Add(this.borrowItem);
            this.mbbGroupBox.Name = "mbbGroupBox";
            this.mbbGroupBox.TabStop = false;
            // 
            // addBook
            // 
            resources.ApplyResources(this.addBook, "addBook");
            this.addBook.Name = "addBook";
            this.addBook.UseVisualStyleBackColor = true;
            // 
            // booksList
            // 
            resources.ApplyResources(this.booksList, "booksList");
            this.booksList.Name = "booksList";
            this.booksList.UseVisualStyleBackColor = true;
            // 
            // removeBook
            // 
            resources.ApplyResources(this.removeBook, "removeBook");
            this.removeBook.Name = "removeBook";
            this.removeBook.UseVisualStyleBackColor = true;
            // 
            // removeMagazine
            // 
            resources.ApplyResources(this.removeMagazine, "removeMagazine");
            this.removeMagazine.Name = "removeMagazine";
            this.removeMagazine.UseVisualStyleBackColor = true;
            // 
            // magazinesList
            // 
            resources.ApplyResources(this.magazinesList, "magazinesList");
            this.magazinesList.Name = "magazinesList";
            this.magazinesList.UseVisualStyleBackColor = true;
            // 
            // addMagazine
            // 
            resources.ApplyResources(this.addMagazine, "addMagazine");
            this.addMagazine.Name = "addMagazine";
            this.addMagazine.UseVisualStyleBackColor = true;
            // 
            // sGroupBox
            // 
            resources.ApplyResources(this.sGroupBox, "sGroupBox");
            this.sGroupBox.Controls.Add(this.settingsCodeReader);
            this.sGroupBox.Name = "sGroupBox";
            this.sGroupBox.TabStop = false;
            // 
            // addReader
            // 
            resources.ApplyResources(this.addReader, "addReader");
            this.addReader.Name = "addReader";
            this.addReader.UseVisualStyleBackColor = true;
            // 
            // readersList
            // 
            resources.ApplyResources(this.readersList, "readersList");
            this.readersList.Name = "readersList";
            this.readersList.UseVisualStyleBackColor = true;
            // 
            // removeReader
            // 
            resources.ApplyResources(this.removeReader, "removeReader");
            this.removeReader.Name = "removeReader";
            this.removeReader.UseVisualStyleBackColor = true;
            // 
            // borrowItem
            // 
            resources.ApplyResources(this.borrowItem, "borrowItem");
            this.borrowItem.Name = "borrowItem";
            this.borrowItem.UseVisualStyleBackColor = true;
            // 
            // returnItem
            // 
            resources.ApplyResources(this.returnItem, "returnItem");
            this.returnItem.Name = "returnItem";
            this.returnItem.UseVisualStyleBackColor = true;
            // 
            // booksOverdueAlarm
            // 
            resources.ApplyResources(this.booksOverdueAlarm, "booksOverdueAlarm");
            this.booksOverdueAlarm.Name = "booksOverdueAlarm";
            this.booksOverdueAlarm.TabStop = false;
            // 
            // magazinesOverdueAlarm
            // 
            resources.ApplyResources(this.magazinesOverdueAlarm, "magazinesOverdueAlarm");
            this.magazinesOverdueAlarm.Name = "magazinesOverdueAlarm";
            this.magazinesOverdueAlarm.TabStop = false;
            // 
            // borrowedBooksList
            // 
            resources.ApplyResources(this.borrowedBooksList, "borrowedBooksList");
            this.borrowedBooksList.Name = "borrowedBooksList";
            this.borrowedBooksList.UseVisualStyleBackColor = true;
            // 
            // borrowedMagazinesList
            // 
            resources.ApplyResources(this.borrowedMagazinesList, "borrowedMagazinesList");
            this.borrowedMagazinesList.Name = "borrowedMagazinesList";
            this.borrowedMagazinesList.UseVisualStyleBackColor = true;
            // 
            // settingsCodeReader
            // 
            resources.ApplyResources(this.settingsCodeReader, "settingsCodeReader");
            this.settingsCodeReader.Name = "settingsCodeReader";
            this.settingsCodeReader.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sGroupBox);
            this.Controls.Add(this.mbbGroupBox);
            this.Controls.Add(this.mlrGroupBox);
            this.Controls.Add(this.mlcGroupBox);
            this.Name = "MainWindow";
            this.TopMost = true;
            this.mlcGroupBox.ResumeLayout(false);
            this.mlcGroupBox.PerformLayout();
            this.mlrGroupBox.ResumeLayout(false);
            this.mbbGroupBox.ResumeLayout(false);
            this.sGroupBox.ResumeLayout(false);
            this.sGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksOverdueAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinesOverdueAlarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}