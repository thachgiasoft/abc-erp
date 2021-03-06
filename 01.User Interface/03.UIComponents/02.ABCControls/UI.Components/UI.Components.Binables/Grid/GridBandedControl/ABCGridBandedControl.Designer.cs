﻿namespace ABCControls
{
    partial class ABCGridBandedControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components=null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing&&( components!=null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.InnerGrid=new ABCBaseBandedGridControl();
            this.BandedView=new ABCGridBandedView(this);
            ( (System.ComponentModel.ISupportInitialize)( this.InnerGrid ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.BandedView ) ).BeginInit();
            this.SuspendLayout();
            // 
            // gridCtrl
            // 
            this.InnerGrid.Dock=System.Windows.Forms.DockStyle.Fill;
            this.InnerGrid.Location=new System.Drawing.Point( 0 , 0 );
            this.InnerGrid.MainView=this.BandedView;
            this.InnerGrid.Name="gridCtrl";
            this.InnerGrid.Size=new System.Drawing.Size( 293 , 172 );
            this.InnerGrid.TabIndex=0;
            this.InnerGrid.UseEmbeddedNavigator=true;
            this.InnerGrid.EmbeddedNavigator.Buttons.CancelEdit.Visible=false;
            this.InnerGrid.EmbeddedNavigator.Buttons.Edit.Visible=false;
            this.InnerGrid.EmbeddedNavigator.Buttons.Remove.Visible=false;
            this.InnerGrid.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BandedView} );
            // 
            // gridView
            // 
            this.BandedView.GridControl=this.InnerGrid;
            this.BandedView.Name="gridView";
            this.BandedView.OptionsView.ShowGroupPanel=false;

            // 
            // BandedView
            // 
            this.AutoScaleDimensions=new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.InnerGrid );
            this.Name="BandedView";
            this.Size=new System.Drawing.Size( 293 , 172 );
            ( (System.ComponentModel.ISupportInitialize)( this.InnerGrid ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.BandedView ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private ABCBaseBandedGridControl InnerGrid;
        public  ABCGridBandedView BandedView;
    }
}
