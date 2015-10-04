namespace LightLibraryManager.View
{
    partial class LoadingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.loadingCheckList = new System.Windows.Forms.TableLayoutPanel();
            this.loadingChechListItemTextLabel1 = new System.Windows.Forms.Label();
            this.loadingChechListItemTextLabel3 = new System.Windows.Forms.Label();
            this.loadingChechListItemTextLabel2 = new System.Windows.Forms.Label();
            this.loadingChechListItemPictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingChechListItemPictureBox2 = new System.Windows.Forms.PictureBox();
            this.loadingChechListItemPictureBox3 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.loadingCheckList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingChechListItemPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingChechListItemPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingChechListItemPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // loadingCheckList
            // 
            resources.ApplyResources(this.loadingCheckList, "loadingCheckList");
            this.loadingCheckList.Controls.Add(this.loadingChechListItemTextLabel1, 0, 0);
            this.loadingCheckList.Controls.Add(this.loadingChechListItemTextLabel3, 0, 2);
            this.loadingCheckList.Controls.Add(this.loadingChechListItemTextLabel2, 0, 1);
            this.loadingCheckList.Controls.Add(this.loadingChechListItemPictureBox1, 1, 0);
            this.loadingCheckList.Controls.Add(this.loadingChechListItemPictureBox2, 1, 1);
            this.loadingCheckList.Controls.Add(this.loadingChechListItemPictureBox3, 1, 2);
            this.loadingCheckList.Name = "loadingCheckList";
            // 
            // loadingChechListItemTextLabel1
            // 
            resources.ApplyResources(this.loadingChechListItemTextLabel1, "loadingChechListItemTextLabel1");
            this.loadingChechListItemTextLabel1.Name = "loadingChechListItemTextLabel1";
            // 
            // loadingChechListItemTextLabel3
            // 
            resources.ApplyResources(this.loadingChechListItemTextLabel3, "loadingChechListItemTextLabel3");
            this.loadingChechListItemTextLabel3.Name = "loadingChechListItemTextLabel3";
            this.loadingChechListItemTextLabel3.UseMnemonic = false;
            // 
            // loadingChechListItemTextLabel2
            // 
            resources.ApplyResources(this.loadingChechListItemTextLabel2, "loadingChechListItemTextLabel2");
            this.loadingChechListItemTextLabel2.Name = "loadingChechListItemTextLabel2";
            this.loadingChechListItemTextLabel2.UseMnemonic = false;
            // 
            // loadingChechListItemPictureBox1
            // 
            this.loadingChechListItemPictureBox1.Image = global::LightLibraryManager.Properties.Resources.wait;
            resources.ApplyResources(this.loadingChechListItemPictureBox1, "loadingChechListItemPictureBox1");
            this.loadingChechListItemPictureBox1.Name = "loadingChechListItemPictureBox1";
            this.loadingChechListItemPictureBox1.TabStop = false;
            // 
            // loadingChechListItemPictureBox2
            // 
            this.loadingChechListItemPictureBox2.Image = global::LightLibraryManager.Properties.Resources.wait;
            resources.ApplyResources(this.loadingChechListItemPictureBox2, "loadingChechListItemPictureBox2");
            this.loadingChechListItemPictureBox2.Name = "loadingChechListItemPictureBox2";
            this.loadingChechListItemPictureBox2.TabStop = false;
            // 
            // loadingChechListItemPictureBox3
            // 
            this.loadingChechListItemPictureBox3.Image = global::LightLibraryManager.Properties.Resources.wait;
            resources.ApplyResources(this.loadingChechListItemPictureBox3, "loadingChechListItemPictureBox3");
            this.loadingChechListItemPictureBox3.Name = "loadingChechListItemPictureBox3";
            this.loadingChechListItemPictureBox3.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::LightLibraryManager.Properties.Resources.logo;
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // LoadingWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadingCheckList);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label1);
            this.Name = "LoadingWindow";
            this.loadingCheckList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingChechListItemPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingChechListItemPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingChechListItemPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TableLayoutPanel loadingCheckList;
        private System.Windows.Forms.Label loadingChechListItemTextLabel1;
        private System.Windows.Forms.Label loadingChechListItemTextLabel3;
        private System.Windows.Forms.Label loadingChechListItemTextLabel2;
        private System.Windows.Forms.PictureBox loadingChechListItemPictureBox1;
        private System.Windows.Forms.PictureBox loadingChechListItemPictureBox2;
        private System.Windows.Forms.PictureBox loadingChechListItemPictureBox3;
    }
}