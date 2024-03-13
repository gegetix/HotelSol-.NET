from xmlrpc import client

class ConexionOdoo(object):

    def __init__(self, url=None, dbname=None, user=None, pwd=None, common=None):
        self.url = url or 'http://localhost:8069'
        self.dbname = dbname or 'Hotel'
        self.user = user or 'openpg'
        self.pwd = pwd or 'openpgpwd'
        self.common = common or client.ServerProxy('{}/xmlrpc/2/common'.format(self.url))
        self.uid = self.common.authenticate(self.dbname, self.user, self.pwd, {})
        self.models = client.ServerProxy('{}/xmlrpc/2/object'.format(self.url))
