#!/usr/bin/python3
from xmlrpc import client
import xml.etree.ElementTree as ET
from datetime import datetime
import os,sys
import conectionClass as cc
# Conectar 

class conectarClientes(cc.ConexionOdoo):

    def __init__(self,*args,**kwargs):
        super().__init__(*args,**kwargs)
        self.conectarClientes()

    def conectarClientes(self):

        pathRoot = os.path.abspath(__file__)
        pathName = os.path.basename(pathRoot)
        pathDirectory = pathRoot.split(pathName)[0]
        clientes = pathDirectory + "Clientes.XML"
        if os.path.exists(clientes):
            tree = ET.parse(clientes)     
            root = tree.getroot()
            
        else:
            print("WARNING: La ruta no existe")

        for elemento in root.findall('.//Elementos'): 
            
            for cliente in elemento.findall('.//anyType[@{http://www.w3.org/2001/XMLSchema-instance}type="Clientes"]', namespaces={'xsi': 'http://www.w3.org/2001/XMLSchema-instance'}):
                NIF = cliente.find('NIF').text
                nombre = cliente.find('nombre').text
                apellidos = cliente.find('apellidos').text
                telefono = cliente.find('telefono').text
                email = cliente.find('email').text
                VIP = cliente.find('VIP').text
                direccion = cliente.find('direccion').text
                ciudad = cliente.find('ciudad').text
                cp = cliente.find('cp').text
                pais = cliente.find('pais').text
                fechaN = cliente.find('fechaN').text
                nombreCuenta = cliente.find('nombreCuenta').text
                numeroCuenta = cliente.find('numeroCuenta').text
                fechaAlta = cliente.find('fechaAlta').text

                VIP = int(VIP)
                cp = int(cp)
                fechaN =  datetime.strptime(fechaN, "%Y-%m-%dT%H:%M:%S").strftime("%Y-%m-%d %H:%M:%S")
                fechaAlta = datetime.strptime(fechaAlta, "%Y-%m-%dT%H:%M:%S").strftime("%Y-%m-%d %H:%M:%S")

                cliente_existente = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'cliente', 'search', [[['NIF', '=', NIF]]])

                if cliente_existente:
                    # Actualizar
                    self.models.execute_kw(self.dbname, self.uid, self.pwd, 'cliente', 'write', [cliente_existente, {
                        "nombre": nombre, "apellidos": apellidos, "telefono": telefono, "email": email, "VIP": VIP,
                        "direccion": direccion, "ciudad": ciudad, "cp": cp, "pais": pais, "fechaN": fechaN
                        , "nombreCuenta": nombreCuenta, "numeroCuenta": numeroCuenta,
                        "fechaAlta": fechaAlta}])
                else:
                    # Crear
                    new_id = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'cliente', 'create', [
                        {"NIF": NIF, "nombre": nombre, "apellidos": apellidos, "telefono": telefono, "email": email,
                        "VIP": VIP, "direccion": direccion, "ciudad": ciudad, "cp": cp, "pais": pais, "fechaN": fechaN
                        , "nombreCuenta": nombreCuenta, "numeroCuenta": numeroCuenta,
                        "fechaAlta": fechaAlta}])
