#!/usr/bin/python3
from xmlrpc import client
import xml.etree.ElementTree as ET
from datetime import datetime
import os,sys
import conectionClass as cc
# Conectar 



class conectarServicio(cc.ConexionOdoo):


    
    def __init__(self,*args,**kwargs):
        super().__init__(*args,**kwargs)
        self.conectarServicio()
        
        
        
    def conectarServicio(self):

        pathRoot = os.path.abspath(__file__)
        pathName = os.path.basename(pathRoot)
        pathDirectory = pathRoot.split(pathName)[0]
        servicio = pathDirectory + "Servicio.XML"
        if os.path.exists(servicio):
            tree = ET.parse(servicio)     
            root = tree.getroot()
            
        else:
            print("WARNING: La ruta no existe")


        for elemento in root.findall('.//Elementos'): 
            
            for each in elemento.findall('.//anyType[@{http://www.w3.org/2001/XMLSchema-instance}type="Servicio"]', namespaces={'xsi': 'http://www.w3.org/2001/XMLSchema-instance'}):

                idServicio = each.find('idServicio').text
                descripcion = each.find('descripcion').text
                precioServicio = each.find('precioServicio').text
                permisoAlta = each.find('permisoAlta').text
                permisoMedia = each.find('permisoMedia').text
                permisoBaja = each.find('permisoBaja').text
                precioAlta = each.find('precioAlta').text
                precioMedia = each.find('precioMedia').text
                precioBaja = each.find('precioBaja').text
                descVIP = each.find('descVIP').text

                idServicio = int(idServicio)
                permisoAlta = int(permisoAlta)
                permisoMedia = int(permisoMedia)
                permisoBaja = int(permisoBaja)
                precioServicio = float(precioServicio)
                precioAlta = float(precioAlta)
                precioMedia = float(precioMedia)
                precioBaja = float(precioBaja)
                descVIP = float(descVIP)

                servicioExiste = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'servicio', 'search', [[['idServicio', '=', idServicio]]])
                
                if servicioExiste:
                    # Actualizar
                    self.models.execute_kw(self.dbname, self.uid, self.pwd, 'servicio', 'write', [idServicio, {"descripcion":descripcion,"permisoAlta":permisoAlta,
                                                                                                               "permisoMedia":permisoMedia,"permisoBaja":permisoBaja,
                                                                                                               "precioAlta":precioAlta,"precioMedia":precioMedia,"precioBaja":precioBaja,"precioServicio":precioServicio,"descVIP":descVIP}])
                    
                    
                else:
                    # Crear
                    self.models.execute_kw(self.dbname, self.uid, self.pwd, 'servicio', 'create', [{"descripcion":descripcion,'idServicio': idServicio,"permisoAlta":permisoAlta,
                                                                                                               "permisoMedia":permisoMedia,"permisoBaja":permisoBaja,
                                                                                                               "precioAlta":precioAlta,"precioMedia":precioMedia,"precioBaja":precioBaja,"precioServicio":precioServicio,"descVIP":descVIP}])
                    

