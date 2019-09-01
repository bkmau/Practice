import mysql.connector as DRIVER

class UseDatabase:
    def __init__(self, db_config):
        self.config = db_config

    def __enter__(self):
        self.cnn = DRIVER.connect(**self.config)
        self.cursor = self.cnn.cursor()
        return self.cursor


    def __exit__(self, exc_type, exc_value, exc_trace):
        self.cnn.commit()
        self.cursor.close()
        self.cnn.close()