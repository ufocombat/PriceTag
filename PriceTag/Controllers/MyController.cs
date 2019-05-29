using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriceTag.Models;


namespace PriceTag.Controllers
{
    public class MyController : Controller
    {
        public DataSet data;

        public DataSet InitData()
        {
            data = new DataSet();
            data.DataSetName = "ItemsDataSet";

            DataTable dt = new DataTable("Items");

            dt.Columns.Add(new DataColumn("ID", typeof(String)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Price", typeof(float)));
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Columns.Add(new DataColumn("FileName", typeof(string)));

            {
                DataRow dr = dt.NewRow();
                dr["ID"] = "10000";
                dr["Name"] = "Set of flash cards";
                dr["Price"] = 10;
                dr["Description"] = "A set of flash cards for all occasions";
                dr["FileName"] = "flash.jpg";
                dt.Rows.Add(dr);
            }

            {
                DataRow dr = dt.NewRow();
                dr["ID"] = "10010";
                dr["Name"] = "Piggy bank";
                dr["Price"] = 30;
                dr["Description"] = "Piggy bank for high-tech lovers";
                dr["FileName"] = "bank.jpg";
                dt.Rows.Add(dr);
            }
           
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = "10012";
                dr["Name"] = "Tea strainer";
                dr["Price"] = 0.99;
                dr["Description"] = "Very cute tea strainer";
                dr["FileName"] = "strainer.jpg";
                dt.Rows.Add(dr);
            }

            data.Tables.Add(dt);
            return data;
        }
    }
}
