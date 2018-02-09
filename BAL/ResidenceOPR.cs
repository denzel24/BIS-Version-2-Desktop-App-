using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data.SqlClient;
using System.Data;

namespace BAL
{
    public class ResidenceOPR
    {
        public ResidenceInfo RInfo = new ResidenceInfo();
        public dbConnection db = new dbConnection();
        
        public object InsertResidence(ResidenceInfo RInfo)
        {
            SqlCommand cmd = new SqlCommand("insertResidence");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@resFullName", SqlDbType.VarChar).Value = RInfo.resFullName;
            cmd.Parameters.AddWithValue("@resBdate", SqlDbType.VarChar).Value = RInfo.resBdate;
            cmd.Parameters.AddWithValue("@resBplace", SqlDbType.VarChar).Value = RInfo.resBplace;
            cmd.Parameters.AddWithValue("@resAddress", SqlDbType.VarChar).Value = RInfo.resAddress;
            cmd.Parameters.AddWithValue("@resPurok", SqlDbType.VarChar).Value = RInfo.resPurok;
            cmd.Parameters.AddWithValue("@resGender", SqlDbType.VarChar).Value = RInfo.resGender;
            cmd.Parameters.AddWithValue("@resReligion", SqlDbType.VarChar).Value = RInfo.resReligion;
            cmd.Parameters.AddWithValue("@resCitizenship", SqlDbType.VarChar).Value = RInfo.resCitizenship;
            cmd.Parameters.AddWithValue("@resCivilStatus", SqlDbType.VarChar).Value = RInfo.resCivilStatus;
            cmd.Parameters.AddWithValue("@resBloodType", SqlDbType.VarChar).Value = RInfo.resBloodType;
            cmd.Parameters.AddWithValue("@resContact", SqlDbType.VarChar).Value = RInfo.resContact;
            cmd.Parameters.AddWithValue("@resStartedLiving", SqlDbType.VarChar).Value = RInfo.resStartedLiving;
            return db.ExeScalar(cmd);
        }
        public int insertRegisteredVoter(ResidenceInfo RInfo)
        {
            SqlCommand cmd = new SqlCommand("insertRegisteredVoter");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@resId", SqlDbType.VarChar).Value = RInfo.resId;
            cmd.Parameters.AddWithValue("@VIN", SqlDbType.VarChar).Value = RInfo.VIN;
            cmd.Parameters.AddWithValue("@PrecinctNo", SqlDbType.VarChar).Value = RInfo.PrecinctNo;
            cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = RInfo.Address;
            return db.ExeNonQuery(cmd);
        }

        public int insertPWD(ResidenceInfo RInfo)
        {
            SqlCommand cmd = new SqlCommand("insertPWD");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@resId", SqlDbType.VarChar).Value = RInfo.resId;
            cmd.Parameters.AddWithValue("@pwdControlNo", SqlDbType.VarChar).Value = RInfo.pwdControlNo;
            cmd.Parameters.AddWithValue("@dateRegistered", SqlDbType.VarChar).Value = RInfo.dateRegistered;
            cmd.Parameters.AddWithValue("@disabilityType", SqlDbType.VarChar).Value = RInfo.disabilityType;
            cmd.Parameters.AddWithValue("@causeOfDisability", SqlDbType.VarChar).Value = RInfo.causeOfDisability;
            return db.ExeNonQuery(cmd);
        }
        public int insertSeniorCitizen(ResidenceInfo RInfo)
        {
            SqlCommand cmd = new SqlCommand("insertSeniorCitizen");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@resId", SqlDbType.VarChar).Value = RInfo.resId;
            cmd.Parameters.AddWithValue("@SenControlNo", SqlDbType.VarChar).Value = RInfo.SenControlNo;
            cmd.Parameters.AddWithValue("@dateRegistered", SqlDbType.VarChar).Value = RInfo.dateRegistered;
            return db.ExeNonQuery(cmd);
        }
    }
}
