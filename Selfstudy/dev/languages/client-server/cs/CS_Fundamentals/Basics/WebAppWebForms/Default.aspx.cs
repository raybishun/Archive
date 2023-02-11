using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppWebForms
{
    public partial class _Default : Page
    {

        // Init
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write($"{System.Reflection.MethodBase.GetCurrentMethod().Name}.<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write($"{System.Reflection.MethodBase.GetCurrentMethod().Name}.<br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write($"{System.Reflection.MethodBase.GetCurrentMethod().Name}.<br/>");
        }

        // Load
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write($"{System.Reflection.MethodBase.GetCurrentMethod().Name}.<br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write($"{System.Reflection.MethodBase.GetCurrentMethod().Name}.<br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write($"{System.Reflection.MethodBase.GetCurrentMethod().Name}.<br/>");
        }

        // Render
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write($"{System.Reflection.MethodBase.GetCurrentMethod().Name}.<br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write($"{System.Reflection.MethodBase.GetCurrentMethod().Name}.<br/>");
        }

        // Save State
        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            Response.Write($"{System.Reflection.MethodBase.GetCurrentMethod().Name}.<br/>");
        }

        //protected void Page_Unload(object sender, EventArgs e)
        //{
        //    Response.Write($"{System.Reflection.MethodBase.GetCurrentMethod().Name}.<br/>");
        //}
    }
}