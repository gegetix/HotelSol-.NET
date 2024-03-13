#!/usr/bin/python3
from xmlrpc import client
import xml.etree.ElementTree as ET
import os,sys
import conectionClass as cc
# Conectar 

class conectarRegimenPension(cc.ConexionOdoo):

    def __init__(self,*args,**kwargs):
        super().__init__(*args,**kwargs)
        self.conectarRegimenPension()
         
    def conectarRegimenPension(self):

        pathRoot = os.path.abspath(__file__)
        pathName = os.path.basename(pathRoot)
        pathDirectory = pathRoot.split(pathName)[0]
        RegimenPension = pathDirectory + "RegimenPension.XML"
        if os.path.exists(RegimenPension):
            tree = ET.parse(RegimenPension)     
            root = tree.getroot()
            
        else:
            print("WARNING: La ruta no existe")

        for elemento in root.findall('.//Elementos'): 
            
            for RegimenPension in elemento.findall('.//anyType[@{http://www.w3.org/2001/XMLSchema-instance}type="RegimenPension"]', namespaces={'xsi': 'http://www.w3.org/2001/XMLSchema-instance'}):

                pensionID = RegimenPension.find('pensionID').text
                descripcion = RegimenPension.find('descripcion').text
                precio = RegimenPension.find('precio').text
                
                pensionID = int(pensionID)
                precio = float(precio)

                regimenExistente = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'regimen', 'search', [[['pensionID', '=', pensionID]]])
                
                if regimenExistente:
                    # Actualizar
                    self.models.execute_kw(self.dbname, self.uid, self.pwd, 'regimen', 'write', [pensionID, {"descripcion":descripcion,"precio":precio}])
                    
                else:
                    # Crear
                    new_id = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'regimen', 'create', [{'pensionID': pensionID,"descripcion":descripcion,"precio":precio}])

