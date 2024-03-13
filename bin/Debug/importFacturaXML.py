from xmlrpc import client
import xml.etree.ElementTree as ET
from datetime import datetime
import os,sys
import conectionClass as cc
# Conectar 

class conectarFactura(cc.ConexionOdoo):

    def __init__(self,*args,**kwargs):
        super().__init__(*args,**kwargs)
        self.conectarFactura()
        #print(self.dbname)
     
    def conectarFactura(self):

        pathRoot = os.path.abspath(__file__)
        pathName = os.path.basename(pathRoot)
        pathDirectory = pathRoot.split(pathName)[0]
        factura = pathDirectory + "Factura.XML"
        if os.path.exists(factura):
            tree = ET.parse(factura)     
            root = tree.getroot()
            for elemento in root.findall('.//Elementos'): 
            
                for factura in elemento.findall('.//anyType[@{http://www.w3.org/2001/XMLSchema-instance}type="Factura"]', namespaces={'xsi': 'http://www.w3.org/2001/XMLSchema-instance'}):

                    numeroFactura = factura.find('numeroFactura').text
                    fechaFactura = factura.find('fechaFactura').text
                    precioTotal = factura.find('precioTotal').text
                    #servicioID = factura.find('servicioID').text
                    reservaID = factura.find('reservaID').text
                    idCliente = factura.find('idCliente').text

                    fechaFactura = datetime.strptime(fechaFactura, "%Y-%m-%dT%H:%M:%S").strftime("%Y-%m-%d %H:%M:%S")
                    precioTotal = float(precioTotal)
                    numeroFactura = int(numeroFactura)

                    facturaExistente = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'factura', 'search', [[['numeroFactura', '=', numeroFactura]]])
                    
                    if facturaExistente:
                        # Actualizar
                        self.models.execute_kw(self.dbname, self.uid, self.pwd, 'factura', 'write', [numeroFactura, {"fechaFactura":fechaFactura,"precioTotal":precioTotal,
                        "reservaID":reservaID,"idCliente":idCliente}])
                        
                        
                    else:
                        # Crear
                        new_id = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'factura', 'create', [{'numeroFactura': numeroFactura,"fechaFactura":fechaFactura,
                        "precioTotal":precioTotal,"reservaID":reservaID,"idCliente":idCliente}])

        else:
            print("WARNING: La ruta no existe")

        y: conectarFactura()