# OLEDB
Simple and compact class library for working with the MS OLE Database.

OLEDB = OLE DB = Object Linking + Embedding Database



# Using :
```
OlED db = new OlED();
```

# Library features :

- [x] get count rows
- [x] get rows values
- [x] get rows and fetch for DataGridView


# Sample Using :
```
OlED db = new OlED();
OleDbConnection connection = new OleDbConnection(connections);
OleDbCommand command = new OleDbCommand("SELECT * from barcode",connection);
////////////////////////////////////////////////////////////////////////
MessageBox.Show("Count Rows : " + db.count(command,connection).ToString());
////////////////////////////////////////////////////////////////////////
dataGridView1.DataSource = db.get(command,connection).Tables[0];
```
