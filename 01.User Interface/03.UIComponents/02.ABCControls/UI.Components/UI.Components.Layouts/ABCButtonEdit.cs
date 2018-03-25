﻿using System;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevExpress.XtraEditors;


using ABCCommon;

namespace ABCControls
{
    [ToolboxBitmapAttribute( typeof( DevExpress.XtraEditors.ButtonEdit ))]
    [Designer(typeof(ABCButtonEditDesigner))]
    public class ABCButtonEdit : DevExpress.XtraEditors.ButtonEdit,IABCControl
    {
        public ABCView OwnerView { get; set; }

        #region External Properties

        [Category( "ABC" )]
        public String Comment { get; set; }
        [Category( "ABC.Format" )]
        public String FieldGroup { get; set; }
      
        [Category( "External" )]
        public String EditMask
        {
            get
            {
                return this.Properties.Mask.EditMask;
            }
            set
            {
                this.Properties.Mask.EditMask=value;
            }
        }
        [Category( "External" )]
        public DevExpress.XtraEditors.Mask.MaskType MaskType
        {
            get
            {
                return this.Properties.Mask.MaskType;
            }
            set
            {
                this.Properties.Mask.MaskType=value;
            }
        }

        [Category( "External" )]
        public Boolean ReadOnly
        {
            get
            {
                return this.Properties.ReadOnly;
            }
            set
            {
                this.Properties.ReadOnly=value;
            }
        }

        bool isVisible=true;
        [Category( "External" )]
        public Boolean IsVisible
        {
            get
            {
                return isVisible;
            }
            set
            {
                isVisible=value;
                 if(OwnerView.Mode!=ViewMode.Design) this.Visible=value;
            }
        }
        [Category( "External" )]
        public String DummyText
        {
            get
            {
                return this.Properties.NullValuePrompt;
            }
            set
            {
                this.Properties.NullValuePrompt=value;
            }
        }

        
        #endregion
       
        public ABCButtonEdit ()
        {
        }

        #region IABCControl
        public void InitControl ( )
        {
            InitBothMode();

              if ( OwnerView!=null &&OwnerView.Mode==ViewMode.Design)
                InitDesignTime();
            else
                InitRunTime();
        }

        public void InitBothMode ( )
        {
            this.Properties.NullValuePrompt=DummyText;

            if ( this.Anchor==AnchorStyles.None )
                this.Anchor=AnchorStyles.Left|AnchorStyles.Top;

            

            if ( !String.IsNullOrWhiteSpace( EditMask.ToString() )&&!String.IsNullOrWhiteSpace( MaskType.ToString() ) )
                this.Properties.Mask.UseMaskAsDisplayFormat=true;

            this.Properties.NullValuePromptShowForEmptyValue=true;

            if ( this.RightToLeft==System.Windows.Forms.RightToLeft.Yes )
                this.Properties.Appearance.TextOptions.HAlignment=DevExpress.Utils.HorzAlignment.Far;
        }
        public void InitRunTime ( )
        {

        }
        public void InitDesignTime ( )
        {
        }
        
        #endregion
      
    }

    public class ABCButtonEditDesigner : ControlDesigner
    {
        public ABCButtonEditDesigner ( )
        {
        }
    }
}
