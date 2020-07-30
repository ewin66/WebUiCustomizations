using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Web.Templates;
using DevExpress.ExpressApp.Web.Templates.ActionContainers;

public partial class Default : BaseXafPage
{
    protected override ContextActionsMenu CreateContextActionsMenu()
    {
        return new ContextActionsMenu(this, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports");
    }
    public override Control InnerContentPlaceHolder
    {
        get
        {
            return Content;
        }

    }
    //protected void Page_Init()
    //{
    //    CustomizeTemplateContent += (s, e) =>
    //    {
    //        //IHeaderImageControlContainer content = TemplateContent as IHeaderImageControlContainer;
    //        IActionContainer mio = templateContent as IActionContainer;
    //        mio.ContainerId = "Mia";

    //        //if (content == null) return;
    //        //content.HeaderImageControl.DefaultThemeImageLocation = "Images";
    //        //content.HeaderImageControl.ImageName = "CustomLogo.svg";
    //        //content.HeaderImageControl.Width = Unit.Pixel(30);
    //        //content.HeaderImageControl.Height = Unit.Pixel(30);
    //    };
    //}
}