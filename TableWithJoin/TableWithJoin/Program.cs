using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TableWithJoin
{
    class Program
    {
        static SqlConnection con;
        static SqlCommand com;
        public static void connection()
        {
            con = new SqlConnection(@"data source=.\RAZISQL; Persist Security Info=true; User ID=sa; Password=gb2266");
            con.Open();
        }
        public static void LeftJion()
        {
            //for left join
            String sql = "SELECT Student.name, employee.id FROM Student LEFT JOIN employee on Student.name = employee.name ORDER BY employee.name";
            com = new SqlCommand(sql, con);
            SqlDataReader sdr = com.ExecuteReader();
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                Console.Write(sdr.GetName(i) + "\t" + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("=================================");
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr[sdr.GetName(i)] + "\t" + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void RightJion()
        {
            //for right join
            String sql = "SELECT Student.name, employee.id FROM Student RIGHT JOIN employee on Student.name = employee.name ORDER BY employee.name";
            com = new SqlCommand(sql, con);
            SqlDataReader sdr = com.ExecuteReader();
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                Console.Write(sdr.GetName(i) + "\t" + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("=================================");
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr[sdr.GetName(i)] + "\t" + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void FullJion()
        {
            //for full outer join
            String sql = "SELECT Student.name, employee.id FROM Student FULL OUTER JOIN employee on Student.name = employee.name ORDER BY employee.name";
            com = new SqlCommand(sql, con);
            SqlDataReader sdr = com.ExecuteReader();
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                Console.Write(sdr.GetName(i) + "\t" + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("=================================");
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr[sdr.GetName(i)] + "\t" + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            connection();
            //LeftJion();
            //RightJion();
            FullJion();

            Console.ReadLine();
        }
    }
}
