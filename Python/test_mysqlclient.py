import MySQLdb as DRIVER

try:
    cnn = DRIVER.connect(host="localhost", user="blabla", passwd="hello_world")
    cursor = cnn.cursor()

    cursor.execute("SELECT VERSION()")

    print("Database version: {}".format(cursor.fetchone()))
except Exception as err:
    print("Ther is error occur:\r\n{}".format(err.args[1]))


