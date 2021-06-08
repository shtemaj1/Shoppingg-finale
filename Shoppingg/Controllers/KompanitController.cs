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

namespace Shoppingg.Controllers
{
    public class KompanitController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"
             select KompaniaID,Emri,Produkti,Marka
             from dbo.Kompanit
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
        public string Post(Kompanit ko)
        {
            try
            {
                string query = @"
                  insert into dbo.Kompanit values
                   (
                   
                     '" + ko.Emri + @"'
                    ,'" + ko.Produkti + @"'
                    ,'" + ko.Marka + @"'
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
        public string Put(Kompanit ko)
        {
            try
            {
                string query = @"
                  update dbo.Kompanit set 
                   Emri='" + ko.Emri + @"'
                  ,Produkti='" + ko.Produkti + @"'
                  ,Marka='" + ko.Marka + @"'
                   where KompaniaID=" + ko.KompaniaID + @"
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
                  delete from dbo.Kompanit 
                  where KompaniaID =" + id + @"
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
    }
}
