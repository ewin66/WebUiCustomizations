using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Web.Templates.ActionContainers;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace WebUiCustomizations.Module.Web.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class HeaderBar : WindowController
    {
        SimpleAction toggleNavBarAction;
        public HeaderBar()
        {
            InitializeComponent();
            TargetWindowType = WindowType.Main;
            toggleNavBarAction = new SimpleAction(this,"Mi Menu", "Security");
            toggleNavBarAction.ImageName = "burger";
            toggleNavBarAction.PaintStyle = ActionItemPaintStyle.Image;            
            toggleNavBarAction.SetClientScript("OnClick('LPcell','separatorImage',true)", false);
            toggleNavBarAction.SetClientScript("window.xafNavigation.Toggle()",false);
            

            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            //Frame.GetController<ActionControlsSiteController>().CustomizeContainerActions += OnCustomizeContainerActions;
            //Frame.GetController<FillActionContainersController>().CustomizeContainerActions += OnCustomizeContainerActions;
            Frame.ProcessActionContainer += Frame_ProcessActionContainer;

            // Perform various tasks depending on the target View.
        }

        private void Frame_ProcessActionContainer(object sender, ProcessActionContainerEventArgs e)
        { 
            if (e.ActionContainer.ContainerId=="Security")
            {
                ((WebActionContainer)e.ActionContainer).IsDropDown = false;
                //((WebActionContainer)e.ActionContainer).DefaultActionID = "Mi Menu";
                //((WebActionContainer)e.ActionContainer).DefaultItemImageName = "BO_Note_Active";
            }
        }

        //private void OnCustomizeContainerActions(object sender, CustomizeContainerActionsEventArgs e)
        //{
        //   // ActionBase actionToBeMoved = e.AllActions.Find("SaveAndNew");
        //    if ((e.Category == "Security") && (e.Container is BarLinkActionControlContainer))
        //    {
        //        e.ContainerActions.Remove(actionToBeMoved);
        //    }
        //    if ((actionToBeMoved != null) && (e.Category == "Edit"))
        //    {
        //        e.ContainerActions.Add(actionToBeMoved);
        //    }
        //}
        //protected override void OnViewControlsCreated()
        //{
        //    base.OnViewControlsCreated();
        //    //LiteralControl style = new LiteralControl();
        //    //ActionContainerViewItem viewItem;
        //    //viewItem.
        //    //style.Text = "<style type='text/css' scoped>.white { background-color: palegreen; }</style>";
        //    //((Control)View.Control).Controls.Add(style);

        //    //((Control)View.Control).Page.Header.Controls.Add(mio);
        //    // Access and customize the target View control.
        //}
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
