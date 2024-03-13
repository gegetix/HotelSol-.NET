#!/usr/bin/python3
from xmlrpc import client
import xml.etree.ElementTree as ET
from datetime import datetime
import os,sys
import conectionClass as cc
# Conectar 

class conectarHabitacion(cc.ConexionOdoo):

    def __init__(self,*args,**kwargs):
        super().__init__(*args,**kwargs)
        self.conectarHabitacion()

    def conectarHabitacion(self):

        pathRoot = os.path.abspath(__file__)
        pathName = os.path.basename(pathRoot)
        pathDirectory = pathRoot.split(pathName)[0]
        habitacion = pathDirectory + "Habitacion.XML"
        if os.path.exists(habitacion):
            tree = ET.parse(habitacion)     
            root = tree.getroot()
            for elemento in root.findall('.//Elementos'): 
            
                for each in elemento.findall('.//anyType[@{http://www.w3.org/2001/XMLSchema-instance}type="Habitacion"]', namespaces={'xsi': 'http://www.w3.org/2001/XMLSchema-instance'}):
                    numeroHabitacion = each.find('numeroHabitacion').text
                    descripcion = each.find('descripcion').text
                    tipoID = each.find('tipoID').text
                    minNoches = each.find('minNoches').text
                    maxPersonas = each.find('maxPersonas').text
                    precioAlta = each.find('precioAlta').text
                    PrecioMedia = each.find('PrecioMedia').text
                    precioBaja = each.find('precioBaja').text
                    fueraServicio = each.find('fueraServicio').text

                    numeroHabitacion = int(numeroHabitacion)
                    tipoID = int(tipoID)
                    minNoches = int(minNoches)
                    maxPersonas = int(maxPersonas)
                    precioAlta = float(precioAlta)
                    PrecioMedia = float(PrecioMedia)
                    precioBaja = float(precioBaja)
                    fueraServicio = int(fueraServicio)

                    habitacionExistente = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'habitacion', 'search', [[['numeroHabitacion', '=', numeroHabitacion]]])

                    if habitacionExistente:
                        # Actualizar
                        self.models.execute_kw(self.dbname, self.uid, self.pwd, 'habitacion', 'write', [habitacionExistente, {
                            "descripcion": descripcion, "tipoID": tipoID, "minNoches": minNoches, "maxPersonas": maxPersonas, "precioAlta": precioAlta,
                            "PrecioMedia": PrecioMedia, "precioBaja": precioBaja, "fueraServicio": fueraServicio}])
                    else:
                        # Crear
                        new_id = self.models.execute_kw(self.dbname, self.uid, self.pwd, 'habitacion', 'create', [
                            {"numeroHabitacion": numeroHabitacion, "descripcion": descripcion, "tipoID": tipoID, "minNoches": minNoches, "maxPersonas": maxPersonas, "precioAlta": precioAlta,
                            "PrecioMedia": PrecioMedia, "precioBaja": precioBaja, "fueraServicio": fueraServicio}])

        else:
            print("WARNING: La ruta no existe")

        y: conectarHabitacion()
