using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Codebasedexam3
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;

        static void Main(string[] args)
        {
            EmpInsert();
            Console.ReadLine();
        }

        static void EmpInsert()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter Employee Details : ");
                string empname, emptype;
                float empsal;
                Console.WriteLine("Enter Employee Name : ");
                empname = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary : ");
                empsal = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Type 'C' Or 'P' :");
                emptype = Console.ReadLine();
                cmd = new SqlCommand("execute dbo.empinsert  @empname, @empsal, @emptype");

                cmd.Parameters.AddWithValue("@empname", empname);
                cmd.Parameters.AddWithValue("@empsal", empsal);
                cmd.Parameters.AddWithValue("@emptype", emptype);
                cmd.Connection = con;
                int no_ofrows = cmd.ExecuteNonQuery();
                if (no_ofrows > 0)
                {
                    Console.WriteLine("Inserted");
                }
                else
                {
                    Console.WriteLine("Not Inserted");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        public static SqlConnection getCon()
        {
            //con = new SqlConnection("data source=ADMW46ZLPC1575\\SQLEXPRESS;Initial Catalog=EmployeeManagementDB;" +
            //"user id=sa; password=Temp1234");
            con = new SqlConnection("data source=ADMW46ZLPC1575\\SQLEXPRESS;Initial Catalog=EmployeeManagementDB;" +
            "user id=sa; password=Temp1234");
            con.Open();
            return con;
        }
    }
}

