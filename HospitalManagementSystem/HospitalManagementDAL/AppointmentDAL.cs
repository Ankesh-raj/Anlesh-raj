using HospitalManagementEntityy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementDAL
{
    public class AppointmentDAL
    {
        List<Patient> patients;

        public static string sqlcon = "Data Source=DESKTOP-2AJ3ULQ\\SQLEXPRESS;Initial Catalog=HospitalManagementService;Integrated Security=True";
        public string AddPatientsDAL(Patient patient)
        {

            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("insert into Patient values(" + patient.PatientId + ",'" + patient.PatientName + "','" + patient.PatientEmail + "','" + patient.PatientPassword + "')", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "patient inserted";


            return msg;


        }
    }
}
