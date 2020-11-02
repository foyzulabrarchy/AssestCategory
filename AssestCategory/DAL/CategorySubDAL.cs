using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AssestCategory.Utilities;

namespace AssestCategory.DAL
{
    public class CategorySubDAL
    {
        public DataTable Submit(string eID, string cNAME, string code, string dEsc, string userid, bool sTatus)
        {

            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DBConnection.GetConnectionString());
                if (conn.State == 0)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("SP_ASS_CATEGORY", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@eID", eID);
                cmd.Parameters.AddWithValue("@clID", dEsc);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@dEsc", cNAME);
                cmd.Parameters.AddWithValue("@cBy", userid);
                cmd.Parameters.AddWithValue("@sTatus", sTatus);
                cmd.Parameters.AddWithValue("@sT", 1);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DBConnection.GetConnectionString());
                if (conn.State == 0)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("USP_ASSEST_CATEGORY", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Update(string eID, string cNAME, string code, string dEsc, string userid, bool sTatus)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DBConnection.GetConnectionString());
                if (conn.State == 0)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("SP_ASS_CATEGORY", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@eID", eID);
                cmd.Parameters.AddWithValue("@clID", dEsc);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@dEsc", cNAME);
                cmd.Parameters.AddWithValue("@cBy", userid);
                cmd.Parameters.AddWithValue("@sTatus", sTatus);
                cmd.Parameters.AddWithValue("@sT", 2);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}