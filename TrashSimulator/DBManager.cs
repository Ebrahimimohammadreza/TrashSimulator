using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrashSimulator
{
    public class DBManager
    {
        private SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\493619\\Documents\\TrashDataBase.mdf;Integrated Security=True;Connect Timeout=30");
        private SqlCommand cm = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        public DataSet getTrash()
        {
            try
            {
                cm.Connection = cn;
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                cm.CommandText = "select * from trash";
                da.SelectCommand = cm;
                DataSet dsReturn = new DataSet();
                da.Fill(dsReturn);
                return (dsReturn);
            }
            catch (Exception ex)
            {
                throw new Exception("error");
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void upsert(Guid trashID, double latitude, double longitude, int Occupied)
        {
            try
            {
                cm.Connection = cn;
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                cm.CommandText = string.Format(@"select count(t.trashid) from trash t where  trashid = '{0}'", trashID.ToString());
                object obj = cm.ExecuteScalar();
                if (obj != null && (int)obj > 0)
                {
                    //update
                    cm.CommandText = string.Format(@"update trash  set Occupied ={0},Latitude ={1},Longitude={2} where  trashid = '{3}' ", Occupied, latitude, longitude, trashID.ToString());
                    cm.ExecuteNonQuery();
                }
                else
                {
                    //insert
                    cm.CommandText = string.Format(@"insert into trash (trashid,Occupied,Latitude,Longitude) values ('{0}',{1},{2},{3}) ", trashID.ToString(), Occupied, latitude, longitude);
                    cm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error");
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        //public void emptyOrderUPdate(Guid trashID, int emptyorder)
        //{
        //    try
        //    {
        //        cm.Connection = cn;
        //        if (cn.State != ConnectionState.Open)
        //        {
        //            cn.Open();
        //        }
        //        if (emptyorder == 1)
        //        {
        //            cm.CommandText = string.Format(@"update trash  set emptyorder ={0} where  trashid = '{1}' ", emptyorder, trashID.ToString());
        //        }
        //        else
        //        {
        //            cm.CommandText = string.Format(@"update trash  set emptyorder ={0},Occupied = 0 where  trashid = '{1}' ", emptyorder, trashID.ToString());
        //        }
        //        cm.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("error");
        //    }
        //    finally
        //    {
        //        if (cn.State != ConnectionState.Closed)
        //        {
        //            cn.Close();
        //        }
        //    }
        //}

        public void clearDB()
        {
            try
            {
                cm.Connection = cn;
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }

                cm.CommandText = string.Format(@"delete from  trash ");
                cm.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("error");
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

    }

}
