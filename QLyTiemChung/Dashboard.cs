using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLyTiemChung
{

    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Dashboard : Connection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get; private set; }
        public int NumPhieuTiem { get; private set; }
        public int NumThuoc { get; private set; }
        public List<KeyValuePair<string, int>> TopThuocList { get; private set; }
        public List<RevenueByDate>  GrossRevenueList { get; private set; }
        public decimal TotalRevenue {  get; set; }
       
    

        public Dashboard() { }


        private void GetNumberItems()
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select count(MaKH) from Khach_hang";
                    NumCustomers = (int)command.ExecuteScalar();

                    command.CommandText = "select count(MaPhieu) from Phieu_Tiem_Phong";
                    NumPhieuTiem = (int)command.ExecuteScalar();

                    command.CommandText = @"select count(t.MaThuoc)" + 
                        " from THUOC t" +
                        " left join Lo_Thuoc l on t.MaLo = l.MaLo" +
                        " where l.NSX <= GETDATE() and l.HSD >= GETDATE()";
                    NumThuoc = (int)command.ExecuteScalar();
                }
            }
        }

        private void GetHoaDonAnalys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalRevenue = 0;

            using( var  connection = GetSqlConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select h.NgayHD, SUM(ct.ThanhTien) as TotalAmount
                                    from Hoa_Don h
                                    inner join CT_Hoa_Don ct on h.MaHD = ct.MaHD
                                    where h.NgayHD between @fromDate and @toDate
                                    group by h.NgayHD";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                        TotalRevenue += (decimal)reader[1];

                    }
                    reader.Close();

                    // Debug output to check if resultTable has data
                    Console.WriteLine("Number of records in resultTable: " + resultTable.Count);
                    foreach (var record in resultTable)
                    {
                        Console.WriteLine("Date: " + record.Key + ", TotalAmount: " + record.Value);
                    }

                    // Group by Days
                    if (numberDays <= 30)
                    {
                        foreach(var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }

                    // group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                                            
                    }

                    // Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)

                                            }).ToList();
                    }

                    // Group by Years
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)

                                            }).ToList();
                    }
                }
            }
        }

        private void GetThuocAnalys()
        {
            TopThuocList = new List<KeyValuePair<string, int>>();
            using(var connection = GetSqlConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = "select top 5 lt.TenLoai, sum(cast(t.SoLuong as int)) as Q\r\nfrom THUOC t\r\nleft join Loai_Thuoc lt on t.MaLoai = lt.MaLoai\r\nleft join Lo_Thuoc l on t.MaLo = l.MaLo\r\nwhere l.NSX <= GETDATE() and l.HSD >= GETDATE()\r\ngroup by lt.TenLoai\r\norder by Q desc";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopThuocList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                     
                    }
                    reader.Close();
                }
            }
        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if(startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetHoaDonAnalys();
                GetThuocAnalys();
                Console.WriteLine("refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
        
    }
}
