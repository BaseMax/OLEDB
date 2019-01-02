/* 
 *
 * OLED.cs
 * Author: Base Max
 * Purpose of write is easy and ready (https://github.com/BaseMax/).
 * OLEDB = OLE DB = Object Linking + Embedding Database
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
class OlED
{
    public void connect(string query)
    {
    }
    public OleDbDataReader selects(OleDbCommand command, OleDbConnection connection)
    {
        connection.Open();
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            connection.Close();
            return reader;
        }
    }
    public DataSet get(OleDbCommand command, OleDbConnection connection)
    {
        connection.Open();
        DataSet set = new DataSet();
        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
        {
            adapter.Fill(set);
            connection.Close();
            return set;
        }
    }
    public Int64 count(OleDbCommand command, OleDbConnection connection)
    {
        Int64 count = 0;
        connection.Open();
        //try,catch
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                count++;
            }
        }
        connection.Close();
        return count;
    }
}/* 
 *
 * OLED.cs
 * Author: Base Max
 * The purpose of writing this library is to create a simple and ready-made facility. (https://github.com/BaseMax/).
 * OLEDB = OLE DB = Object Linking + Embedding Database
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

class OlED
{
    public void connect(string query)
    {
    }
    public OleDbDataReader selects(OleDbCommand command, OleDbConnection connection)
    {
        connection.Open();
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            connection.Close();
            return reader;
        }
    }
    public DataSet get(OleDbCommand command, OleDbConnection connection)
    {
        connection.Open();
        DataSet set = new DataSet();
        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
        {
            adapter.Fill(set);
            connection.Close();
            return set;
        }
    }
    public Int64 count(OleDbCommand command, OleDbConnection connection)
    {
        Int64 count = 0;
        connection.Open();
        //try,catch
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                count++;
            }
        }
        connection.Close();
        return count;
    }
}
