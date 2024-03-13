#!/usr/bin/python3
from xmlrpc import client
import xml.etree.ElementTree as ET
from datetime import datetime
import os,sys
import conectionClass as cc
# Conectar 



class conectarTHabitacion(cc.ConexionOdoo):


    
    def __init__(self,*args,**kwargs):
        super().__init__(*args,**kwargs)
        self.conectarTHabitacion()
        
        
        
    def conectarTHabitacion(self):

        pathRoot = os.path.abspath(__file__)
        pathName = os.path.basename(pathRoot)
        pathDirectory = pathRoot.split(pathName)[0]
        thab = pathDirectory + "TipoHabitacion.XML"
        if os.path.exists(thab):
            tree = ET.parse(thab)     
            root = tree.getroot()
            
        else:
            print("WARNING: La ruta no existe")


        for elemento in root.findall('.//Elementos'): 
            
            for thabitacion in elemento.findall('.//anyType[@{http://www.w3.org/2001/XMLSchema-instance}type="TipoHabitacion"]', namespaces={'xsi': 'http://www.w3.org/2001/XMLSchema-instance'}):

                tipoID = thabitacion.find('tipoID').text
                descripcion = thabitacion.find('descripcion').text

                tipoID = int(tipoID)
                
                
                temporadaExistente = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'tipo.habitacion', 'search', [[['tipoID', '=', tipoID]]])
                
                if temporadaExistente:
                    # Actualizar
                    self.models.execute_kw(self.dbname, self.uid, self.pwd, 'tipo.habitacion', 'write', [tipoID, {"descripcion":descripcion}])
                    
                    
                else:
                    # Crear
                    self.models.execute_kw(self.dbname, self.uid, self.pwd, 'tipo.habitacion', 'create', [{'tipoID': tipoID,"descripcion":descripcion}])
                    

