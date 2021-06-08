using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shoppingg.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace Shoppingg.Controllers
{
    public class OfertaController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"
             select OfertaId,Ditore,Javore,Sezonale,Outlet
             from dbo.Oferta
             ";
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["ZbritjaProdukteveApp"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }
        public string Post(Oferta ofe)
        {
            try
            {
                string query = @"
                  insert into dbo.Oferta values
                   (
                   
                    '" + ofe.Ditore + @"'
                    ,'" + ofe.Javore + @"'
                    ,'" + ofe.Sezonale + @"'
                    ,'" + ofe.Outlet + @"'
                   ) 
                  ";
                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["ZbritjaProdukteveApp"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return "Added Successfully.";
            }
            catch (Exception)
            {
                return "Failed to Add";
            }
        }
        public string Put(Oferta ofe)
        {
            try
            {
                string query = @"
                  update dbo.Oferta set 
                   Ditore='" + ofe.Ditore + @"'
                  ,Javore='" + ofe.Javore + @"'
                  ,Sezonale='" + ofe.Sezonale + @"'
                  ,Outlet='" + ofe.Outlet + @"'
                   where OfertaId=" + ofe.OfertaId + @"
                   ";
                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["ZbritjaProdukteveApp"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Update Successfully.";
            }
            catch (Exception)
            {
                return "Failed to Update.";
            }
        }
        public string Delete(int id)
        {
            try
            {
                string query = @"
                  delete from dbo.Oferta 
                  where OfertaId =" + id + @"
                   ";
                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["ZbritjaProdukteveApp"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Deleted Successfully.";
            }
            catch (Exception)
            {
                return "Failed to delete.";
            }
        }
        [Route("api/Oferta/SaveFile")]
        public string SaveFile()
        {
            try
            {
                var httpRequest = HttpContext.Current.Request;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = HttpContext.Current.Server.MapPath("~/Photo/" + filename);

                postedFile.SaveAs(physicalPath);

                return filename;
            }
            catch (Exception)
            {
                return "anonymous.png";
            }
        }
    }
}
