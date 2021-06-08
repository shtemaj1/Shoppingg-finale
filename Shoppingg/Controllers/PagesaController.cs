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
    public class PagesaController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"
             select PagesaId,Cash, CreditCard ,Coins
             from dbo.Pagesa
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
        public string Post(Pagesa pag)
        {
            try
            {
                string query = @"
                  insert into dbo.Pagesa values
                   (
                   
                    '" + pag.Cash + @"'
                    ,'" + pag.CreditCard + @"'
                    ,'" + pag.Coins + @"'
                    
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
        public string Put(Pagesa pag)
        {
            try
            {
                string query = @"
                  update dbo.Pagesa set 
                   Cash='" + pag.Cash + @"'
                  ,CreditCard='" + pag.CreditCard + @"'
                  ,Coins='" + pag.Coins + @"'
                   where PagesaId=" + pag.PagesaId + @"
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
                  delete from dbo.Pagesa 
                  where PagesaId =" + id + @"
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
