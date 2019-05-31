import pyodbc

try:
    with pyodbc.connect("DRIVER={SQL SERVER};SERVER=localhost\\SQLEXPRESS;DATABASE=master;UID=MSSQLUSER;PWD=PASSWORD") as cnn:

        cursor = cnn.cursor()
        cursor.execute("SELECT @@VERSION AS \'SQL Server Version\'")
        print(cursor.fetchone()[0])

except Exception as e:
    print(e.args)
