#!/usr/bin/python3
from xmlrpc import client
import xml.etree.ElementTree as ET
from datetime import datetime
import os,sys
import conectionClass as cc
# Conectar 



class conectarTemporada(cc.ConexionOdoo):


    
    def __init__(self,*args,**kwargs):
        super().__init__(*args,**kwargs)
        self.conectarTemporada()
        
        
        
    def conectarTemporada(self):

        pathRoot = os.path.abspath(__file__)
        pathName = os.path.basename(pathRoot)
        pathDirectory = pathRoot.split(pathName)[0]
        temporada = pathDirectory + "Temporada.XML"
        if os.path.exists(temporada):
            tree = ET.parse(temporada)     
            root = tree.getroot()
            
        else:
            print("WARNING: La ruta no existe")


        for elemento in root.findall('.//Elementos'): 
            
            for temporada in elemento.findall('.//anyType[@{http://www.w3.org/2001/XMLSchema-instance}type="Temporada"]', namespaces={'xsi': 'http://www.w3.org/2001/XMLSchema-instance'}):

                temporadaID = temporada.find('temporadaID').text
                descripcion = temporada.find('descripcion').text

                temporadaID = int(temporadaID)
                
                
                temporadaExistente = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'temporada', 'search', [[['temporadaID', '=', temporadaID]]])
                
                if temporadaExistente:
                    # Actualizar
                    self.models.execute_kw(self.dbname, self.uid, self.pwd, 'temporada', 'write', [temporadaID, {"descripcion":descripcion}])
                    
                    
                else:
                    # Crear
                    new_id = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'temporada', 'create', [{'temporadaID': temporadaID,"descripcion":descripcion}])
                    

