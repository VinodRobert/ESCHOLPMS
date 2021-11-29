using SQLHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCHOLPMS 
{
    class EmployeeImages
    {
        public DataSet FetchPhoto(int employeeID)
        {
            string _connectionString = SqlHelper.GetConnectionStringAttachment();
            string sql = "Select * from photos where employeeID=" + Convert.ToString(employeeID);
            DataSet dsEmployeePhoto = SqlHelper.ExecuteDataset(_connectionString, CommandType.Text, sql);
            return dsEmployeePhoto;
        }


        public int InsertEmployeePhoto(int employeeID, string photoFileName)
        {
            string qrImageFileName = photoFileName;
            FileStream FS = new FileStream(qrImageFileName, FileMode.Open, FileAccess.Read);
            byte[] qrimg = new byte[FS.Length];
            FS.Read(qrimg, 0, Convert.ToInt32(FS.Length));
            Int64 imageSize = FS.Length;

            string _connectionString = SqlHelper.GetConnectionStringAttachment();
            SqlParameter[] arParms = new SqlParameter[3];


            arParms[0] = new SqlParameter("@EMPLOYEEID", SqlDbType.Int);
            arParms[0].Value = employeeID;

            arParms[1] = new SqlParameter("@PHOTOIMAGE", SqlDbType.Image);
            arParms[1].Value = qrimg;

            arParms[2] = new SqlParameter("@FILESIZE", SqlDbType.BigInt);
            arParms[2].Value = imageSize;

            int i = SqlHelper.ExecuteNonQuery(_connectionString, CommandType.StoredProcedure, "[spAddEditEmployeePhoto]", arParms);
            return i;
        }
    }
}
