using GrubCaddie.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace GrubCaddie.UI.Helper
{
    public class ImageHandler : IHttpHandler
    {
        byte[] bytes;

        public void ProcessRequest(HttpContext context)
        {
            int param;
            if (int.TryParse(context.Request.QueryString["id"], out param))
            {
                using (var db = new GrubCaddieContext())
                {
                    if (param == -1)
                    {
                        bytes = File.ReadAllBytes(HttpContext.Current.Server.MapPath("~/Images/add.png"));

                        context.Response.ContentType = "image/png";
                    }
                    else
                    {
                        var data = (from x in db.Menus
                                    where x.Id == (short)param
                                    select x).FirstOrDefault();

                        bytes = data.Image;

                        context.Response.ContentType = "image/" + data.ImageFileType;
                    }

                    context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    context.Response.BinaryWrite(bytes);
                    context.Response.Flush();
                    context.Response.End();
                }
            }
            else
            {
                //image not found
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}