class conexionSQL(object):

    def __init__(self,database=None, user=None, password=None, host=None):

        self.database = database or "Hotel"
        self.user = user or "openpg"
        self.password =password or "openpg"
        self.host = host or "localhost"

